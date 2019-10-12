using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            consulta();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (ServiceReference1.GuardarClient cliente = new ServiceReference1.GuardarClient())
            {
                
                cliente.guardar(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Int32.Parse( textBox5.Text), textBox6.Text);
            }
            listBox1.Items.Add(textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text + ' ' + textBox4.Text + ' ' + Int32.Parse(textBox5.Text) + ' ' + textBox6.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vector = new string[5];
            using (ServiceReference1.GuardarClient cliente = new ServiceReference1.GuardarClient())
            {
                try
                {
                    vector = cliente.buscar(Convert.ToInt32(textBox1.Text));
                    textBox2.Text = vector[1];
                    textBox3.Text = vector[2];
                    textBox4.Text = vector[3];
                    textBox5.Text = vector[4];
                    textBox6.Text = vector[5];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No hay datos!");
                }
            }
        }
        public void consulta()
        {
            string[] lista;
            using (ServiceReference1.GuardarClient cliente = new ServiceReference1.GuardarClient())
            {
                lista = cliente.mostrar();
                for (int i = 0; i < lista.Count<string>(); i = i + 6)
                {
                    listBox1.Items.Add(lista[i].ToString() + " " + lista[i + 1].ToString() + " " + lista[i + 2].ToString() + " " + lista[i + 3].ToString() + " " + lista[i + 4].ToString() + " " + lista[i + 5].ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int con = 5;
            using (ServiceReference1.GuardarClient cliente = new ServiceReference1.GuardarClient())
            {
                textBox1.Text = cliente.obtener(con).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.GuardarClient cliente = new ServiceReference1.GuardarClient())
            {
                textBox6.Text = cliente.toText(Convert.ToDouble(textBox5.Text));
            }
        }
    }
}
