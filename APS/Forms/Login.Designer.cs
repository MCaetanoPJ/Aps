/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 28/04/2019
 * Time: 23:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace APS
{
	partial class Login
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label Senha;
		private System.Windows.Forms.Button Entrar;
		private System.Windows.Forms.Button Cadastrar;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Senha = new System.Windows.Forms.Label();
			this.Entrar = new System.Windows.Forms.Button();
			this.Cadastrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(280, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(69, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuário";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(125, 63);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(280, 20);
			this.textBox2.TabIndex = 2;
			// 
			// Senha
			// 
			this.Senha.Location = new System.Drawing.Point(69, 66);
			this.Senha.Name = "Senha";
			this.Senha.Size = new System.Drawing.Size(41, 24);
			this.Senha.TabIndex = 3;
			this.Senha.Text = "Senha";
			// 
			// Entrar
			// 
			this.Entrar.Location = new System.Drawing.Point(125, 98);
			this.Entrar.Name = "Entrar";
			this.Entrar.Size = new System.Drawing.Size(130, 28);
			this.Entrar.TabIndex = 4;
			this.Entrar.Text = "Entrar";
			this.Entrar.UseVisualStyleBackColor = true;
			this.Entrar.Click += new System.EventHandler(this.EntrarClick);
			// 
			// Cadastrar
			// 
			this.Cadastrar.Location = new System.Drawing.Point(273, 98);
			this.Cadastrar.Name = "Cadastrar";
			this.Cadastrar.Size = new System.Drawing.Size(132, 28);
			this.Cadastrar.TabIndex = 5;
			this.Cadastrar.Text = "Fazer Cadastro";
			this.Cadastrar.UseVisualStyleBackColor = true;
			this.Cadastrar.Click += new System.EventHandler(this.CadastrarClick);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 171);
			this.Controls.Add(this.Cadastrar);
			this.Controls.Add(this.Entrar);
			this.Controls.Add(this.Senha);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
