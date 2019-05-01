/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 28/04/2019
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace APS.Forms
{
	partial class TelaPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox CampoMensagem;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl MensagemEscrita;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button BotaoEnviar;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button BotaoImportarArquivo;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button EditarPerfil;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox CampoPesquisar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewImageColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.CampoMensagem = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.MensagemEscrita = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.BotaoEnviar = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.BotaoImportarArquivo = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.EditarPerfil = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CampoPesquisar = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.MensagemEscrita.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(2, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(807, 362);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.CampoPesquisar);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(815, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(308, 398);
			this.panel2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Pesquisar Usuário";
			// 
			// CampoMensagem
			// 
			this.CampoMensagem.Location = new System.Drawing.Point(6, 6);
			this.CampoMensagem.Multiline = true;
			this.CampoMensagem.Name = "CampoMensagem";
			this.CampoMensagem.Size = new System.Drawing.Size(781, 87);
			this.CampoMensagem.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.MensagemEscrita);
			this.panel3.Location = new System.Drawing.Point(2, 380);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(807, 158);
			this.panel3.TabIndex = 2;
			// 
			// MensagemEscrita
			// 
			this.MensagemEscrita.Controls.Add(this.tabPage1);
			this.MensagemEscrita.Controls.Add(this.tabPage2);
			this.MensagemEscrita.Controls.Add(this.tabPage3);
			this.MensagemEscrita.Location = new System.Drawing.Point(3, 3);
			this.MensagemEscrita.Name = "MensagemEscrita";
			this.MensagemEscrita.SelectedIndex = 0;
			this.MensagemEscrita.Size = new System.Drawing.Size(801, 151);
			this.MensagemEscrita.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.BotaoEnviar);
			this.tabPage1.Controls.Add(this.CampoMensagem);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(793, 125);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mensagem";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// BotaoEnviar
			// 
			this.BotaoEnviar.Location = new System.Drawing.Point(306, 99);
			this.BotaoEnviar.Name = "BotaoEnviar";
			this.BotaoEnviar.Size = new System.Drawing.Size(151, 23);
			this.BotaoEnviar.TabIndex = 1;
			this.BotaoEnviar.Text = "Enviar";
			this.BotaoEnviar.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(793, 125);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Emotions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.BotaoImportarArquivo);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(793, 125);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Enviar Arquivo";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// BotaoImportarArquivo
			// 
			this.BotaoImportarArquivo.Location = new System.Drawing.Point(309, 38);
			this.BotaoImportarArquivo.Name = "BotaoImportarArquivo";
			this.BotaoImportarArquivo.Size = new System.Drawing.Size(145, 39);
			this.BotaoImportarArquivo.TabIndex = 3;
			this.BotaoImportarArquivo.Text = "Importar Arquivo";
			this.BotaoImportarArquivo.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.EditarPerfil);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Location = new System.Drawing.Point(815, 12);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(308, 122);
			this.panel4.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(131, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Status";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(128, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Área de Atuação";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(131, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Nome";
			// 
			// EditarPerfil
			// 
			this.EditarPerfil.Location = new System.Drawing.Point(129, 93);
			this.EditarPerfil.Name = "EditarPerfil";
			this.EditarPerfil.Size = new System.Drawing.Size(174, 24);
			this.EditarPerfil.TabIndex = 0;
			this.EditarPerfil.Text = "Editar Meu Perfil";
			this.EditarPerfil.UseVisualStyleBackColor = true;
			this.EditarPerfil.Click += new System.EventHandler(this.EditarPerfilClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(119, 114);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// CampoPesquisar
			// 
			this.CampoPesquisar.Location = new System.Drawing.Point(93, 6);
			this.CampoPesquisar.Name = "CampoPesquisar";
			this.CampoPesquisar.Size = new System.Drawing.Size(160, 20);
			this.CampoPesquisar.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2});
			this.dataGridView1.Location = new System.Drawing.Point(3, 32);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(300, 361);
			this.dataGridView1.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(259, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "FotoUsuario";
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nome";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 550);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "TelaPrincipal";
			this.Text = "TelaPrincipal";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.MensagemEscrita.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
