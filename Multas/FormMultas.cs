using System.Data;
using System.Diagnostics.Contracts;
using static System.Net.Mime.MediaTypeNames;

namespace Multas
{
    public partial class FormMultas : Form
    {
        public FormMultas()
        {
            InitializeComponent();
        }
        #region Enumerado

        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        #region Eventos

        /// <summary>
        /// Evento Load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMultas_Load(object sender, EventArgs e)
        {

            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();

        }

        /// <summary>
        /// Evento del bot�n crear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento del bot�n eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea eliminar el registro?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Multa c = ObtenerInformacion();
                correcto = Repositorio.EliminarMulta(c);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }

        }

        /// <summary>
        /// Evento del bot�n Modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento click del bot�n guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la informaci�n
                Multa c = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repositorio.CrearMulta(c);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repositorio.ModificarMulta(c);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos DNI, Importe y N� Agente son obligatorios.");
            }

        }

        /// <summary>
        /// Evento click del bot�n Cancelar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea salir de la edici�n?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (dgvMultas.SelectedRows.Count == 1)
                {
                    // Recargamos su informaci�n en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvMultas.SelectedRows[0]);
                }
            }
        }

        /// <summary>
        /// Evento click de la celda.
        /// Cuando se hace click en una celda se selecciona la fila entera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMultas.Rows[e.RowIndex].Selected = true;
        }

        /// <summary>
        /// Evento para cuando una fila cambia de estado en el grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operaci�n que no sea que ha cambiado la selecci�n de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);

        }

        #endregion

        #region M�todos

        /// <summary>
        /// M�todo para establecer el modo de la pantalla a edici�n.
        /// </summary>
        public void ModoPantallaEdicion()
        {
            // Limpiamos s�lo si es modo creaci�n, si es modo edici�n dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                textDni.Text = "";
                dateTimePickerFechaExp.Value = DateTime.Now;
                dateTimePickerFechaLim.Value = DateTime.Now;
                textObservaciones.Text = "";
                textNAgente.Text = "";
                textImporte.Text = "";
                textId.Text = "";
            }

            buttonGuardar.Enabled = true;
            buttonCancelar.Enabled = true;
            textDni.Enabled = true;
            dateTimePickerFechaExp.Enabled = true;
            dateTimePickerFechaLim.Enabled = true;
            textObservaciones.Enabled = true;
            textImporte.Enabled = true;
            textNAgente.Enabled = true;
            textId.Enabled = false;

            buttonCrear.Enabled = false;
            buttonBorrar.Enabled = false;
            buttonEditar.Enabled = false;

            dgvMultas.Enabled = false;
        }

        /// <summary>
        /// M�todo para establecer el modo de la pantalla a edici�n.
        /// </summary>
        public void ModoPantallaLectura()
        {
            textDni.Text = "";
            dateTimePickerFechaExp.Value = DateTime.Now;
            dateTimePickerFechaLim.Value = DateTime.Now;
            textImporte.Text = "";
            textObservaciones.Text = "";
            textNAgente.Text = "";
            textId.Text = "";

            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonCrear.Enabled = true;
            buttonBorrar.Enabled = true;
            buttonEditar.Enabled = true;

            textDni.Enabled = false;
            dateTimePickerFechaExp.Enabled = false;
            dateTimePickerFechaLim.Enabled = false;
            textObservaciones.Enabled = false;
            textImporte.Enabled = false;
            textNAgente.Enabled = false;
            textId.Enabled = false;

            dgvMultas.Enabled = true;
        }

        /// <summary>
        /// M�todo para obtener la informaci�n del formulario.
        /// </summary>
        /// <returns>Contacto con la informaci�n del formulario.</returns>
        public Multa ObtenerInformacion()
        {
            Multa multa = new Multa();

            multa.dni = textDni.Text;
            multa.observaciones = textObservaciones.Text;
            multa.fechaLim = dateTimePickerFechaLim.Value;
            multa.fechaExp = dateTimePickerFechaExp.Value;

            if (!String.IsNullOrEmpty(textId.Text))
            {
                multa.Id = Convert.ToInt32(textId.Text);
            }

            if (!String.IsNullOrEmpty(textImporte.Text))
            {
                multa.importe = float.Parse(textImporte.Text);
            }

            if (!String.IsNullOrEmpty(textNAgente.Text))
            {
                multa.nAgente = Convert.ToInt32(textNAgente.Text);
            }

            return multa;
        }

        /// <summary>
        /// M�todo que carga y configura el grid.
        /// </summary>
        /// <param name="Multas">DataTable con la info de las multas</param>
        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerMultas();
            dgvMultas.DataSource = ds.Tables[0];

            Console.WriteLine(dgvMultas.DataSource);
            // Tama�os columnas
            dgvMultas.Columns["Id"].Width = 40;
            dgvMultas.Columns["DNI"].Width = 150;
            dgvMultas.Columns["FechaCreacion"].Width = 150;
            dgvMultas.Columns["FechaLimite"].Width = 150;
            dgvMultas.Columns["nAgente"].Width = 120;
            dgvMultas.Columns["Importe"].Width = 120;
            dgvMultas.Columns["Observaciones"].Width = 300;

            // Renombrado columnas
            dgvMultas.Columns["FechaCreacion"].HeaderText = "Fecha Expedici�n";
            dgvMultas.Columns["FechaLimite"].HeaderText = "Fecha L�mite";
            dgvMultas.Columns["nAgente"].HeaderText = "N� Agente";

            // Formato fecha en espa�ol
            dgvMultas.Columns["FechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvMultas.Columns["FechaLimite"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        /// <summary>
        /// M�todo que selecciona la primera fila del grid si existe.
        /// </summary>
        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvMultas.Rows.Count > 0)
            {
                dgvMultas.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// M�todo que carga la informaci�n de la fila seleccionada en los controles.
        /// </summary>
        /// <param name="filaSeleccionada"></param>
        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            textDni.Text = filaSeleccionada.Cells["Dni"].Value.ToString();
            textImporte.Text = filaSeleccionada.Cells["Importe"].Value.ToString();
            dateTimePickerFechaExp.Value = (DateTime)filaSeleccionada.Cells["FechaCreacion"].Value;
            dateTimePickerFechaLim.Value = (DateTime)filaSeleccionada.Cells["FechaLimite"].Value;
            textNAgente.Text = filaSeleccionada.Cells["nAgente"].Value.ToString();
            textObservaciones.Text = filaSeleccionada.Cells["Observaciones"].Value.ToString();
            textId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
        }

        /// <summary>
        /// Funci�n que nos indica si la informaci�n obligatoria est� cumplimentada o no.
        /// </summary>
        /// <returns></returns>
        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(textDni.Text) || String.IsNullOrEmpty(textImporte.Text) || String.IsNullOrEmpty(textNAgente.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}