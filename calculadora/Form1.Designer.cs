
namespace calculadora
{
    partial class frmcalculadora
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
            this.nblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.grpoperacao = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntdivisao = new System.Windows.Forms.Button();
            this.bntmulti = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.grpoperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // nblnum1
            // 
            this.nblnum1.AutoSize = true;
            this.nblnum1.BackColor = System.Drawing.Color.Transparent;
            this.nblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nblnum1.Location = new System.Drawing.Point(17, 21);
            this.nblnum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nblnum1.Name = "nblnum1";
            this.nblnum1.Size = new System.Drawing.Size(105, 25);
            this.nblnum1.TabIndex = 0;
            this.nblnum1.Text = "Numero 1";
            this.nblnum1.Click += new System.EventHandler(this.nblnum1_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.BackColor = System.Drawing.Color.Transparent;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(17, 145);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(105, 25);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Numero 2";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Transparent;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(238, 84);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(108, 25);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "Resultado";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(17, 52);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(107, 22);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(17, 176);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(107, 22);
            this.txtnum2.TabIndex = 4;
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtresult.Location = new System.Drawing.Point(243, 113);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(102, 22);
            this.txtresult.TabIndex = 5;
            // 
            // grpoperacao
            // 
            this.grpoperacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpoperacao.Controls.Add(this.btnLimpar);
            this.grpoperacao.Controls.Add(this.bntdivisao);
            this.grpoperacao.Controls.Add(this.bntmulti);
            this.grpoperacao.Controls.Add(this.btnsub);
            this.grpoperacao.Controls.Add(this.btnsoma);
            this.grpoperacao.Location = new System.Drawing.Point(163, 283);
            this.grpoperacao.Margin = new System.Windows.Forms.Padding(4);
            this.grpoperacao.Name = "grpoperacao";
            this.grpoperacao.Padding = new System.Windows.Forms.Padding(4);
            this.grpoperacao.Size = new System.Drawing.Size(328, 182);
            this.grpoperacao.TabIndex = 6;
            this.grpoperacao.TabStop = false;
            this.grpoperacao.Text = "Operações";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpar.Location = new System.Drawing.Point(8, 59);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 43);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntdivisao
            // 
            this.bntdivisao.BackColor = System.Drawing.SystemColors.Info;
            this.bntdivisao.Location = new System.Drawing.Point(175, 59);
            this.bntdivisao.Margin = new System.Windows.Forms.Padding(4);
            this.bntdivisao.Name = "bntdivisao";
            this.bntdivisao.Size = new System.Drawing.Size(100, 43);
            this.bntdivisao.TabIndex = 3;
            this.bntdivisao.Text = "Divisão";
            this.bntdivisao.UseVisualStyleBackColor = false;
            this.bntdivisao.Click += new System.EventHandler(this.bntdivisao_Click);
            // 
            // bntmulti
            // 
            this.bntmulti.BackColor = System.Drawing.SystemColors.Info;
            this.bntmulti.Location = new System.Drawing.Point(175, 23);
            this.bntmulti.Margin = new System.Windows.Forms.Padding(4);
            this.bntmulti.Name = "bntmulti";
            this.bntmulti.Size = new System.Drawing.Size(105, 28);
            this.bntmulti.TabIndex = 2;
            this.bntmulti.Text = "Multiplicação";
            this.bntmulti.UseVisualStyleBackColor = false;
            this.bntmulti.Click += new System.EventHandler(this.bntmulti_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.SystemColors.Info;
            this.btnsub.Location = new System.Drawing.Point(80, 23);
            this.btnsub.Margin = new System.Windows.Forms.Padding(4);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(87, 28);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "Subtração";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.BackColor = System.Drawing.SystemColors.Info;
            this.btnsoma.Location = new System.Drawing.Point(8, 23);
            this.btnsoma.Margin = new System.Windows.Forms.Padding(4);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(64, 28);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "Soma";
            this.btnsoma.UseVisualStyleBackColor = false;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.BackColor = System.Drawing.Color.Transparent;
            this.lbloperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacao.Location = new System.Drawing.Point(50, 104);
            this.lbloperacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(30, 31);
            this.lbloperacao.TabIndex = 7;
            this.lbloperacao.Text = "+";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.BackColor = System.Drawing.Color.Transparent;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(158, 110);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(25, 25);
            this.lblEqual.TabIndex = 8;
            this.lblEqual.Text = "=";
            this.lblEqual.Click += new System.EventHandler(this.lblEqual_Click);
            // 
            // frmcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 492);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.grpoperacao);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.nblnum1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmcalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmcalculadora_Load);
            this.grpoperacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.GroupBox grpoperacao;
        private System.Windows.Forms.Button bntdivisao;
        private System.Windows.Forms.Button bntmulti;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblEqual;
    }
}

