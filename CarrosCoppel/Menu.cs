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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AgregarCarros AggCar = new AgregarCarros();
            AggCar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color VerCol = new Color();
            VerCol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tipo VerTip = new Tipo();
            VerTip.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marca VerMar = new Marca();
            VerMar.Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Carros VerCar = new Carros();
            VerCar.Show();
        }
    }
}