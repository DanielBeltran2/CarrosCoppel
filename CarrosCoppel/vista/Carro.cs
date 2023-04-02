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
    public partial class Carro : Form
    {
        DataTable data;
        public Carro()
        {
            InitializeComponent();
        }
        private void Carros_Load(object sender, EventArgs e)
        {
            CargarTabla();
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
        private void txtIdCar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void txtModCar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void CbMarCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void txtAñoCar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void CbColCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void CbTipCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void CargarTabla()
        {
            DataTable data = ManejaCarros.obtenCarro();
            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.AutoResizeRows();
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
        private void Buscar()
        {            
            String datos = "";                     
            if (!string.IsNullOrEmpty(txtIdCar.Text))
            {
                datos = datos + " c.CarID like '%" + txtIdCar.Text + "%'";
            }
            if (!string.IsNullOrEmpty(txtModCar.Text))
            {
                if (datos.Equals(""))
                {
                    datos = datos + " c.CarMod like '%" + txtModCar.Text + "%'";
                }
                else
                {
                    datos = datos + "and c.CarMod like '%" + txtModCar.Text + "%'";
                }               
            }          
            if (!string.IsNullOrEmpty(CbMarCar.Text))
            {
                if (datos.Equals(""))
                {
                    datos = datos + " m.CarMarca like '%" + CbMarCar.Text + "%'";
                }
                else
                {
                    datos = datos + "and m.CarMarca like '%" + CbMarCar.Text + "%'";
                }                        
            }
            if (!string.IsNullOrEmpty(txtAñoCar.Text))
            {
                if (datos.Equals(""))
                {
                    datos = datos + " c.CarAño like '%" + txtAñoCar.Text + "%'";
                }
                else
                {
                    datos = datos + "and c.CarAño like '%" + txtAñoCar.Text + "%'";
                }                           
            }
            if (!string.IsNullOrEmpty(CbTipCar.Text))
            {
                if (datos.Equals(""))
                {
                    datos = datos + " t.CarTip like '%" + CbTipCar.Text + "%'";
                }
                else
                {
                    datos = datos + "and t.CarTip like '%" + CbTipCar.Text + "%'";
                }               
            }
            if (!string.IsNullOrEmpty(CbColCar.Text))
            {
                if (datos.Equals(""))
                {
                    datos = datos + " co.CarColor like '%" + CbColCar.Text + "%'";
                }
                else
                {
                    datos = datos + "and co.CarColor like '%" + CbColCar.Text + "%'";
                }             
            }
            if (string.IsNullOrEmpty(txtIdCar.Text) && string.IsNullOrEmpty(txtModCar.Text) && string.IsNullOrEmpty(CbMarCar.Text)&& string.IsNullOrEmpty(txtAñoCar.Text) && string.IsNullOrEmpty(CbTipCar.Text) && string.IsNullOrEmpty(CbColCar.Text))
            {
                CargarTabla();
            }
            else
            {
                String consultaFinal = "SELECT c.CarID AS 'Carro ID', c.CarMod AS 'Modelo', c.CarAño AS 'Año', m.CarMarca AS 'Marca', t.CarTip AS 'Tipo', co.CarColor AS 'Color' FROM carros c JOIN color co ON c.CarColorID = co.CarColorID JOIN marca m ON c.CarMarcaID = m.CarMarcaID JOIN tipo t ON c.CarTipID = t.CarTipID where " + datos;
                Console.WriteLine(consultaFinal);
                DataTable data = ManejaCarros.Buscar(consultaFinal);
                this.dataGridView1.DataSource = data;
                this.dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.AutoResizeRows();
            }            
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            CargarTabla();
            Limpirar();
        }
    }
}
