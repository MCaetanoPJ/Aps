/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 28/04/2019
 * Time: 23:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using APS.Forms;

namespace APS
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void EntrarClick(object sender, EventArgs e)
		{
			//Chama a tela Principal
				TelaPrincipal Tela_Principal = new TelaPrincipal();
				Tela_Principal.Show();
		}
		void CadastrarClick(object sender, EventArgs e)
		{
			//Chama a tela de Cadastro
				CadastroUsuario Tela_Cadastro = new CadastroUsuario();
				Tela_Cadastro.Show();
		}
		void ConfigServidorClick(object sender, EventArgs e)
		{
			Conexao.ConfigSockets Configuracao = new Conexao.ConfigSockets();
			Configuracao.Show();
		}
	}
}
