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
	partial class CadastroUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button BotaoCadastrar;
		private System.Windows.Forms.Button BotaoLimpar;
		private System.Windows.Forms.Button BotaoVoltar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BotaoImportarFoto;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.BotaoCadastrar = new System.Windows.Forms.Button();
			this.BotaoLimpar = new System.Windows.Forms.Button();
			this.BotaoVoltar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BotaoImportarFoto = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Área de Atuação";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome Completo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Senha";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Confirmar Senha";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(100, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(307, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(100, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(307, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(100, 68);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(307, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(100, 95);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(307, 20);
			this.textBox3.TabIndex = 7;
			// 
			// BotaoCadastrar
			// 
			this.BotaoCadastrar.Location = new System.Drawing.Point(134, 152);
			this.BotaoCadastrar.Name = "BotaoCadastrar";
			this.BotaoCadastrar.Size = new System.Drawing.Size(141, 26);
			this.BotaoCadastrar.TabIndex = 8;
			this.BotaoCadastrar.Text = "Cadastrar";
			this.BotaoCadastrar.UseVisualStyleBackColor = true;
			this.BotaoCadastrar.Click += new System.EventHandler(this.Button1Click);
			// 
			// BotaoLimpar
			// 
			this.BotaoLimpar.Location = new System.Drawing.Point(281, 152);
			this.BotaoLimpar.Name = "BotaoLimpar";
			this.BotaoLimpar.Size = new System.Drawing.Size(126, 26);
			this.BotaoLimpar.TabIndex = 9;
			this.BotaoLimpar.Text = "Limpar";
			this.BotaoLimpar.UseVisualStyleBackColor = true;
			// 
			// BotaoVoltar
			// 
			this.BotaoVoltar.Location = new System.Drawing.Point(3, 152);
			this.BotaoVoltar.Name = "BotaoVoltar";
			this.BotaoVoltar.Size = new System.Drawing.Size(125, 26);
			this.BotaoVoltar.TabIndex = 10;
			this.BotaoVoltar.Text = "Voltar";
			this.BotaoVoltar.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.BotaoVoltar);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.BotaoLimpar);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.BotaoCadastrar);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(172, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(419, 181);
			this.panel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.BotaoImportarFoto);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(154, 182);
			this.panel2.TabIndex = 12;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(148, 139);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// BotaoImportarFoto
			// 
			this.BotaoImportarFoto.Location = new System.Drawing.Point(0, 154);
			this.BotaoImportarFoto.Name = "BotaoImportarFoto";
			this.BotaoImportarFoto.Size = new System.Drawing.Size(148, 23);
			this.BotaoImportarFoto.TabIndex = 0;
			this.BotaoImportarFoto.Text = "Importar Foto";
			this.BotaoImportarFoto.UseVisualStyleBackColor = true;
			// 
			// CadastroUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 206);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CadastroUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CadastroUsuario";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
