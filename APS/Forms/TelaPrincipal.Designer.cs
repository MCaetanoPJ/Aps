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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl MensagemEscrita;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button EditarPerfil;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button RegistrarVisita;
		private System.Windows.Forms.Button RegistraVisita;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.MensagemEscrita = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.RegistraVisita = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.EditarPerfil = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.MensagemEscrita.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(2, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(807, 362);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(248, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversas de Usuários e chamada de video";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(815, 162);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(308, 376);
			this.panel2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Pesquisar Usuário";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 20);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(190, 20);
			this.textBox2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(73, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lista de Usuario do BD Online";
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
			this.MensagemEscrita.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(793, 125);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mensagem";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(306, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Enviar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 6);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(784, 87);
			this.textBox1.TabIndex = 0;
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
			this.tabPage3.Controls.Add(this.button3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(793, 125);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Enviar Arquivo";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(309, 38);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(145, 39);
			this.button3.TabIndex = 3;
			this.button3.Text = "Importar Arquivo";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.RegistraVisita);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.EditarPerfil);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Location = new System.Drawing.Point(815, 12);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(308, 144);
			this.panel4.TabIndex = 3;
			// 
			// RegistraVisita
			// 
			this.RegistraVisita.Location = new System.Drawing.Point(128, 113);
			this.RegistraVisita.Name = "RegistraVisita";
			this.RegistraVisita.Size = new System.Drawing.Size(174, 23);
			this.RegistraVisita.TabIndex = 4;
			this.RegistraVisita.Text = "Registrar Visita";
			this.RegistraVisita.UseVisualStyleBackColor = true;
			this.RegistraVisita.Click += new System.EventHandler(this.RegistraVisitaClick);
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
			this.EditarPerfil.Location = new System.Drawing.Point(128, 82);
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
			this.pictureBox1.Size = new System.Drawing.Size(119, 103);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
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
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.MensagemEscrita.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
