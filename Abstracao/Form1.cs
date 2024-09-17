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
            switch (cmbForma.Text)
            {
                case "Quadrado":

                    Selecionar_Quadrado();
                    break;

                case "Triangulo":

                    Selecionar_Triangulo();
                    break;
                case "Retangulo":

                    Selecionar_Retangulo();
                    break;
                case "Circunferencia":

                    Selecionar_Circunferencia();
                    break;
                default:
                    break;
            }


        }


        private void Selecionar_Quadrado()
        {
            ExibirBase(true);
            lblBase.Visible = cmbForma.Text.Equals("Quadrado");
            txtBase.Visible = cmbForma.Text.Equals("Quadrado");
        }
        private void Selecionar_Triangulo()
        {
            Tipos_triangulo();
            
            lblBase.Visible = cmbForma.Text.Equals("Triangulo");
            txtBase.Visible = cmbForma.Text.Equals("Triangulo");
            lblAltura.Visible = cmbForma.Text.Equals("Triangulo");
            txtAltura.Visible = cmbForma.Text.Equals("Triangulo");
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triangulo");
        }
        private void Selecionar_Triangulo_reto()
        {
            ExibirBase(true);
            //area = (baseTriangulo * alturaTriangulo) / 2;

        }
        private void Selecionar_Triangulo_equilatero()
        {
            
            ExibirBase(true);
        }
        private void Selecionar_Triangulo_isoceles()
        {
            ExibirBase(true);
            ExibirAltura(true);  
                
        }
        private void Tipos_triangulo()
        {
            switch (cmbTriangulo.Text)
            {
                case "Isoceles":

                    Selecionar_Triangulo_isoceles();
                    break;

                case "Reto":

                    Selecionar_Triangulo_reto();
                    break;
                case "Equilatero":

                    Selecionar_Triangulo_equilatero();
                    break;
               
                default:
                    break;
            }
        }
        private void Selecionar_Retangulo()
        {
            ExibirAltura(true);
            ExibirBase(true);
        
        }
        private void Selecionar_Circunferencia()
        {
            
            ExibirRaio(true);

        }

       private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }
        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }
        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(cmbForma.Text.Equals("Quadrado"))
            {

            }
        }
    }
}
