/*
 * Created by SharpDevelop.
 * User: Alex Junio
 * Date: 10/08/2026
 * Time: 22:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BibliotecaDeJogos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblBibliotecaDeJogos;
		private System.Windows.Forms.GroupBox gboEdicao;
		private System.Windows.Forms.NumericUpDown nudNota;
		private System.Windows.Forms.ComboBox cmbGenero;
		private System.Windows.Forms.ComboBox cmbPlataforma;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNota;
		private System.Windows.Forms.Label lblGenero;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblPlataforma;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.GroupBox gboBuscaFiltros;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label lblPesquisar;
		private System.Windows.Forms.GroupBox gboJogosCadastrados;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlataforma;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGênero;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNota;
		private System.Windows.Forms.DataGridView dgvJogos;
		private System.Windows.Forms.ComboBox cmbStatus;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblBibliotecaDeJogos = new System.Windows.Forms.Label();
			this.gboEdicao = new System.Windows.Forms.GroupBox();
			this.nudNota = new System.Windows.Forms.NumericUpDown();
			this.cmbGenero = new System.Windows.Forms.ComboBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.cmbPlataforma = new System.Windows.Forms.ComboBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNota = new System.Windows.Forms.Label();
			this.lblGenero = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblPlataforma = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.gboBuscaFiltros = new System.Windows.Forms.GroupBox();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.lblPesquisar = new System.Windows.Forms.Label();
			this.gboJogosCadastrados = new System.Windows.Forms.GroupBox();
			this.dgvJogos = new System.Windows.Forms.DataGridView();
			this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGênero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gboEdicao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
			this.gboBuscaFiltros.SuspendLayout();
			this.gboJogosCadastrados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBibliotecaDeJogos
			// 
			this.lblBibliotecaDeJogos.AutoSize = true;
			this.lblBibliotecaDeJogos.Location = new System.Drawing.Point(395, 9);
			this.lblBibliotecaDeJogos.Name = "lblBibliotecaDeJogos";
			this.lblBibliotecaDeJogos.Size = new System.Drawing.Size(528, 40);
			this.lblBibliotecaDeJogos.TabIndex = 0;
			this.lblBibliotecaDeJogos.Text = "🎮 Sistema de Cadastro - Biblioteca de Jogos";
			// 
			// gboEdicao
			// 
			this.gboEdicao.Controls.Add(this.nudNota);
			this.gboEdicao.Controls.Add(this.cmbGenero);
			this.gboEdicao.Controls.Add(this.cmbStatus);
			this.gboEdicao.Controls.Add(this.cmbPlataforma);
			this.gboEdicao.Controls.Add(this.txtNome);
			this.gboEdicao.Controls.Add(this.lblNota);
			this.gboEdicao.Controls.Add(this.lblGenero);
			this.gboEdicao.Controls.Add(this.lblStatus);
			this.gboEdicao.Controls.Add(this.lblPlataforma);
			this.gboEdicao.Controls.Add(this.lblNome);
			this.gboEdicao.Controls.Add(this.btnExcluir);
			this.gboEdicao.Controls.Add(this.btnAlterar);
			this.gboEdicao.Controls.Add(this.btnCadastrar);
			this.gboEdicao.Location = new System.Drawing.Point(12, 64);
			this.gboEdicao.Name = "gboEdicao";
			this.gboEdicao.Size = new System.Drawing.Size(1171, 310);
			this.gboEdicao.TabIndex = 1;
			this.gboEdicao.TabStop = false;
			this.gboEdicao.Text = "CAMPOS DE CADASTRO / EDIÇÃO";
			// 
			// nudNota
			// 
			this.nudNota.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudNota.Location = new System.Drawing.Point(785, 191);
			this.nudNota.Name = "nudNota";
			this.nudNota.Size = new System.Drawing.Size(380, 32);
			this.nudNota.TabIndex = 12;
			// 
			// cmbGenero
			// 
			this.cmbGenero.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbGenero.FormattingEnabled = true;
			this.cmbGenero.Items.AddRange(new object[] {
			"Ação",
			"Aventura",
			"RPG",
			"FPS",
			"Estratégia",
			"Esportes",
			"Jogo de Luta",
			"Beat \'em up ",
			"Roguelikes",
			"SoulsLikes",
			"Hack and slash ",
			"Metroidvania"});
			this.cmbGenero.Location = new System.Drawing.Point(810, 132);
			this.cmbGenero.Name = "cmbGenero";
			this.cmbGenero.Size = new System.Drawing.Size(353, 32);
			this.cmbGenero.TabIndex = 11;
			// 
			// cmbStatus
			// 
			this.cmbStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
			"Finalizado",
			"Jogando",
			"Desejado"});
			this.cmbStatus.Location = new System.Drawing.Point(105, 191);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(589, 32);
			this.cmbStatus.TabIndex = 10;
			// 
			// cmbPlataforma
			// 
			this.cmbPlataforma.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPlataforma.FormattingEnabled = true;
			this.cmbPlataforma.Items.AddRange(new object[] {
			"PC",
			"XBOX S/X",
			"PS5",
			"NINTENDO SWITCH"});
			this.cmbPlataforma.Location = new System.Drawing.Point(164, 134);
			this.cmbPlataforma.Name = "cmbPlataforma";
			this.cmbPlataforma.Size = new System.Drawing.Size(534, 32);
			this.cmbPlataforma.TabIndex = 9;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(190, 72);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(975, 32);
			this.txtNome.TabIndex = 8;
			// 
			// lblNota
			// 
			this.lblNota.AutoSize = true;
			this.lblNota.Location = new System.Drawing.Point(704, 182);
			this.lblNota.Name = "lblNota";
			this.lblNota.Size = new System.Drawing.Size(73, 40);
			this.lblNota.TabIndex = 7;
			this.lblNota.Text = "Nota:";
			// 
			// lblGenero
			// 
			this.lblGenero.AutoSize = true;
			this.lblGenero.Location = new System.Drawing.Point(704, 124);
			this.lblGenero.Name = "lblGenero";
			this.lblGenero.Size = new System.Drawing.Size(100, 40);
			this.lblGenero.TabIndex = 6;
			this.lblGenero.Text = "Gênero:";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(6, 182);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(93, 40);
			this.lblStatus.TabIndex = 5;
			this.lblStatus.Text = "Status:";
			// 
			// lblPlataforma
			// 
			this.lblPlataforma.AutoSize = true;
			this.lblPlataforma.Location = new System.Drawing.Point(6, 124);
			this.lblPlataforma.Name = "lblPlataforma";
			this.lblPlataforma.Size = new System.Drawing.Size(145, 40);
			this.lblPlataforma.TabIndex = 4;
			this.lblPlataforma.Text = "Plataforma:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(6, 63);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(175, 40);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Nome do Jogo:";
			// 
			// btnExcluir
			// 
			this.btnExcluir.AutoSize = true;
			this.btnExcluir.Location = new System.Drawing.Point(1044, 253);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(121, 51);
			this.btnExcluir.TabIndex = 2;
			this.btnExcluir.Text = "Excluir  ";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnAlterar
			// 
			this.btnAlterar.AutoSize = true;
			this.btnAlterar.Location = new System.Drawing.Point(521, 253);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(116, 51);
			this.btnAlterar.TabIndex = 1;
			this.btnAlterar.Text = "Alterar ";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.AutoSize = true;
			this.btnCadastrar.Location = new System.Drawing.Point(6, 253);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(141, 51);
			this.btnCadastrar.TabIndex = 0;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// gboBuscaFiltros
			// 
			this.gboBuscaFiltros.Controls.Add(this.txtPesquisar);
			this.gboBuscaFiltros.Controls.Add(this.btnPesquisar);
			this.gboBuscaFiltros.Controls.Add(this.lblPesquisar);
			this.gboBuscaFiltros.Location = new System.Drawing.Point(12, 391);
			this.gboBuscaFiltros.Name = "gboBuscaFiltros";
			this.gboBuscaFiltros.Size = new System.Drawing.Size(493, 319);
			this.gboBuscaFiltros.TabIndex = 2;
			this.gboBuscaFiltros.TabStop = false;
			this.gboBuscaFiltros.Text = "BUSCA E FILTROS";
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisar.Location = new System.Drawing.Point(260, 100);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(227, 28);
			this.txtPesquisar.TabIndex = 2;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.AutoSize = true;
			this.btnPesquisar.Location = new System.Drawing.Point(149, 185);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(187, 71);
			this.btnPesquisar.TabIndex = 1;
			this.btnPesquisar.Text = "Buscar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// lblPesquisar
			// 
			this.lblPesquisar.AutoSize = true;
			this.lblPesquisar.Location = new System.Drawing.Point(6, 87);
			this.lblPesquisar.Name = "lblPesquisar";
			this.lblPesquisar.Size = new System.Drawing.Size(240, 40);
			this.lblPesquisar.TabIndex = 0;
			this.lblPesquisar.Text = "Pesquisar por Nome:";
			// 
			// gboJogosCadastrados
			// 
			this.gboJogosCadastrados.Controls.Add(this.dgvJogos);
			this.gboJogosCadastrados.Location = new System.Drawing.Point(511, 391);
			this.gboJogosCadastrados.Name = "gboJogosCadastrados";
			this.gboJogosCadastrados.Size = new System.Drawing.Size(672, 319);
			this.gboJogosCadastrados.TabIndex = 3;
			this.gboJogosCadastrados.TabStop = false;
			this.gboJogosCadastrados.Text = "LISTA DE JOGOS CADASTRADOS ";
			// 
			// dgvJogos
			// 
			this.dgvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colNome,
			this.colPlataforma,
			this.colGênero,
			this.colStatus,
			this.colNota});
			this.dgvJogos.Location = new System.Drawing.Point(6, 46);
			this.dgvJogos.MultiSelect = false;
			this.dgvJogos.Name = "dgvJogos";
			this.dgvJogos.RowHeadersVisible = false;
			this.dgvJogos.RowTemplate.Height = 24;
			this.dgvJogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvJogos.Size = new System.Drawing.Size(660, 267);
			this.dgvJogos.TabIndex = 0;
			// 
			// colNome
			// 
			this.colNome.DataPropertyName = "Nome";
			this.colNome.HeaderText = "Nome";
			this.colNome.Name = "colNome";
			this.colNome.Width = 120;
			// 
			// colPlataforma
			// 
			this.colPlataforma.DataPropertyName = "Plataforma";
			this.colPlataforma.HeaderText = "Plataforma";
			this.colPlataforma.Name = "colPlataforma";
			this.colPlataforma.Width = 185;
			// 
			// colGênero
			// 
			this.colGênero.DataPropertyName = "Gênero";
			this.colGênero.HeaderText = "Gênero";
			this.colGênero.Name = "colGênero";
			// 
			// colStatus
			// 
			this.colStatus.DataPropertyName = "Status";
			this.colStatus.HeaderText = "Status";
			this.colStatus.Name = "colStatus";
			// 
			// colNota
			// 
			this.colNota.DataPropertyName = "Nota";
			this.colNota.HeaderText = "Nota";
			this.colNota.Name = "colNota";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1195, 722);
			this.Controls.Add(this.gboJogosCadastrados);
			this.Controls.Add(this.gboBuscaFiltros);
			this.Controls.Add(this.gboEdicao);
			this.Controls.Add(this.lblBibliotecaDeJogos);
			this.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.gboEdicao.ResumeLayout(false);
			this.gboEdicao.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
			this.gboBuscaFiltros.ResumeLayout(false);
			this.gboBuscaFiltros.PerformLayout();
			this.gboJogosCadastrados.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
