using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BibliotecaDeJogos
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		    ConfigurarCombos();
            ConfigurarTabela();
            CarregarJogos();
		}
	    List<Jogos> jogos = new List<Jogos>();

        string arquivo = "jogos.csv";

        Jogos jogoSelecionado = null;


        // =====================================================
        // CONFIGURAR COMBOBOX
        // =====================================================

        void ConfigurarCombos()
        {
            cmbPlataforma.Items.Clear();

            cmbPlataforma.Items.Add("PC");
            cmbPlataforma.Items.Add("PS5");
            cmbPlataforma.Items.Add("Xbox S/X");
            cmbPlataforma.Items.Add("Nintendo Switch");

            cmbGenero.Items.Clear();

            cmbGenero.Items.Add("RPG");
            cmbGenero.Items.Add("FPS");
            cmbGenero.Items.Add("Ação");
            cmbGenero.Items.Add("Aventura");
            cmbGenero.Items.Add("Esporte");
            cmbGenero.Items.Add("Corrida");
            cmbGenero.Items.Add("Terror");
            cmbGenero.Items.Add("Estratégia");
            cmbGenero.Items.Add("SoulsLike");
            cmbGenero.Items.Add("RogueLike");
            cmbGenero.Items.Add("Beat 'em up ");
            cmbGenero.Items.Add("Hack and slash ");
            cmbGenero.Items.Add("Metroidvania");


            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Jogando");
            cmbStatus.Items.Add("Finalizado");
            cmbStatus.Items.Add("Desejado");
        }


        // =====================================================
        // CONFIGURAR TABELA
        // =====================================================

        void ConfigurarTabela()
        {
            dgvJogos.Columns.Clear();

            dgvJogos.Columns.Add("Nome", "Nome");
            dgvJogos.Columns.Add("Plataforma", "Plataforma");
            dgvJogos.Columns.Add("Genero", "Gênero");
            dgvJogos.Columns.Add("Status", "Status");
            dgvJogos.Columns.Add("Nota", "Nota");

            dgvJogos.ReadOnly = true;
            dgvJogos.AllowUserToAddRows = false;
            dgvJogos.MultiSelect = false;

            dgvJogos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvJogos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


        // =====================================================
        // ATUALIZAR TABELA
        // =====================================================

         void AtualizarTabela()
        {
            dgvJogos.Rows.Clear();

            foreach (Jogos jogo in jogos)
            {
                int linha = dgvJogos.Rows.Add(
                    jogo.Nome,
                    jogo.Plataforma,
                    jogo.Genero,
                    jogo.Status,
                    jogo.Nota.ToString("0.0")
                );

                // Guarda o objeto Jogo na própria linha
                dgvJogos.Rows[linha].Tag = jogo;
            }
        }


        // =====================================================
        // CADASTRAR
        // =====================================================

        void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Jogos novoJogo = new Jogos();

            novoJogo.Nome = txtNome.Text.Trim();
            novoJogo.Plataforma = cmbPlataforma.Text;
            novoJogo.Genero = cmbGenero.Text;
            novoJogo.Status = cmbStatus.Text;
            novoJogo.Nota = Convert.ToDouble(nudNota.Value);

            jogos.Add(novoJogo);

            SalvarJogos();

            AtualizarTabela();

            LimparCampos();

            MessageBox.Show(
                "Jogo cadastrado com sucesso!",
                "Cadastro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =====================================================
        // SELECIONAR JOGO NA TABELA
        // =====================================================

            void dgvJogos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow linha =
            	dgvJogos.CurrentRow;

            jogoSelecionado =
                linha.Tag as Jogos;

            if (jogoSelecionado != null)
            {
                txtNome.Text =
                    jogoSelecionado.Nome;

                cmbPlataforma.Text =
                    jogoSelecionado.Plataforma;

                cmbGenero.Text =
                    jogoSelecionado.Genero;

                cmbStatus.Text =
                    jogoSelecionado.Status;

                nudNota.Value =
                    Convert.ToDecimal(jogoSelecionado.Nota);
            }
        }


        // =====================================================
        // ALTERAR
        // =====================================================

        void btnAlterar_Click(object sender, EventArgs e)
        {
            if (jogoSelecionado == null)
            {
                MessageBox.Show(
                    "Selecione um jogo na tabela.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            jogoSelecionado.Nome =
                txtNome.Text.Trim();

            jogoSelecionado.Plataforma =
                cmbPlataforma.Text;

            jogoSelecionado.Genero =
                cmbGenero.Text;

            jogoSelecionado.Status =
                cmbStatus.Text;

            jogoSelecionado.Nota =
                Convert.ToDouble(nudNota.Value);

            SalvarJogos();

            AtualizarTabela();

            LimparCampos();

            MessageBox.Show(
                "Jogo alterado com sucesso!",
                "Alteração",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =====================================================
        // EXCLUIR
        // =====================================================

        void btnExcluir_Click(object sender, EventArgs e)
        {
        	
            if (jogoSelecionado == null)
            {
                MessageBox.Show(
                    "Selecione um jogo na tabela.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult resposta =
                MessageBox.Show(
                    "Deseja excluir o jogo " +
                    jogoSelecionado.Nome + "?",
                    "Confirmar exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resposta == DialogResult.Yes)
            {
                jogos.Remove(jogoSelecionado);

                SalvarJogos();

                AtualizarTabela();

                LimparCampos();

                MessageBox.Show(
                    "Jogo excluído com sucesso!",
                    "Exclusão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        // =====================================================
        // PESQUISAR
        // =====================================================

        void btnBuscar_Click(object sender, EventArgs e)
        {
            string pesquisa =
                txtPesquisar.Text.Trim().ToLower();

            dgvJogos.Rows.Clear();

            if (pesquisa == "")
            {
                AtualizarTabela();
                return;
            }

            foreach (Jogos jogo in jogos)
            {
                if (jogo.Nome.ToLower().Contains(pesquisa))
                {
                    int linha = dgvJogos.Rows.Add(
                        jogo.Nome,
                        jogo.Plataforma,
                        jogo.Genero,
                        jogo.Status,
                        jogo.Nota.ToString("0.0")
                    );

                    dgvJogos.Rows[linha].Tag = jogo;
                }
            }

            if (dgvJogos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Nenhum jogo encontrado.",
                    "Pesquisa"
                );
            }
        }


        // =====================================================
        // LIMPAR CAMPOS
        // =====================================================

        void LimparCampos()
        {
            txtNome.Clear();

            cmbPlataforma.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            nudNota.Value = 0;

            jogoSelecionado = null;

            dgvJogos.ClearSelection();
        }


        // =====================================================
        // VALIDAR CAMPOS
        // =====================================================

        bool ValidarCampos()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Digite o nome do jogo."
                );

                txtNome.Focus();

                return false;
            }

            if (cmbPlataforma.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione uma plataforma."
                );

                cmbPlataforma.Focus();

                return false;
            }

            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione um gênero."
                );

                cmbGenero.Focus();

                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione o status."
                );

                cmbStatus.Focus();

                return false;
            }

            return true;
        }


        // =====================================================
        // SALVAR CSV
        // =====================================================

        void SalvarJogos()
        {
            try
            {
                using (StreamWriter escritor =
                    new StreamWriter(arquivo))
                {
                    escritor.WriteLine(
                        "Nome;Plataforma;Genero;Status;Nota"
                    );

                    foreach (Jogos jogo in jogos)
                    {
                        escritor.WriteLine(
                            jogo.Nome + ";" +
                            jogo.Plataforma + ";" +
                            jogo.Genero + ";" +
                            jogo.Status + ";" +
                            jogo.Nota.ToString(
                            )
                        );
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao salvar o arquivo: " +
                    erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // CARREGAR CSV
        // =====================================================

        void CarregarJogos()
        {
            if (!File.Exists(arquivo))
            {
                return;
            }

            try
            {
                using (StreamReader leitor =
                    new StreamReader(arquivo))
                {
                    leitor.ReadLine();

                    string linha;

                    while ((linha =
                           leitor.ReadLine()) != null)
                    {
                        string[] dados =
                            linha.Split(';');

                        if (dados.Length >= 5)
                        {
                            double nota;

                            bool conseguiuConverter =
                                double.TryParse(
                                    dados[4], out nota
                                );

                            if (conseguiuConverter)
                            {
                                Jogos jogo =
                                    new Jogos();

                                jogo.Nome =
                                    dados[0];

                                jogo.Plataforma =
                                    dados[1];

                                jogo.Genero =
                                    dados[2];

                                jogo.Status =
                                    dados[3];

                                jogo.Nota =
                                    nota;

                                jogos.Add(jogo);
                            }
                        }
                    }
                }

                AtualizarTabela();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao carregar o arquivo: " +
                    erro.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
} 
