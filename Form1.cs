using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcularRiqueza_Click(object sender, EventArgs e)
        {
            Persona usuario1 = new Persona(txt_nombres.Text, txt_apellidos.Text) ;
            usuario1.setDineroAhorrado(Convert.ToInt32(txt_dineroAho.Text));
            usuario1.setFondoPension(Convert.ToInt32(txt_fondoPen.Text));
            lbl_nombres.Text = usuario1.getNombreCompleto();
            lbl_riqueza.Text = usuario1.CalcularRiqueza().ToString();
            txt_apellidos.Text = "";
            txt_dineroAho.Text = "";
            txt_fondoPen.Text = "";
            txt_nombres.Text = "";
        }

        private void txt_dineroAho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_fondoPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_medirInteligencia_Click(object sender, EventArgs e)
        {
            Persona usuario1 = new Persona(null, null);
            lbl_nivelIn.Text = "- " + usuario1.MedirInteligencia(Convert.ToInt32(txt_escala.Text));
            txt_escala.Text = "";
        }

        private void txt_escala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
