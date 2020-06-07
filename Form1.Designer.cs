namespace projeto_comissao
{
    partial class frm_Comissao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Comissao));
            this.rdb_A = new System.Windows.Forms.RadioButton();
            this.rdb_B = new System.Windows.Forms.RadioButton();
            this.rdb_C = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_ValorVenda = new System.Windows.Forms.TextBox();
            this.txt_ValorCom = new System.Windows.Forms.TextBox();
            this.lbl_ValorVenda = new System.Windows.Forms.Label();
            this.lbl_ValorCom = new System.Windows.Forms.Label();
            this.gpb_Categoria = new System.Windows.Forms.GroupBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.gpb_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_A
            // 
            this.rdb_A.AutoSize = true;
            this.rdb_A.Location = new System.Drawing.Point(20, 41);
            this.rdb_A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_A.Name = "rdb_A";
            this.rdb_A.Size = new System.Drawing.Size(96, 20);
            this.rdb_A.TabIndex = 2;
            this.rdb_A.TabStop = true;
            this.rdb_A.Text = "Categoria A";
            this.rdb_A.UseVisualStyleBackColor = true;
            // 
            // rdb_B
            // 
            this.rdb_B.AutoSize = true;
            this.rdb_B.Location = new System.Drawing.Point(20, 84);
            this.rdb_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_B.Name = "rdb_B";
            this.rdb_B.Size = new System.Drawing.Size(95, 20);
            this.rdb_B.TabIndex = 3;
            this.rdb_B.TabStop = true;
            this.rdb_B.Text = "Categoria B";
            this.rdb_B.UseVisualStyleBackColor = true;
            // 
            // rdb_C
            // 
            this.rdb_C.AutoSize = true;
            this.rdb_C.Location = new System.Drawing.Point(20, 129);
            this.rdb_C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_C.Name = "rdb_C";
            this.rdb_C.Size = new System.Drawing.Size(97, 20);
            this.rdb_C.TabIndex = 4;
            this.rdb_C.TabStop = true;
            this.rdb_C.Text = "Categoria C";
            this.rdb_C.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.White;
            this.btn_Calcular.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Calcular.Location = new System.Drawing.Point(195, 126);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(141, 53);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular Comissão";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_ValorVenda
            // 
            this.txt_ValorVenda.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorVenda.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_ValorVenda.Location = new System.Drawing.Point(195, 76);
            this.txt_ValorVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ValorVenda.Name = "txt_ValorVenda";
            this.txt_ValorVenda.Size = new System.Drawing.Size(141, 25);
            this.txt_ValorVenda.TabIndex = 0;
            this.txt_ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorVenda_KeyPress);
            // 
            // txt_ValorCom
            // 
            this.txt_ValorCom.Enabled = false;
            this.txt_ValorCom.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorCom.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_ValorCom.Location = new System.Drawing.Point(195, 216);
            this.txt_ValorCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ValorCom.Name = "txt_ValorCom";
            this.txt_ValorCom.Size = new System.Drawing.Size(141, 25);
            this.txt_ValorCom.TabIndex = 6;
            this.txt_ValorCom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ValorVenda
            // 
            this.lbl_ValorVenda.AutoSize = true;
            this.lbl_ValorVenda.ForeColor = System.Drawing.Color.White;
            this.lbl_ValorVenda.Location = new System.Drawing.Point(192, 59);
            this.lbl_ValorVenda.Name = "lbl_ValorVenda";
            this.lbl_ValorVenda.Size = new System.Drawing.Size(149, 16);
            this.lbl_ValorVenda.TabIndex = 6;
            this.lbl_ValorVenda.Text = "Digite o Valor da Venda:";
            // 
            // lbl_ValorCom
            // 
            this.lbl_ValorCom.AutoSize = true;
            this.lbl_ValorCom.ForeColor = System.Drawing.Color.White;
            this.lbl_ValorCom.Location = new System.Drawing.Point(192, 193);
            this.lbl_ValorCom.Name = "lbl_ValorCom";
            this.lbl_ValorCom.Size = new System.Drawing.Size(149, 16);
            this.lbl_ValorCom.TabIndex = 7;
            this.lbl_ValorCom.Text = "Valor da Comissão: (R$)";
            // 
            // gpb_Categoria
            // 
            this.gpb_Categoria.Controls.Add(this.rdb_C);
            this.gpb_Categoria.Controls.Add(this.rdb_A);
            this.gpb_Categoria.Controls.Add(this.rdb_B);
            this.gpb_Categoria.ForeColor = System.Drawing.Color.White;
            this.gpb_Categoria.Location = new System.Drawing.Point(12, 59);
            this.gpb_Categoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_Categoria.Name = "gpb_Categoria";
            this.gpb_Categoria.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpb_Categoria.Size = new System.Drawing.Size(173, 182);
            this.gpb_Categoria.TabIndex = 1;
            this.gpb_Categoria.TabStop = false;
            this.gpb_Categoria.Text = "Categoria do Vendedor";
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Sair.Location = new System.Drawing.Point(195, 246);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(116, 35);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.White;
            this.btn_Limpar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Limpar.Location = new System.Drawing.Point(32, 246);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(116, 35);
            this.btn_Limpar.TabIndex = 8;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.ForeColor = System.Drawing.Color.White;
            this.lbl_Texto.Location = new System.Drawing.Point(2, 9);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(344, 21);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Calcule aqui o valor de sua comissão!";
            // 
            // frm_Comissao
            // 
            this.AcceptButton = this.btn_Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(347, 297);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.gpb_Categoria);
            this.Controls.Add(this.lbl_ValorCom);
            this.Controls.Add(this.lbl_ValorVenda);
            this.Controls.Add(this.txt_ValorCom);
            this.Controls.Add(this.txt_ValorVenda);
            this.Controls.Add(this.btn_Calcular);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Comissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comissão";
            this.gpb_Categoria.ResumeLayout(false);
            this.gpb_Categoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_A;
        private System.Windows.Forms.RadioButton rdb_B;
        private System.Windows.Forms.RadioButton rdb_C;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_ValorVenda;
        private System.Windows.Forms.TextBox txt_ValorCom;
        private System.Windows.Forms.Label lbl_ValorVenda;
        private System.Windows.Forms.Label lbl_ValorCom;
        private System.Windows.Forms.GroupBox gpb_Categoria;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label lbl_Texto;
    }
}

