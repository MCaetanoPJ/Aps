/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 28/04/2019
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace APS.Forms
{
	/// <summary>
	/// Description of TelaPrincipal.
	/// </summary>
	public partial class TelaPrincipal : Form
	{
		public TelaPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void EditarPerfilClick(object sender, EventArgs e)
		{
			//Chama a tela de Editar Perfil
				CadastroUsuario Tela_Perfil = new CadastroUsuario();
				Tela_Perfil.Show();
		}
		void RegistraVisitaClick(object sender, EventArgs e)
		{
			//Chama a tela de Registrar Visita
				EditarPerfil Tela_RegistrarVisita = new EditarPerfil();
				Tela_RegistrarVisita.Show();
		}
	}
}
