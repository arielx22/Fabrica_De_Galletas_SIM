using Fábrica_De_Galletas_SIM.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Fábrica_De_Galletas_SIM
{
    public partial class simulacionFabricaGalletas : Form
    {
        private List<Silo> silos;
        private Camion camion;
        private int desde;
        private int hasta;
        private double tamañoMaximoSilo;
        public simulacionFabricaGalletas()
        {
            camion = new Camion();
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (txtBoxTamañoMaximoSilo.Text != "") { tamañoMaximoSilo = Math.Round((Convert.ToDouble(txtBoxTamañoMaximoSilo.Text)), 2); }
            if (ValidarCampos() && validarDesdeHasta())
            {
                dgvSimulacion.Rows.Clear();
                lblCantidadCamiones.Text = "Cantidad Camiones:";
                lblDias.Text = "Dias:";
                lblPromedioCamionesDias.Text = "Promedio de Camiones en Dias:";

                silos = new List<Silo>
                {
                    new Silo(1,tamañoMaximoSilo) { cantidad = Math.Round((Convert.ToDouble(txtBoxSilo1Cantidad.Text)),2)},
                    new Silo(2,tamañoMaximoSilo) { cantidad = Math.Round((Convert.ToDouble(txtBoxSilo2Cantidad.Text)),2)},
                    new Silo(3,tamañoMaximoSilo) { cantidad = Math.Round((Convert.ToDouble(txtBoxSilo3Cantidad.Text)),2)},
                    new Silo(4,tamañoMaximoSilo) { cantidad = Math.Round((Convert.ToDouble(txtBoxSilo4Cantidad.Text)),2)}
                };
                //Asignar estados a los silos
                silos.ForEach(s => s.determinarEstado());

                Random randomLlegadaCamion = new Random();
                Thread.Sleep(1);
                Random randomTamañoCamion = new Random();
                int filas = Convert.ToInt32(txtBoxFilas.Text) + 1;
                int ultimaFila = 0;
                double tiempo = 0;
                double tiempoAnterior = 0;
                string evento = "";
                //Para Abastecimiento
                bool abastecimiento = false;
                double tasaAbastecimiento = 0.5;
                double tiempoInicoAbastecimiento = -1;
                double horaFinAbastecimiento = -1;
                int indiceSiloAbastecimiento = 0;
                //Para Llegada Camion
                bool llegadaProgramada = false;
                double proximoCamion = -1;
                //bool cancelacionLlegada = false;
                //Para el Camion
                camion.id = 0;
                camion.estado = "";
                camion.tamañoCamion = 0;
                camion.cantidadActual = -1;
                //Para Preparacion Descarga dle camion
                double tiempoPreparacion = 1.0 / 6.0;
                double finPreparacionDescarga = -1;
                int indiceSiloPreparacionDescarga = 0;
                bool preparacionDescarga = false;
                //Para fin descarga
                double finDescarga = -1;
                double tasaDescarga = 5;
                int indiceSiloDescarga = 0;
                //Resultados
                double dias = 0;
                //Colas
                int colaCamion = 0;
                for (int fila = 0; fila < filas; fila++)
                {
                    if (fila >= desde && fila <= hasta) ultimaFila = dgvSimulacion.Rows.Add();
                    CargarDatoSimulacion(fila, ultimaFila, "fila", Convert.ToString(fila));
                    CargarDatoSimulacion(fila, ultimaFila, "tiempo", Convert.ToString(tiempo));
                    CargarDatoSimulacion(fila, ultimaFila, "evento", evento);

                    if (evento == "Fin_descarga_camion")
                    {
                        //En caso de que sobre tn de hilos luego de la descarga, el silo se llenó
                        double cantidadSobranteCamionLlenarSilo = camion.cantidadActual - (tamañoMaximoSilo - silos[indiceSiloDescarga].cantidad);
                        if (cantidadSobranteCamionLlenarSilo >= 0)
                        {
                            if (cantidadSobranteCamionLlenarSilo == 0)
                            {
                                camion.estado = "Fin Totalmente Descargado";                                
                                //Si hay un camion en la cola, se carga al sistema
                                if (colaCamion > 0)
                                {
                                    camion.id += 1;
                                    camion.cantidadActual = camion.tamañoCamion;
                                    double rndTamañoCamion = Math.Round(randomTamañoCamion.NextDouble() * 0.99, 2);
                                    CargarDatoSimulacion(fila, ultimaFila, "rndTamañoCamion", Convert.ToString(rndTamañoCamion));
                                    camion.tamañoCamion = (rndTamañoCamion < 0.50) ? 10 : 12; // 10 o 12 toneladas
                                    colaCamion -= 1;
                                    camion.estado = "Preparación Descarga";
                                }
                                
                            }
                            else
                            {
                                camion.estado = "Preparación Descarga";
                            }
                            camion.cantidadActual = cantidadSobranteCamionLlenarSilo;
                            silos[indiceSiloDescarga].cantidad = tamañoMaximoSilo;
                            silos[indiceSiloDescarga].estado = "Lleno";
                        }
                        else
                        {
                            silos[indiceSiloDescarga].cantidad += camion.cantidadActual;
                            camion.cantidadActual = 0;
                            silos[indiceSiloDescarga].estado = "No Vacio";
                            camion.estado = "Fin Totalmente Descargado";

                        }
                    }
                    //Programación fin abastecimiento
                    if (evento == "Fin_abastecimiento")
                    {
                        silos[indiceSiloAbastecimiento].cantidad = 0;
                        silos[indiceSiloAbastecimiento].estado = "Vacio";
                        if (camion.estado == "Descargando")
                        {
                            var camionCantidadAnterior = camion.cantidadActual;
                            var camionCantidadActual = Math.Round((camion.cantidadActual - ((tiempo - tiempoAnterior) * tasaDescarga)), 2);
                            silos[indiceSiloDescarga].cantidad = silos[indiceSiloDescarga].cantidad + (camionCantidadAnterior - camionCantidadActual);
                            camion.cantidadActual = camionCantidadActual;
                        }
                        if (camion.estado == "En Espera")
                        {
                            camion.estado = "Preparación Descarga";
                        }
                    }
                    if (abastecimiento == true && tiempo == horaFinAbastecimiento)
                    {
                        abastecimiento = false;
                        horaFinAbastecimiento = -1;
                    }
                    if (abastecimiento == true)
                    {
                        CargarDatoSimulacion(fila, ultimaFila, "horaIncioAbastecimiento", Convert.ToString(tiempoInicoAbastecimiento));
                        silos[indiceSiloAbastecimiento].cantidad = Math.Round((silos[indiceSiloAbastecimiento].cantidad - ((tiempo - tiempoAnterior) * tasaAbastecimiento)), 2);
                    }
                    if (abastecimiento == false)
                    {
                        bool NoVacio = false;
                        for (int i = 0; i < silos.Count; i++)
                        {
                            if (silos[i].estado == "Lleno")
                            {
                                abastecimiento = true;
                                indiceSiloAbastecimiento = i;
                                tiempoInicoAbastecimiento = tiempo;
                                CargarDatosAbastecimiento(fila, ultimaFila, tiempoInicoAbastecimiento, ref horaFinAbastecimiento, indiceSiloAbastecimiento, tasaAbastecimiento);
                                break;
                            }
                            if (silos[i].estado == "No Vacio")
                            {
                                NoVacio = true;
                                if (silos[i].cantidad == 0) indiceSiloAbastecimiento = i;
                                if (silos[i].cantidad > silos[indiceSiloAbastecimiento].cantidad) indiceSiloAbastecimiento = i;
                            }

                        }
                        if (NoVacio)
                        {
                            abastecimiento = true;
                            tiempoInicoAbastecimiento = tiempo;
                            CargarDatosAbastecimiento(fila, ultimaFila, tiempoInicoAbastecimiento, ref horaFinAbastecimiento, indiceSiloAbastecimiento, tasaAbastecimiento);
                        }
                    }
                    //Definir nuevo camion y no hay llegada_camion Programada
                    if (evento == "Llegada_camion")
                    {
                        if (camion.estado == "")
                        {
                            camion.id += 1;
                            camion.estado = "Preparación Descarga";
                            double rndTamañoCamion = Math.Round(randomTamañoCamion.NextDouble() * 0.99, 2);
                            CargarDatoSimulacion(fila, ultimaFila, "rndTamañoCamion", Convert.ToString(rndTamañoCamion));
                            camion.tamañoCamion = (rndTamañoCamion < 0.50) ? 10 : 12; // 10 o 12 toneladas
                            camion.cantidadActual = camion.tamañoCamion;
                        }
                        else
                        {
                            if (camion.estado == "Fin Totalmente Descargado")
                            {
                                  camion.id += 1;
                                  camion.estado = "Preparación Descarga";
                                  double rndTamañoCamion = Math.Round(randomTamañoCamion.NextDouble() * 0.99, 2);
                                  CargarDatoSimulacion(fila, ultimaFila, "rndTamañoCamion", Convert.ToString(rndTamañoCamion));
                                  camion.tamañoCamion = (rndTamañoCamion < 0.50) ? 10 : 12; // 10 o 12 toneladas
                                  camion.cantidadActual = camion.tamañoCamion;

                            }
                            else
                            {
                                colaCamion += 1;
                            }
                        }
                        llegadaProgramada = false;

                    }
                    //Programar el evento de la llegada del camion
                    //Si algun silo de la lista de silos tiene estado Vacio o No Vacio es true
                    if (silos.Any(silo => silo.estado == "Vacio" || silo.estado == "No Vacio") && llegadaProgramada != true)
                    {
                        llegadaProgramada = true;
                        ProgramarEventoLlegadaCamion(tiempo, randomLlegadaCamion, fila, ultimaFila, ref proximoCamion);
                    }
                    //Programar el evento Fin Preparacion
                    if (camion.estado == "Preparación Descarga" && evento != "Fin_preparacion_descarga" && preparacionDescarga == false)
                    {
                        // Filtrar los silos vacíos
                        var silosVacios = silos.Where(s => s.estado == "Vacio").ToList();

                        // Si hay silos vacíos, seleccionamos el de menor numero
                        if (silosVacios.Any())
                        {
                            var siloSeleccionado = silosVacios.OrderBy(s => s.numero).First();
                            indiceSiloPreparacionDescarga = silos.IndexOf(siloSeleccionado); // Guardar el índice
                            ProgramarEventoFinPreparacionCamion(tiempo, fila, ultimaFila, tiempoPreparacion, ref finPreparacionDescarga);
                            silos[indiceSiloPreparacionDescarga].estado = "Preparación Descarga";
                            preparacionDescarga = true;
                        }
                        else
                        {
                            var silosNoVacios = silos.Where(s => s.estado == "No Vacio").ToList();
                            if (silosNoVacios.Any())
                            {
                                var silosValidos = silos.Where(s => s.estado == "No Vacio").ToList();

                                // Seleccionar el silo con menor cantidad y en caso de empate, el de menor numero
                                var siloSeleccionado = silosValidos.OrderBy(s => s.cantidad).ThenBy(s => s.numero).First();
                                indiceSiloPreparacionDescarga = silos.IndexOf(siloSeleccionado); // Guardar el índice

                                ProgramarEventoFinPreparacionCamion(tiempo, fila, ultimaFila, tiempoPreparacion, ref finPreparacionDescarga);
                                silos[indiceSiloPreparacionDescarga].estado = "Preparación Descarga";
                                preparacionDescarga = true;
                            }
                            else
                            {
                                camion.estado = "En Espera";
                            }
                        }
                    }
                    // Programar Fin Descarga
                        if (evento == "Fin_preparacion_descarga")
                    {
                        //Ver indiceSilo, el indice tiene q ser del silo con estado Preparacion Descarga
                        //En caso de que al camion le sobre Tn de harina con respecto al silo actual va por el camino else
                        indiceSiloDescarga = indiceSiloPreparacionDescarga;
                        indiceSiloPreparacionDescarga = 0;
                        preparacionDescarga = false;
                        if ((silos[indiceSiloDescarga].cantidad + camion.cantidadActual) <= tamañoMaximoSilo)
                        {
                            double tiempoDescarga = Math.Round((camion.cantidadActual / tasaDescarga), 2);
                            finDescarga = tiempoDescarga + tiempo;
                            ProgramarFinDescarga(fila, ultimaFila, tasaDescarga, tiempoDescarga, finDescarga);
                        }
                        else
                        {
                            double tiempoDescarga = Math.Round(((tamañoMaximoSilo - silos[indiceSiloDescarga].cantidad) / tasaDescarga), 2);
                            finDescarga = tiempoDescarga + tiempo;
                            ProgramarFinDescarga(fila, ultimaFila, tasaDescarga, tiempoDescarga, finDescarga);
                        }
                        camion.estado = "Descargando";
                        silos[indiceSiloDescarga].estado = "Descargando";
                    }
                    //Cargar Camion en la grilla
                    if (camion.id >= 1)
                    {
                        if (!(evento == "Fin_abastecimiento" && camion.estado == "Fin Totalmente Descargado")) CargarDatosCamion(fila, ultimaFila);

                    }
                    CargarDatoSimulacion(fila, ultimaFila, "colaCamion", Convert.ToString(colaCamion));
                    //Resultado (Metricas)
                    dias = Math.Round((tiempo / 24), 2);
                    CargarDatoSimulacion(fila, ultimaFila, "dias", Convert.ToString(dias));
                    CargarDatoSimulacion(fila, ultimaFila, "cantidadCamiones", Convert.ToString(camion.id));
                    CargarDatoSimulacion(fila, ultimaFila, "promedioCamion", Convert.ToString(Math.Round((camion.id / dias), 2)));
                    //Parte Final defino el evento para la proxima iteración y defino el tiempo de la siguiente iteración
                    tiempoAnterior = tiempo;
                    definirProximoEvento(ref evento, ref proximoCamion, ref finPreparacionDescarga, ref finDescarga, ref horaFinAbastecimiento, ref tiempo);

                    //Carga Silos en la grilla
                    foreach (var siloGrilla in silos)
                    {
                        CargarDatoSimulacion(fila, ultimaFila, $"silo{siloGrilla.numero}Estado", siloGrilla.estado);
                        CargarDatoSimulacion(fila, ultimaFila, $"silo{siloGrilla.numero}Almacenamiento", Convert.ToString(siloGrilla.cantidad));
                    }

                }              
                lblCantidadCamiones.Text += $" {camion.id+colaCamion}";
                lblDias.Text += $" {dias}";
                lblPromedioCamionesDias.Text += $" {Math.Round(((camion.id + colaCamion) / dias), 2)}";
            }
        }
        public bool ValidarCampos()
        {
            //Verifica que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtBoxFilas.Text)
                || string.IsNullOrWhiteSpace(txtBoxSilo1Cantidad.Text)
                || string.IsNullOrWhiteSpace(txtBoxSilo2Cantidad.Text)
                || string.IsNullOrWhiteSpace(txtBoxSilo3Cantidad.Text)
                || string.IsNullOrWhiteSpace(txtBoxSilo4Cantidad.Text)
                )
            {
                MessageBox.Show("Por favor, complete los campos con *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Verifica que los valores sean números positivos
            if (!double.TryParse(txtBoxTamañoMaximoSilo.Text, out double tamaño) || tamaño < 5 || tamaño > 100)
            {
                MessageBox.Show("Por favor, complete el campo tamaño maximo de los silos con un valor no menor a 15 Tn " +
                    "y no mayor de 100 Tn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (!int.TryParse(txtBoxFilas.Text, out int filas) || filas <= 0)
            {
                MessageBox.Show("Por favor, complete el campo fila con valor mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!double.TryParse(txtBoxSilo1Cantidad.Text, out double cantidadSilo1) || cantidadSilo1 < 0 || cantidadSilo1 > tamañoMaximoSilo ||
                !double.TryParse(txtBoxSilo2Cantidad.Text, out double cantidadSilo2) || cantidadSilo2 < 0 || cantidadSilo2 > tamañoMaximoSilo ||
                !double.TryParse(txtBoxSilo2Cantidad.Text, out double cantidadSilo3) || cantidadSilo3 < 0 || cantidadSilo3 > tamañoMaximoSilo ||
                !double.TryParse(txtBoxSilo2Cantidad.Text, out double cantidadSilo4) || cantidadSilo4 < 0 || cantidadSilo4 > tamañoMaximoSilo)
            {
                MessageBox.Show("Por favor, complete los silos con valores mayores o igual 0 y " +
                    $"la cantidad de almecenado de los silos sean valores no mayores a {tamañoMaximoSilo}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            
            return true;
        }

        public bool validarDesdeHasta()
        {
            //Obtener los valores de los TextBox para el rango
            desde = int.TryParse(txtBoxDesde.Text, out int d) ? d : 0;
            //Si no se proporciona hasta, se establece como desde + 500
            hasta = int.TryParse(txtBoxHasta.Text, out int h) ? h : (desde + 500);
            //Si hasta se proporciona pero desde no, se calcula desde como hasta - 500
            if (hasta > 0 && txtBoxDesde.Text.Trim() == "")
            {
                if (hasta > 500) desde = hasta - 500;
                else desde = 0;
            }

            // Validar que 'desde' sea menor que 'hasta'
            if (desde >= hasta)
            {
                MessageBox.Show("El valor 'Desde' debe ser menor que el valor 'Hasta'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //rango permitido (0-1000)
            if (hasta - desde > 1000)
            {
                MessageBox.Show("El rango permitido entre 'Desde' y 'Hasta' no puede ser mayor a 1000.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void CargarDatoSimulacion(int fila, int ultimaFila, string nombreColumna, string dato) 
        {
            if (fila >= desde && fila <= hasta)
                dgvSimulacion.Rows[ultimaFila].Cells[$"{nombreColumna}"].Value = dato;
        }
        public void CargarDatosAbastecimiento(int fila, int ultimaFila, double tiempoInicoAbastecimiento, ref double horaFinAbastecimiento,int indiceSiloAbastecimiento, double tasaAbastecimiento)
        {
            CargarDatoSimulacion(fila, ultimaFila, "horaIncioAbastecimiento", Convert.ToString(tiempoInicoAbastecimiento));
            double entreHoraFinAbastecimiento = Math.Round((silos[indiceSiloAbastecimiento].cantidad / tasaAbastecimiento), 2);
            CargarDatoSimulacion(fila, ultimaFila, "entreHoraFinAbastecimiento", Convert.ToString(entreHoraFinAbastecimiento));
            horaFinAbastecimiento = entreHoraFinAbastecimiento + tiempoInicoAbastecimiento;
            CargarDatoSimulacion(fila, ultimaFila, "horaFinAbastecimiento", Convert.ToString(horaFinAbastecimiento));
            //cambio el estado del silo
            silos[indiceSiloAbastecimiento].estado = "Abasteciendo Planta";
           
        }


        public void ProgramarEventoLlegadaCamion(double tiempo, Random randomLlegadaCamion, int fila,int ultimaFila, ref double proximoCamion) {
            double rndLlegadaCamion = Math.Round(randomLlegadaCamion.NextDouble() * 0.99, 2);
            CargarDatoSimulacion(fila, ultimaFila, "rndLlegadaCamion", Convert.ToString(rndLlegadaCamion));
            double uniforme = 5 + rndLlegadaCamion * (9 - 5);
            uniforme = Math.Round(uniforme, 2);
            CargarDatoSimulacion(fila, ultimaFila, "tiempoEntreLlegada", Convert.ToString(uniforme));
            proximoCamion = tiempo + uniforme;
            CargarDatoSimulacion(fila, ultimaFila, "proximoCamion", Convert.ToString(proximoCamion));
        }
        public void ProgramarEventoFinPreparacionCamion(double tiempo, int fila,int ultimaFila,double tiempoPreparacion,ref double finPreparacionDescarga)
        {
            tiempoPreparacion = Math.Round(tiempoPreparacion, 2);
            CargarDatoSimulacion(fila, ultimaFila, "tiempoPreparacion", Convert.ToString(tiempoPreparacion));
            finPreparacionDescarga = tiempoPreparacion + tiempo;
            CargarDatoSimulacion(fila, ultimaFila, "finPreparacionDescarga", Convert.ToString(finPreparacionDescarga));
        }
        public void ProgramarFinDescarga(int fila, int ultimaFila, double tasaDescarga, double tiempoDescarga, double finDescarga)
        {
            CargarDatoSimulacion(fila, ultimaFila, "tasaDescarga", Convert.ToString(tasaDescarga));
            CargarDatoSimulacion(fila, ultimaFila, "tiempoDescarga", Convert.ToString(tiempoDescarga));
            CargarDatoSimulacion(fila, ultimaFila, "finDescarga", Convert.ToString(finDescarga));
        }
        public string definirProximoEvento(ref string evento, ref double proximoCamion, ref double finPreparacionDescarga, ref double finDescarga,
            ref double horaFinAbastecimiento, ref double tiempo)
        {
            // Crear una lista de los tiempos de los eventos junto con su nombre correspondiente
            var tiemposEventos = new List<(double tiempo, string nombreEvento)>
            {
                (proximoCamion, "Llegada_camion"),
                (finPreparacionDescarga, "Fin_preparacion_descarga"),
                (finDescarga, "Fin_descarga_camion"),
                (horaFinAbastecimiento, "Fin_abastecimiento")
            };

            var tiemposValidos = tiemposEventos.Where(te => te.tiempo != -1).ToList();

            //obtener el que tiene el menor tiempo
            var proximoEvento = tiemposValidos.OrderBy(te => te.tiempo).First();
            evento = proximoEvento.nombreEvento;
    
            // Establecer a -1 el evento con el menor tiempo
            switch (evento)
            {
                case "Llegada_camion":
                    tiempo = proximoCamion;
                    proximoCamion = -1;
                    break;
                case "Fin_preparacion_descarga":
                    tiempo = finPreparacionDescarga;
                    finPreparacionDescarga = -1;
                    break;
                case "Fin_descarga_camion":
                    tiempo = finDescarga;
                    finDescarga = -1;
                    break;
                case "Fin_abastecimiento":
                    tiempo = horaFinAbastecimiento;
                    break;
            }

            return evento;
        }
        public string ObtenerProximoEvento(List<(double tiempo, string nombreEvento)> tiemposEventos)
        {
            // Filtrar los eventos que tienen tiempo -1
            var tiemposValidos = tiemposEventos.Where(te => te.tiempo != -1).ToList();

            //obtener el que tiene el menor tiempo
            var proximoEvento = tiemposValidos.OrderBy(te => te.tiempo).First();
            return proximoEvento.nombreEvento;
        }
        public void CargarDatosCamion(int fila, int ultimaFila)
        {
            CargarDatoSimulacion(fila, ultimaFila, "idCamion", Convert.ToString(camion.id));
            CargarDatoSimulacion(fila, ultimaFila, "camionEstado", Convert.ToString(camion.estado));
            CargarDatoSimulacion(fila, ultimaFila, "tamañoCamion", Convert.ToString(camion.tamañoCamion));
            CargarDatoSimulacion(fila, ultimaFila, "cantidadActual", Convert.ToString(camion.cantidadActual));
        }
        public void txtBox_KeyPressSilos(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir números, tecla de retroceso y una única coma para decimales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Cancelar el evento si no es un número o la coma
            }

            // Permitir solo una coma en el texto
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true; // Si ya hay una coma, cancelar la entrada
            }

            // Limitar la entrada a 6 caracteres (sin contar la coma)
            if (textBox != null && textBox.Text.Replace(",", "").Length >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si no es un número
            }
            // Permitir solo hasta 6 dígitos
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si se alcanza el límite de 6 dígitos
            }
        }
    }
}
