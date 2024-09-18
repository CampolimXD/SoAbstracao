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
        //variaveis globais 

        FormaGeometrica forma = null;

        public Form1()
        {
            InitializeComponent();
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
           switch (cmbForma.Text)
           {
               case "Quadrado":
                    CaseQuadrado();
               break;

               case "Retangulo":
                    CaseRetangulo();    
               break;

               case "Circunferencia":
                    CaseCircunferencia();
               break;

               case "Triangulo":                                       
                    CaseTriangulo();                                                 
               break;
                }
            
            if (forma != null)
            {
                cmbObjetos.Items.Add(forma);
            }

            LimpaNum();
        }
        
        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {

            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            if (obj != null)
            {
                txtArea.Text = obj.CalcularArea().ToString("F2");
                txtPerimetro.Text = obj.CalcularPerimetro().ToString("F2");
            }

        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipos_triangulo();
        }


        /////////////
        // Funções //
        ///////////// 
               
        // função de limpeza
        private void LimpaNum() // limpa os campos .txt
        {
            txtAltura.Text = "";
            txtRaio.Text = "";
            txtBase.Text = "";
        }

        // funções de exibição raiz
        private void ExibirBase(bool visivel) // exibe a base no desing
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }
        private void ExibirAltura(bool visivel) // exibe a altura no desing
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }
        private void ExibirRaio(bool visivel) // exibe o raio no desing
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }
        
        // funções de exibição apos a seleção da forma geometrica
        private void Selecionar_Quadrado() // exibe para caso o quadrado seja selecionado
        {
            ExibirBase(true);
            ExibirRaio(false);
            ExibirAltura(false);
            MostraTriangulos(false);
        }
        private void Selecionar_Triangulo() // exibe para caso o triangulo seja selecionado
        {                                  // , antes de selecionar o tipo
            ExibirRaio(false);
            ExibirAltura(false);
            ExibirBase(false);
            MostraTriangulos(true);
        }
        private void Selecionar_Retangulo() // exibe para caso o retangulo seja selecionado
        {
            ExibirAltura(true);
            ExibirBase(true);
            ExibirRaio(false);
            MostraTriangulos(false);
        }
        private void Selecionar_Circunferencia() // exibe para caso a circunferencia seja selecionada
        {
            ExibirRaio(true);
            ExibirAltura(false);
            ExibirBase(false);
            MostraTriangulos(false);
        }

        // Triangulo e suas variações 
        private void MostraTriangulos(bool visivel) //exibe o cmbTriangulo para que o tipo 
        {                                          // de triangulo seja selecionado    
            cmbTriangulo.Visible = visivel;
        }

        private void Selecionar_Triangulo_isoceles() // exibe para o triangulo isoceles
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }
        private void Selecionar_Triangulo_equilatero() // exibe para o triangulo equilatero
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);
        }
        private void Selecionar_Triangulo_reto() // exibe para o triangulo reto
        {
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }

        // funções de caso Switch criar
        private void CaseQuadrado() // caso quadrado seja selecionado no cmbFormas
        {
            forma = new Quadrado
            {
                _Base = Convert.ToDouble(txtBase.Text)
            };
        }
        private void CaseRetangulo() // caso o retangulo seja selecionado no cmbFormas
        {
            forma = new Retangulo
            {
                _Base = Convert.ToDouble(txtBase.Text),
                Altura = Convert.ToDouble(txtAltura.Text)
            };
        }
        private void CaseCircunferencia() // caso a circunferencia seja selecionada no cmbFormas
        {
            forma = new Circunferencia
            {
                Raio = Convert.ToDouble(txtRaio.Text)
            };
        }
        private void CaseTriangulo() // caso triangulo seja selecionado no cmbFormas
        {
            switch (cmbTriangulo.Text)
            {
                case "Isoceles":
                    CaseIsoceles();
                    break;

                case "Reto":
                    CaseReto();
                    break;

                case "Equilatero":
                    CaseEquilatero();
                    break;
            }
        }
        private void CaseIsoceles() // caso o triangulo isoceles seja selecionado no cmbTriangulo
        {
            forma = new TrianguloIsosceles()
            {
                _Base = Convert.ToDouble(txtBase.Text),
                Altura = Convert.ToDouble(txtAltura.Text)
            };
        }
        private void CaseReto()// caso o triangulo reto seja selecionado no cmbTriangulo
        {
            forma = new TrianguloReto()
            {
                _Base = Convert.ToDouble(txtBase.Text),
                Altura = Convert.ToDouble(txtAltura.Text)
            };
        }
        private void CaseEquilatero()   // caso o triangulo equilatero seja selecionado no cmbTriangulo
        {
            forma = new TrianguloEquilatero()
            {
                _Base = Convert.ToDouble(txtBase.Text),
            };
        }
    }
}
