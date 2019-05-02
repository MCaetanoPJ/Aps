/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 01/05/2019
 * Time: 22:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Dynamic;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Text;

//Importando Biblioteca para usar Sockets
using System.Net;
using System.Net.Sockets;

//Importando Biblioteca para manipular Arquivo de Texto
using System.IO;

namespace APS.Conexao
{
	/// <summary>
	/// Description of ConexaoSockets.
	/// </summary>
	public class ConexaoSockets
	{
		
		public void LerArquivoTexto(string Dados){
			//Classe Responsavel por ler o Ip e a Porta dentro do Arquivo de Texto e enviar como parametro a classe ConexãoSockets
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
	                }
	            	//Registra tudo que que sai dessa Classe
	            	Relatorios.GerarRelatorio Relatorio = new Relatorios.GerarRelatorio();
	            	Relatorio.RegistrarRelatorio(Dados,Ip_txt,Porta_txt);
	            	
	            	//Passa o IP e a porta como parametro para a proxima classe
					Criar_Conexao(Dados,Ip_txt,Porta_txt);
				}
				else{
					//Exibe o Form para definir o Ip do Servidor
					ConfigSockets Configurar = new ConfigSockets();
					Configurar.Show();
				}
		}
		
		public void Criar_Conexao(string Dados, string IP, string Porta){
			//Classe responsavel por receber receber dados de outras telas e enviar ao servidor
			try{
			Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
																//Ip do servidor e sua porta
			IPEndPoint connect = new IPEndPoint(IPAddress.Parse(IP),Convert.ToInt32(Porta));
			listen.Connect(connect);																
			
			if(listen.Connected){
				MessageBox.Show("Você está Conectado");
				
				//Registra tudo que que sai dessa Classe
            	Relatorios.GerarRelatorio Relatorio = new Relatorios.GerarRelatorio();
            	Relatorio.RegistrarRelatorio(Dados,IP,Porta);
				
				//Responsavel por enviar os dados recebidos ao servidor
				byte[] Dados_a_Enviar = new byte[100];
				Dados_a_Enviar = Encoding.Default.GetBytes(Dados);
				listen.Send(Dados_a_Enviar);
			}
			else{
				MessageBox.Show("Você está Desconectado");
			}
			
			}
			catch(Exception ErroConexao){
				MessageBox.Show("Erro durante a conexão com o Servidor: "+ErroConexao.Message);
				
				//Registra tudo que que sai dessa Classe
            	Relatorios.GerarRelatorio Relatorio = new Relatorios.GerarRelatorio();
            	Relatorio.RegistrarRelatorio(ErroConexao.Message,IP,Porta);
			}
		}
		
	}
}
