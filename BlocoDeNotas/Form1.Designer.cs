namespace BlocoDeNotas
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtConteudo = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(642, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // arquivoMenuItem
            // 
            this.arquivoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarMenuItem,
            this.salvarComoMenuItem,
            this.abrirMenuItem});
            this.arquivoMenuItem.Name = "arquivoMenuItem";
            this.arquivoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.arquivoMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoMenuItem.Text = "Arquivo";
            // 
            // salvarMenuItem
            // 
            this.salvarMenuItem.Name = "salvarMenuItem";
            this.salvarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarMenuItem.Size = new System.Drawing.Size(220, 22);
            this.salvarMenuItem.Text = "Salvar";
            this.salvarMenuItem.Click += new System.EventHandler(this.SalvarMenuItem_Click);
            // 
            // salvarComoMenuItem
            // 
            this.salvarComoMenuItem.Name = "salvarComoMenuItem";
            this.salvarComoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvarComoMenuItem.Size = new System.Drawing.Size(220, 22);
            this.salvarComoMenuItem.Text = "Salvar como...";
            this.salvarComoMenuItem.Click += new System.EventHandler(this.SalvarComoMenuItem_Click);
            // 
            // abrirMenuItem
            // 
            this.abrirMenuItem.Name = "abrirMenuItem";
            this.abrirMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirMenuItem.Size = new System.Drawing.Size(220, 22);
            this.abrirMenuItem.Text = "Abrir";
            this.abrirMenuItem.Click += new System.EventHandler(this.AbrirMenuItem_Click);
            // 
            // rtxtConteudo
            // 
            this.rtxtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtConteudo.Location = new System.Drawing.Point(0, 24);
            this.rtxtConteudo.Name = "rtxtConteudo";
            this.rtxtConteudo.Size = new System.Drawing.Size(642, 251);
            this.rtxtConteudo.TabIndex = 1;
            this.rtxtConteudo.Text = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Arq. de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Arq. de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 275);
            this.Controls.Add(this.rtxtConteudo);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Bloco de Notas";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoMenuItem;
        private System.Windows.Forms.RichTextBox rtxtConteudo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem abrirMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

