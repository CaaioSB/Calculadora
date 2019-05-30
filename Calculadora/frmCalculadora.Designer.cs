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
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.valorAcumulado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.Location = new System.Drawing.Point(13, 331);
            this.btnMaisMenos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(82, 46);
            this.btnMaisMenos.TabIndex = 0;
            this.btnMaisMenos.Text = "+-";
            this.btnMaisMenos.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(101, 331);
            this.btnZero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(82, 46);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(190, 331);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(82, 46);
            this.btnVirgula.TabIndex = 2;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.BtnVirgula_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(279, 331);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(82, 46);
            this.btnIgual.TabIndex = 3;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(279, 278);
            this.btnSoma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(82, 46);
            this.btnSoma.TabIndex = 7;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(190, 278);
            this.btnTres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(82, 46);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(101, 278);
            this.btnDois.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(82, 46);
            this.btnDois.TabIndex = 5;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.BtnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(13, 278);
            this.btnUm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(82, 46);
            this.btnUm.TabIndex = 4;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.BtnUm_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(279, 225);
            this.btnSubtracao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(82, 46);
            this.btnSubtracao.TabIndex = 11;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.BtnSubtracao_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(190, 225);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(82, 46);
            this.btnSeis.TabIndex = 10;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(101, 225);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(82, 46);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(13, 225);
            this.btnQuatro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(82, 46);
            this.btnQuatro.TabIndex = 8;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.BtnQuatro_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(279, 172);
            this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(82, 46);
            this.btnMultiplicacao.TabIndex = 15;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.BtnMultiplicacao_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(190, 172);
            this.btnNove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(82, 46);
            this.btnNove.TabIndex = 14;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.BtnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(101, 172);
            this.btnOito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(82, 46);
            this.btnOito.TabIndex = 13;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.BtnOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(13, 172);
            this.btnSete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(82, 46);
            this.btnSete.TabIndex = 12;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.BtnSete_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(279, 119);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(82, 46);
            this.btnDivisao.TabIndex = 19;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.BtnDivisao_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(190, 119);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(82, 46);
            this.btnBackspace.TabIndex = 18;
            this.btnBackspace.Text = "<";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(101, 119);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 46);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(13, 119);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "CE";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(14, 42);
            this.display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(346, 69);
            this.display.TabIndex = 20;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valorAcumulado
            // 
            this.valorAcumulado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorAcumulado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorAcumulado.Location = new System.Drawing.Point(14, 21);
            this.valorAcumulado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valorAcumulado.Name = "valorAcumulado";
            this.valorAcumulado.ReadOnly = true;
            this.valorAcumulado.Size = new System.Drawing.Size(346, 22);
            this.valorAcumulado.TabIndex = 21;
            this.valorAcumulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 396);
            this.Controls.Add(this.valorAcumulado);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMaisMenos);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.TextBox valorAcumulado;
    }
}

