using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstracao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Selecionar_Quadrado();
            Selecionar_Triangulo();
            Selecionar_Retangulo();
            Selecionar_Circunferencia();

        }


        private void Selecionar_Quadrado()
        {

            lblBase.Visible = cmbForma.Text.Equals("Quadrado");
            txtBase.Visible = cmbForma.Text.Equals("Quadrado");
        }
        private void Selecionar_Triangulo()
        { 
            lblBase.Visible = cmbForma.Text.Equals("Triangulo");
            txtBase.Visible = cmbForma.Text.Equals("Triangulo");
            lblAltura.Visible = cmbForma.Text.Equals("Triangulo");
            txtAltura.Visible = cmbForma.Text.Equals("Triangulo");
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triangulo");
        }
        private void Selecionar_Retangulo()
        {

            lblAltura.Visible = cmbForma.Text.Equals("Retangulo");
            txtAltura.Visible = cmbForma.Text.Equals("Retangulo");
        
            lblBase.Visible = cmbForma.Text.Equals("Retangulo");
            txtBase.Visible = cmbForma.Text.Equals("Retangulo");
        }
        private void Selecionar_Circunferencia()
        {
     

            lblRaio.Visible = cmbForma.Text.Equals("Circunferencia");
            txtRaio.Visible = cmbForma.Text.Equals("Circunferencia");
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }
    }
}
