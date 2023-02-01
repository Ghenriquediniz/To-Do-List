namespace List
{
    partial class Taks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taks));
            this.lbl_tabela = new System.Windows.Forms.ListBox();
            this.tbl_tarefa = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_subir = new System.Windows.Forms.Button();
            this.btn_baixo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tabela
            // 
            this.lbl_tabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabela.FormattingEnabled = true;
            this.lbl_tabela.ItemHeight = 31;
            this.lbl_tabela.Location = new System.Drawing.Point(12, 84);
            this.lbl_tabela.Name = "lbl_tabela";
            this.lbl_tabela.Size = new System.Drawing.Size(373, 469);
            this.lbl_tabela.TabIndex = 0;
            this.lbl_tabela.SelectedIndexChanged += new System.EventHandler(this.lbl_tabela_SelectedIndexChanged);
            // 
            // tbl_tarefa
            // 
            this.tbl_tarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl_tarefa.Location = new System.Drawing.Point(12, 36);
            this.tbl_tarefa.Name = "tbl_tarefa";
            this.tbl_tarefa.Size = new System.Drawing.Size(373, 38);
            this.tbl_tarefa.TabIndex = 1;
            this.tbl_tarefa.TextChanged += new System.EventHandler(this.tbl_tarefa_TextChanged);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(391, 36);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(76, 41);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(391, 87);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(76, 40);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_subir
            // 
            this.btn_subir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_subir.BackgroundImage")));
            this.btn_subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_subir.Location = new System.Drawing.Point(392, 211);
            this.btn_subir.Name = "btn_subir";
            this.btn_subir.Size = new System.Drawing.Size(75, 58);
            this.btn_subir.TabIndex = 4;
            this.btn_subir.UseVisualStyleBackColor = true;
            this.btn_subir.Click += new System.EventHandler(this.btn_subir_Click);
            // 
            // btn_baixo
            // 
            this.btn_baixo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_baixo.BackgroundImage")));
            this.btn_baixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_baixo.Location = new System.Drawing.Point(392, 273);
            this.btn_baixo.Name = "btn_baixo";
            this.btn_baixo.Size = new System.Drawing.Size(75, 58);
            this.btn_baixo.TabIndex = 5;
            this.btn_baixo.UseVisualStyleBackColor = true;
            this.btn_baixo.Click += new System.EventHandler(this.btn_baixo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Taks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(472, 564);
            this.Controls.Add(this.btn_baixo);
            this.Controls.Add(this.btn_subir);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.tbl_tarefa);
            this.Controls.Add(this.lbl_tabela);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Taks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taks";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbl_tabela;
        private System.Windows.Forms.TextBox tbl_tarefa;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_subir;
        private System.Windows.Forms.Button btn_baixo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

