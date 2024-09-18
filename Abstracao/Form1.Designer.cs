namespace Abstracao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Quadrado",
            "Triangulo",
            "Retangulo",
            "Circunferencia"});
            this.cmbForma.Location = new System.Drawing.Point(28, 33);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(121, 21);
            this.cmbForma.TabIndex = 0;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Reto",
            "Equilatero",
            "Isoceles"});
            this.cmbTriangulo.Location = new System.Drawing.Point(180, 35);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbTriangulo.TabIndex = 1;
            this.cmbTriangulo.Visible = false;
            this.cmbTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTriangulo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.cmbObjetos);
            this.groupBox1.Controls.Add(this.txtPerimetro);
            this.groupBox1.Controls.Add(this.lblPerimetro);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.txtRaio);
            this.groupBox1.Controls.Add(this.cmbForma);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.cmbTriangulo);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.lblBase);
            this.groupBox1.Controls.Add(this.lblRaio);
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Location = new System.Drawing.Point(33, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma geometrica";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(352, 33);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 14;
            this.btnCriar.Text = "&Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(462, 35);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(121, 21);
            this.cmbObjetos.TabIndex = 13;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(474, 123);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 12;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(414, 126);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 11;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(474, 92);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 10;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(427, 99);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Area:";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(66, 136);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 8;
            this.txtRaio.Visible = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(66, 109);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(66, 83);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 6;
            this.txtBase.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(25, 83);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "&Base:";
            this.lblBase.Visible = false;
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(25, 139);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(32, 13);
            this.lblRaio.TabIndex = 5;
            this.lblRaio.Text = "&Raio:";
            this.lblRaio.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(25, 111);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "&Altura:";
            this.lblAltura.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ComboBox cmbObjetos;
    }
}

