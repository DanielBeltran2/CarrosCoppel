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
    public partial class Tipo : Form
    {
        public Tipo()
        {
            InitializeComponent();
        }

        private void Tipo_Load(object sender, EventArgs e)
        {
            DataTable data = ManejaTipo.obtenTipo();
            this.dataGridView1.DataSource = data;
            this.dataGridView1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.AutoResizeRows();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
