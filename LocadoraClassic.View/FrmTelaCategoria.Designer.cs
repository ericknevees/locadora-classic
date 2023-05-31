namespace LocadoraClassic.View
{
    partial class FrmTelaCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomecad = new System.Windows.Forms.TextBox();
            this.txtValorDia = new System.Windows.Forms.TextBox();
            this.dGVCat = new System.Windows.Forms.DataGridView();
            this.btnExcluirCat = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor da Diária";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomecad
            // 
            this.txtNomecad.Location = new System.Drawing.Point(87, 37);
            this.txtNomecad.Name = "txtNomecad";
            this.txtNomecad.Size = new System.Drawing.Size(338, 20);
            this.txtNomecad.TabIndex = 3;
            // 
            // txtValorDia
            // 
            this.txtValorDia.Location = new System.Drawing.Point(87, 93);
            this.txtValorDia.Name = "txtValorDia";
            this.txtValorDia.Size = new System.Drawing.Size(338, 20);
            this.txtValorDia.TabIndex = 4;
            this.txtValorDia.TextChanged += new System.EventHandler(this.txtValorDia_TextChanged);
            // 
            // dGVCat
            // 
            this.dGVCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCat.Location = new System.Drawing.Point(85, 171);
            this.dGVCat.Name = "dGVCat";
            this.dGVCat.Size = new System.Drawing.Size(375, 196);
            this.dGVCat.TabIndex = 5;
            this.dGVCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCat_CellDoubleClick);
            this.dGVCat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCat_CellDoubleClick);
            // 
            // btnExcluirCat
            // 
            this.btnExcluirCat.Location = new System.Drawing.Point(317, 133);
            this.btnExcluirCat.Name = "btnExcluirCat";
            this.btnExcluirCat.Size = new System.Drawing.Size(108, 23);
            this.btnExcluirCat.TabIndex = 6;
            this.btnExcluirCat.Text = "Excluir";
            this.btnExcluirCat.UseVisualStyleBackColor = true;
            this.btnExcluirCat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(202, 133);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmTelaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluirCat);
            this.Controls.Add(this.dGVCat);
            this.Controls.Add(this.txtValorDia);
            this.Controls.Add(this.txtNomecad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTelaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Categoria";
            this.Load += new System.EventHandler(this.FrmTelaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomecad;
        private System.Windows.Forms.TextBox txtValorDia;
        private System.Windows.Forms.DataGridView dGVCat;
        private System.Windows.Forms.Button btnExcluirCat;
        private System.Windows.Forms.Button btnAtualizar;
    }
}