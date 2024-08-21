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
            switch(cmbForma.Text)
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
            ExibirAltura(false);
            ExibirRaio(false);
            cmbTriangulo.Visible = false;
        }
        private void Selecionar_Triangulo()
        {
            if (cmbTriangulo.Visible = cmbForma.Text.Equals("Triangulo"))
            {
                switch (cmbTriangulo.Text)
                {
                    case "Reto":
                        ExibirBase(true);
                        ExibirAltura(true);
                        break;
                    case "Isoceles":
                        ExibirBase(true);
                        ExibirAltura(true);
                        break;
                    case "Equilatero":
                        ExibirBase(true);
                        ExibirAltura(true);
                        break;
                    default:
                        break;

                }
            }
            else
            {
                ExibirBase(false);
                ExibirAltura(false);
                ExibirRaio(false);
            }
        }
        private void Selecionar_Retangulo()
        {
            ExibirAltura(true);
            ExibirBase(true);           
            ExibirRaio(false);
            cmbTriangulo.Visible = false;


        }
        private void Selecionar_Circunferencia()
        {
            ExibirBase(false);
            ExibirAltura(false);
            ExibirRaio(true);
            cmbTriangulo.Visible = false;


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
                FormaGeometrica quadrado = new Quadrado()
                {
                    Base = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(quadrado);
            }
           
        }
        
        private void cmbObjetos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FormaGeometrica obj =cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();           
        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
