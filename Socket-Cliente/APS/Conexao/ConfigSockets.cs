/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 01/05/2019
 * Time: 19:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

//Importando Biblioteca para manipular Arquivos
using System.IO;

namespace APS.Conexao
{
	/// <summary>
	/// Description of ConfigSockets.
	/// </summary>
	public partial class ConfigSockets : Form
	{
		public ConfigSockets()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TestarConexaoClick(object sender, EventArgs e)
		{
			//Envia diretamente o ip e porta ao Socket
			Conexao.ConexaoSockets Teste = new Conexao.ConexaoSockets();
			Teste.Criar_Conexao("",IpServidor.Text,PortaServidor.Text);
			
		}
		void SalvarConexaoClick(object sender, EventArgs e)
		{
			//Cria o Arquivo de Texto
			StreamWriter valor = new StreamWriter("Configurações\\ConfigCliente.txt");
			valor.WriteLine(IpServidor.Text);
			valor.WriteLine(PortaServidor.Text);
			valor.Dispose();
			MessageBox.Show("As configurações Foram atualizadas com Sucesso");
		}
		void StopConexaoClick(object sender, EventArgs e)
		{
			
		}
		void ConfigSocketsLoad(object sender, EventArgs e)
		{
			string Endereco_txt = "Configurações\\ConfigCliente.txt";
			string Ip_txt = "";
			string Porta_txt = "";
			FileInfo ArquivoTexto = new FileInfo(Endereco_txt);
				if(ArquivoTexto.Exists){            	
	            	StreamReader sr = new StreamReader(Endereco_txt);
	                {
						bool Contador = true;
		                String linha;
		                // Lê linha por linha
		                while ((linha = sr.ReadLine()) != null)
		                {
		                    if(Contador){
		                		Ip_txt = linha;
		                		Contador = false;
			    			}
		                	else{
		                		Porta_txt = linha;
			    			}
		                }
		                sr.Dispose();
	                }
	            	IpServidor.Text = Ip_txt;
	            	PortaServidor.Text = Porta_txt;
			}
		}
	}
}
