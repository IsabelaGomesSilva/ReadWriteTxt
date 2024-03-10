using System.IO;
namespace ReadWriteTxt.Read
{
    public class ReadTxt
    {
        private readonly StreamReader _streamReader;
        public ReadTxt(StreamReader streamReader) => _streamReader = streamReader;

        public ReadTxt()
        {
        }

        String line;
       public void Read(){
         try
        {
            
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new("C:\\dev\\Products.txt");
            //Read the first line of text
            String line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();
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