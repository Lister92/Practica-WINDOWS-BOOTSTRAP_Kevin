using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormBootstrap : Form
    {
        public FormBootstrap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBootstrap_Load(object sender, EventArgs e)
        {

        }

        private void butMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("el mensaje es: " + txtMensaje.Text);
            if (chkAceptar.Checked == true)
            {
                MessageBox.Show("Acpetas las condicions");
            }
            else
                MessageBox.Show("No aceptas condiciones");
            if (radioHombre.Checked)
            {
                MessageBox.Show("tienes pito");
            }
            else if (radioMujer.Checked)
            {
                MessageBox.Show("tienes vagaga");
            }
            else MessageBox.Show("no se que tienes");
            MessageBox.Show(listBox1.Text);
            MessageBox.Show(comboBox1.Text);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void radioHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHombre.Checked)
            MessageBox.Show(radioHombre.Text +", tienes pito");
        }

        private void radioMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMujer.Checked)
            MessageBox.Show(radioMujer.Text + ", tienes pussy");
        }

        private void chkAceptar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAceptar.Checked) MessageBox.Show("aceptas");
            else MessageBox.Show("no aceptas");
        }
    }
}
