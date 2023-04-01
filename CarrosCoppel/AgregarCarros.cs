using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosCoppel
{
    public partial class AgregarCarros : Form
    {
        DataTable data;
        public AgregarCarros()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarCarros_Load(object sender, EventArgs e)
        {
            CargarTabla();
            txtIdCar.Enabled = false;
            try
            {
                data = ManejaMarca.obtenMarca();
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CbMarCar.Items.Add(row[1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            try
            {
                data = ManejaColor.obtenColor();
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CbColCar.Items.Add(row[1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            try
            {
                data = ManejaTipo.obtenTipo();
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        CbTipCar.Items.Add(row[1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

     

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModCar.Text))
            {
                MessageBox.Show("Debe completar la informacion: Modelo Carro");
                return;
            }
            if (CbMarCar.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar la informacion: Marca Carro");
                return;
            }
            if (string.IsNullOrEmpty(txtAñoCar.Text))
            {
                MessageBox.Show("Debe completar la informacion: Año Carro");
                return;
            }
            if (CbColCar.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar la informacion: Color Carro");
                return;
            }
            if (CbTipCar.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar la informacion: Tipo Carro");
                return;
            }
            if (rbNuevo.Checked)
            {
                string id = "";
                string mod = txtModCar.Text;
                string marca = Convert.ToString(1 + (CbMarCar.SelectedIndex));
                string año = txtAñoCar.Text;
                string color = Convert.ToString(1 + (CbColCar.SelectedIndex));
                string tipo = Convert.ToString(1 + (CbTipCar.SelectedIndex));
                carros car = new carros(id, mod, año, marca, tipo, color);
                string i = ManejaCarros.AgregarCarro(car);
                MessageBox.Show("Nuevo Carro Registrado \n ID Carro: " + i + "\n Modelo: " + mod + "\n Marca: " + marca + "\n Año: " + año + "\n Color: " + color + "\n tipo: " + tipo);

                Limpirar();
                CargarTabla();
            }
            if (rbMod.Checked)
            {
                string id = txtIdCar.Text;
                string mod = txtModCar.Text;
                string marca = Convert.ToString(1 + (CbMarCar.SelectedIndex));
                string año = txtAñoCar.Text;
                string color = Convert.ToString(1 + (CbColCar.SelectedIndex));
                string tipo = Convert.ToString(1 + (CbTipCar.SelectedIndex));
                carros car = new(id, mod, año, marca, tipo, color);
                string i = ManejaCarros.ModificarCarro(car);
                MessageBox.Show("Carro actualizado \n ID Carro: " + i + "\n Modelo: " + mod + "\n Marca: " + marca + "\n Año: " + año + "\n Color: " + color + "\n tipo: " + tipo);

                Limpirar();
                CargarTabla();
            }
           
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpirar();
        }

        private void Limpirar()
        {
            txtIdCar.Text = "";
            txtModCar.Text = "";
            CbMarCar.SelectedIndex = -1;
            txtAñoCar.Text = "";
            CbColCar.SelectedIndex = -1;
            CbTipCar.SelectedIndex = -1;
        }
        private void CargarTabla()
        {
            DataTable data = ManejaCarros.obtenCarro();
            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.AutoResizeRows();
        }

        private void rbMod_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCar.Enabled = true;
            
        }

        private void rellenar()
        {
            if (!string.IsNullOrEmpty(txtIdCar.Text))
            {
                try
                {
                    data = ManejaCarros.llenarCampos();
                    if (data.Rows.Count > 0)
                    {
                        foreach (DataRow row in data.Rows)
                        {

                            string idTabla = row[0].ToString();
                            if (txtIdCar.Text.Equals(idTabla))
                            {
                                txtModCar.Text = row[1].ToString();
                                txtAñoCar.Text = row[2].ToString();
                                CbMarCar.SelectedIndex = Convert.ToInt32(row[3].ToString())-1;
                                CbTipCar.SelectedIndex = Convert.ToInt32(row[4].ToString())-1;
                                CbColCar.SelectedIndex = Convert.ToInt32(row[5].ToString())-1;
                            }

                        }
                        if (Convert.ToInt32(txtIdCar.Text) > data.Rows.Count)
                        {
                            MessageBox.Show("La ID Articulo " + txtIdCar.Text + " No Existe");
                            Limpirar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCar.Enabled = false;
        }

        private void txtIdCar_TextChanged(object sender, EventArgs e)
        {           
            rellenar();
        }
        private void txtIdCar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == ('.')))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtAñoCar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == ('.')))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
               
    }
}
