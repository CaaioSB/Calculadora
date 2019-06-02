namespace Calculadora
{
    partial class frmCalculadora
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
            this.btnZero = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.valorAcumulado = new System.Windows.Forms.TextBox();
            this.csButton5 = new Calculadora.CSButton();
            this.csButton4 = new Calculadora.CSButton();
            this.csButton3 = new Calculadora.CSButton();
            this.csButton2 = new Calculadora.CSButton();
            this.csBtnDivisao = new Calculadora.CSButton();
            this.csBtnClose = new Calculadora.CSButton();
            this.csBtnMaximize = new Calculadora.CSButton();
            this.csBtnMinimize = new Calculadora.CSButton();
            this.csBtnAbout = new Calculadora.CSButton();
            this.SuspendLayout();
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(-1, 398);
            this.btnZero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(140, 70);
            this.btnZero.TabIndex = 1;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(136, 398);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(70, 70);
            this.btnVirgula.TabIndex = 2;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.BtnVirgula_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(136, 329);
            this.btnTres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(70, 70);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(67, 329);
            this.btnDois.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(70, 70);
            this.btnDois.TabIndex = 5;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.BtnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.Location = new System.Drawing.Point(-1, 329);
            this.btnUm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(70, 70);
            this.btnUm.TabIndex = 4;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.BtnUm_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(136, 260);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(70, 70);
            this.btnSeis.TabIndex = 10;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(67, 260);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(70, 70);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.Location = new System.Drawing.Point(-1, 260);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(70, 70);
            this.btnQuatro.TabIndex = 8;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.BtnQuatro_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.Location = new System.Drawing.Point(136, 191);
            this.btnNove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(70, 70);
            this.btnNove.TabIndex = 14;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.BtnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.Location = new System.Drawing.Point(67, 191);
            this.btnOito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(70, 70);
            this.btnOito.TabIndex = 13;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.BtnOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.Location = new System.Drawing.Point(-1, 191);
            this.btnSete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(70, 70);
            this.btnSete.TabIndex = 12;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.BtnSete_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(136, 122);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(70, 70);
            this.btnBackspace.TabIndex = 18;
            this.btnBackspace.Text = "<";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(67, 122);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(198)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(-1, 122);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 70);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CE";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(2, 58);
            this.display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(273, 57);
            this.display.TabIndex = 20;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorAcumulado
            // 
            this.valorAcumulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.valorAcumulado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorAcumulado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorAcumulado.ForeColor = System.Drawing.Color.White;
            this.valorAcumulado.Location = new System.Drawing.Point(2, 24);
            this.valorAcumulado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valorAcumulado.Name = "valorAcumulado";
            this.valorAcumulado.ReadOnly = true;
            this.valorAcumulado.Size = new System.Drawing.Size(273, 30);
            this.valorAcumulado.TabIndex = 21;
            this.valorAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // csButton5
            // 
            this.csButton5.CSBackColorChange = "Laranja";
            this.csButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csButton5.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csButton5.Location = new System.Drawing.Point(205, 398);
            this.csButton5.Name = "csButton5";
            this.csButton5.Size = new System.Drawing.Size(70, 70);
            this.csButton5.TabIndex = 26;
            this.csButton5.Text = "=";
            this.csButton5.UseVisualStyleBackColor = true;
            this.csButton5.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // csButton4
            // 
            this.csButton4.CSBackColorChange = "Laranja";
            this.csButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csButton4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csButton4.Location = new System.Drawing.Point(205, 329);
            this.csButton4.Name = "csButton4";
            this.csButton4.Size = new System.Drawing.Size(70, 70);
            this.csButton4.TabIndex = 25;
            this.csButton4.Text = "+";
            this.csButton4.UseVisualStyleBackColor = true;
            this.csButton4.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // csButton3
            // 
            this.csButton3.CSBackColorChange = "Laranja";
            this.csButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csButton3.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csButton3.Location = new System.Drawing.Point(205, 260);
            this.csButton3.Name = "csButton3";
            this.csButton3.Size = new System.Drawing.Size(70, 70);
            this.csButton3.TabIndex = 24;
            this.csButton3.Text = "-";
            this.csButton3.UseVisualStyleBackColor = true;
            this.csButton3.Click += new System.EventHandler(this.BtnSubtracao_Click);
            // 
            // csButton2
            // 
            this.csButton2.CSBackColorChange = "Laranja";
            this.csButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csButton2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csButton2.Location = new System.Drawing.Point(205, 191);
            this.csButton2.Name = "csButton2";
            this.csButton2.Size = new System.Drawing.Size(70, 70);
            this.csButton2.TabIndex = 23;
            this.csButton2.Text = "*";
            this.csButton2.UseVisualStyleBackColor = true;
            this.csButton2.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // csBtnDivisao
            // 
            this.csBtnDivisao.CSBackColorChange = "Laranja";
            this.csBtnDivisao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csBtnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csBtnDivisao.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csBtnDivisao.Location = new System.Drawing.Point(205, 122);
            this.csBtnDivisao.Name = "csBtnDivisao";
            this.csBtnDivisao.Size = new System.Drawing.Size(70, 70);
            this.csBtnDivisao.TabIndex = 22;
            this.csBtnDivisao.Text = "/";
            this.csBtnDivisao.UseVisualStyleBackColor = true;
            this.csBtnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // csBtnClose
            // 
            this.csBtnClose.BackgroundImage = global::Calculadora.Properties.Resources.close_button;
            this.csBtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.csBtnClose.CSBackColorChange = "Laranja";
            this.csBtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csBtnClose.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csBtnClose.Location = new System.Drawing.Point(1, 2);
            this.csBtnClose.Name = "csBtnClose";
            this.csBtnClose.Size = new System.Drawing.Size(25, 25);
            this.csBtnClose.TabIndex = 36;
            this.csBtnClose.UseVisualStyleBackColor = true;
            this.csBtnClose.Click += new System.EventHandler(this.CsBtnClose_Click);
            // 
            // csBtnMaximize
            // 
            this.csBtnMaximize.BackgroundImage = global::Calculadora.Properties.Resources.maximize_button;
            this.csBtnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.csBtnMaximize.CSBackColorChange = "Laranja";
            this.csBtnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csBtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csBtnMaximize.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csBtnMaximize.Location = new System.Drawing.Point(27, 2);
            this.csBtnMaximize.Name = "csBtnMaximize";
            this.csBtnMaximize.Size = new System.Drawing.Size(25, 25);
            this.csBtnMaximize.TabIndex = 35;
            this.csBtnMaximize.UseVisualStyleBackColor = true;
            this.csBtnMaximize.Click += new System.EventHandler(this.CsBtnMaximize_Click);
            // 
            // csBtnMinimize
            // 
            this.csBtnMinimize.BackgroundImage = global::Calculadora.Properties.Resources.minimize_button;
            this.csBtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.csBtnMinimize.CSBackColorChange = "Laranja";
            this.csBtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csBtnMinimize.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csBtnMinimize.Location = new System.Drawing.Point(53, 2);
            this.csBtnMinimize.Name = "csBtnMinimize";
            this.csBtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.csBtnMinimize.TabIndex = 34;
            this.csBtnMinimize.UseVisualStyleBackColor = true;
            this.csBtnMinimize.Click += new System.EventHandler(this.CsBtnMinimize_Click);
            // 
            // csBtnAbout
            // 
            this.csBtnAbout.BackgroundImage = global::Calculadora.Properties.Resources.about_button;
            this.csBtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.csBtnAbout.CSBackColorChange = "Laranja";
            this.csBtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.csBtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csBtnAbout.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.csBtnAbout.Location = new System.Drawing.Point(79, 2);
            this.csBtnAbout.Name = "csBtnAbout";
            this.csBtnAbout.Size = new System.Drawing.Size(25, 25);
            this.csBtnAbout.TabIndex = 33;
            this.csBtnAbout.UseVisualStyleBackColor = true;
            this.csBtnAbout.Click += new System.EventHandler(this.CsBtnAbout_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(275, 468);
            this.Controls.Add(this.csBtnClose);
            this.Controls.Add(this.csBtnMaximize);
            this.Controls.Add(this.csBtnMinimize);
            this.Controls.Add(this.csBtnAbout);
            this.Controls.Add(this.csButton5);
            this.Controls.Add(this.csButton4);
            this.Controls.Add(this.csButton3);
            this.Controls.Add(this.csButton2);
            this.Controls.Add(this.csBtnDivisao);
            this.Controls.Add(this.valorAcumulado);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnZero);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.TextBox valorAcumulado;
        private CSButton csBtnDivisao;
        private CSButton csButton2;
        private CSButton csButton3;
        private CSButton csButton4;
        private CSButton csButton5;
        private CSButton csBtnAbout;
        private CSButton csBtnMinimize;
        private CSButton csBtnMaximize;
        private CSButton csBtnClose;
    }
}

