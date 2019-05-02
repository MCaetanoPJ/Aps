/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 02/05/2019
 * Time: 02:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace APS.Relatorios
{
	/// <summary>
	/// Description of GerarRelatorio.
	/// </summary>
	public class GerarRelatorio
	{
		public GerarRelatorio()
		{
		}
		
		public void RegistrarRelatorio(string Dados, string Ip, String Porta){        	
	    	string ArquivoTexto = "Relatorios\\RelatorioCliente.txt";
//	    	FileInfo Ler_Arquivo = new FileInfo(ArquivoTexto);
//				if(Ler_Arquivo.Exists){
//					StreamReader sr = new StreamReader(ArquivoTexto);
//			        {
//			            String linha;
//			            // Lê linha por linha
//			            while ((linha = sr.ReadLine()) != null)
//			            {
//							 //Cria o Arquivo de Texto
//							 MessageBox.Show(linha);
//							 
//			            }
//			            StreamWriter Atualizar_Arquivo = new StreamWriter(ArquivoTexto);
//						Atualizar_Arquivo.WriteLine("("+DateTime.Now+") "+Ip+":"+Porta+" "+Dados+"\n");
//			        }
//	    		}
//	    	else{
	    		//Cria o Arquivo de Texto
	    		StreamWriter Gerar_Arquivo = new StreamWriter(ArquivoTexto);
				Gerar_Arquivo.WriteLine("("+DateTime.Now+") "+Ip+":"+Porta+" "+Dados+"\n");
				Gerar_Arquivo.Dispose(); 
	    	//}
		}
	}
}
