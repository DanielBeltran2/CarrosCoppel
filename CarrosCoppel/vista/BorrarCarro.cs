using CarrosCoppel.controlador;
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
    public partial class BorrarCarro : Form
    {
        DataTable data;
        public BorrarCarro()
        {
            InitializeComponent();
        }

        private void BorrarCarro_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }


        private void rellenar()
        {
            if (!string.IsNullOrEmpty(txtIdCar.Text))
            {
                try
                {
                    data = ManejaCarros.obtenCarro();
                    if (data.Rows.Count > 0)
                    {
                        foreach (DataRow row in data.Rows)
                        {

                            string idTabla = row[0].ToString();
                            if (txtIdCar.Text.Equals(idTabla))
                            {
                                lblModelo.Text = row[1].ToString();
                                lblAño.Text = row[2].ToString();
                                lblMarca.Text = row[3].ToString();
                                lblTipo.Text = row[4].ToString();
                                lblColor.Text = row[5].ToString();
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

        private void Limpirar()
        {
            txtIdCar.Text = "";
            lblModelo.Text = "";
            lblAño.Text = "";
            lblMarca.Text = "";
            lblTipo.Text = "";
            lblColor.Text = "";
        }
        private void CargarTabla()
        {
            DataTable data = ManejaCarros.obtenCarro();
            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.AutoResizeRows();
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

        private void txtIdCar_TextChanged(object sender, EventArgs e)
        {
            rellenar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string id = txtIdCar.Text;
            ManejaCarros.EliminaCarro(id);
            MessageBox.Show("Carro Eliminado");

            Limpirar();
            CargarTabla();
        }
    }
}
