using BlocoDeNotas.Entidades;
using BlocoDeNotas.Servicos;
using System;
using System.Windows.Forms;

namespace BlocoDeNotas
{
    public partial class Form1 : Form
    {
        Arquivo arquivo = new Arquivo();

        public Form1()
        {
            InitializeComponent();
        }

        private void SalvarMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                arquivo.Conteudo = rtxtConteudo.Text;
                if (!arquivo.Salvo)
                {
                    saveFileDialog.ShowDialog();
                    arquivo.Caminho = saveFileDialog.FileName;
                    ServicoArquivo.Escrever(arquivo);
                }
                else
                {
                    ServicoArquivo.Escrever(arquivo);
                }
                MessageBox.Show("Salvo com sucesso!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void SalvarComoMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.ShowDialog();
                arquivo.Caminho = saveFileDialog.FileName;
                ServicoArquivo.Escrever(arquivo);
                MessageBox.Show("Salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void AbrirMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                arquivo.Caminho = openFileDialog.FileName;
                rtxtConteudo.Text = ServicoArquivo.Ler(arquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
