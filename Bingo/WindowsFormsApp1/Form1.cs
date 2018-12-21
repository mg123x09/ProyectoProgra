using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        logic logica = new logic();
       

        

        private void cmbModalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dgvCarton.DataSource = null;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "B";
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "I";
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "N";
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "G";
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "O";
            dgvCarton.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5 });
            logica.creacion(Convert.ToInt32(cmbJugadores.Text), Convert.ToInt32(cbCartxJu.Text), Convert.ToInt32(cbNumxCart.Text));
            
        }
        

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logica.mostrarHis());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try {
                dgvCarton.Rows.Clear();
                
                dgvCarton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int jugador = Convert.ToInt32(cbPlayer.Text);
            int carton = Convert.ToInt32(cbCarton.Text);
            
            foreach (Cartones cart in logica.plantilla)
            {
                if (cart.ids == carton && cart.player == jugador)
                {
                    for(int i = 0; i < cart.carts.GetLength(1); i++)
                    {
                        dgvCarton.Rows.Add(logica.mostrar_cart(jugador,carton,i));
                    }
                }
            }
            }
            catch (Exception)
            {

            }


        }
       

        private void btntirar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(logica.jugar(cmbModalidad.Text));
        }
    }
}
    