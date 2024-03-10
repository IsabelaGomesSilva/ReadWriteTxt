using System.Text;
using ReadWriteTxt.Models;

namespace ReadWriteTxt.Write
{
    public class WriteTxt
    {
        public void Write(Product[] products){
            try
            {
                String path = "C:\\dev\\Products.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    StringBuilder stringBuilder = new();
                    // Está criando o cabeçalho da tabela de produtos no formato de uma linha de 
                    // texto com colunas separadas por tabulação. Cada \t insere uma tabulação
                    stringBuilder.AppendLine("Id\tDescription\tAmount\tPrice");
             
                    foreach (Product p in products)
                    {
                       
                        stringBuilder.AppendLine($"\t{p.Id}\t{p.Description}\t{p.Amount}\t{p.Price}");
                    }
                    sw.Write(stringBuilder.ToString());
                    Console.WriteLine(stringBuilder.ToString());
                    sw.Close();
                }
                Console.WriteLine("Products successfully added");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}