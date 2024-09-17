using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            ExibirRaio(false);
            ExibirAltura(false);
            MostraTriangulos(false);

        }
        private void Selecionar_Triangulo()
        {
            ExibirRaio(false);
            ExibirAltura(false);
            ExibirBase(false);
            MostraTriangulos(true);
        }
        private void MostraTriangulos(bool visivel)
        {
            cmbTriangulo.Visible = visivel;
        }
        private void Selecionar_Triangulo_reto()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            ///area = (baseTriangulo * alturaTriangulo) / 2;

        }
        private void Selecionar_Triangulo_equilatero()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
            // area = (Math.Sqrt(3) / 4) * Math.Pow(baseTriangulo, 2);
        }
        private void Selecionar_Triangulo_isoceles()
        {
            ExibirBase(true);
            ExibirAltura(true); 
            ExibirRaio(false);
            //area = (baseTriangulo * alturaTriangulo) / 2;

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
            ExibirRaio(false);
            MostraTriangulos(false);

        }
        private void Selecionar_Circunferencia()
        {
            
            ExibirRaio(true);
            ExibirAltura(false);
            ExibirBase(false);
            MostraTriangulos(false);

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
            if (cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado()
                {
                    // Base = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(quadrado);
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipos_triangulo();
        }
    }
}
