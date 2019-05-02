/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 01/05/2019
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace APS.Conexao
{
	partial class ConfigSockets
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox IpServidor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox InfoServidor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox PortaServidor;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button StopConexao;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button SalvarConexao;
		private System.Windows.Forms.Button TestarConexao;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.InfoServidor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.PortaServidor = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.StopConexao = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SalvarConexao = new System.Windows.Forms.Button();
			this.TestarConexao = new System.Windows.Forms.Button();
			this.IpServidor = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP do Servidor";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Status da Conexão";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(121, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "OFFLINE";
			// 
			// InfoServidor
			// 
			this.InfoServidor.Location = new System.Drawing.Point(3, 156);
			this.InfoServidor.Multiline = true;
			this.InfoServidor.Name = "InfoServidor";
			this.InfoServidor.Size = new System.Drawing.Size(487, 372);
			this.InfoServidor.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Porta do Servidor";
			// 
			// PortaServidor
			// 
			this.PortaServidor.Location = new System.Drawing.Point(96, 65);
			this.PortaServidor.Name = "PortaServidor";
			this.PortaServidor.Size = new System.Drawing.Size(159, 20);
			this.PortaServidor.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.StopConexao);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.SalvarConexao);
			this.panel1.Controls.Add(this.TestarConexao);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.InfoServidor);
			this.panel1.Controls.Add(this.PortaServidor);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.IpServidor);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(495, 533);
			this.panel1.TabIndex = 7;
			// 
			// StopConexao
			// 
			this.StopConexao.Location = new System.Drawing.Point(232, 94);
			this.StopConexao.Name = "StopConexao";
			this.StopConexao.Size = new System.Drawing.Size(116, 23);
			this.StopConexao.TabIndex = 10;
			this.StopConexao.Text = "Interromper Conexão";
			this.StopConexao.UseVisualStyleBackColor = true;
			this.StopConexao.Click += new System.EventHandler(this.StopConexaoClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(150, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Relatório da Conexão";
			// 
			// SalvarConexao
			// 
			this.SalvarConexao.Location = new System.Drawing.Point(96, 94);
			this.SalvarConexao.Name = "SalvarConexao";
			this.SalvarConexao.Size = new System.Drawing.Size(120, 23);
			this.SalvarConexao.TabIndex = 8;
			this.SalvarConexao.Text = "Salvar Conexão";
			this.SalvarConexao.UseVisualStyleBackColor = true;
			this.SalvarConexao.Click += new System.EventHandler(this.SalvarConexaoClick);
			// 
			// TestarConexao
			// 
			this.TestarConexao.Location = new System.Drawing.Point(270, 34);
			this.TestarConexao.Name = "TestarConexao";
			this.TestarConexao.Size = new System.Drawing.Size(109, 23);
			this.TestarConexao.TabIndex = 7;
			this.TestarConexao.Text = "Testar Conexão";
			this.TestarConexao.UseVisualStyleBackColor = true;
			this.TestarConexao.Click += new System.EventHandler(this.TestarConexaoClick);
			// 
			// IpServidor
			// 
			this.IpServidor.Location = new System.Drawing.Point(96, 36);
			this.IpServidor.Name = "IpServidor";
			this.IpServidor.Size = new System.Drawing.Size(159, 20);
			this.IpServidor.TabIndex = 1;
			// 
			// ConfigSockets
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 539);
			this.Controls.Add(this.panel1);
			this.Name = "ConfigSockets";
			this.Text = "ConfigSockets";
			this.Load += new System.EventHandler(this.ConfigSocketsLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
