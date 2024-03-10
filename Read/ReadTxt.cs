using System.IO;
namespace ReadWriteTxt.Read
{
    public class ReadTxt
    {
        public ReadTxt(){}
        String line;
       public void Read(){
         try
        {
            String path = "C:\\dev\\Products.txt";
            using (StreamReader sr = new(path))
            { 
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            
                sr.Close();
            }
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