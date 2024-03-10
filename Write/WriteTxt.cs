namespace ReadWriteTxt.Write
{
    public class WriteTxt
    {
        public void Write(){
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\dev\\Products.txt");
                //Write a line of text
                sw.WriteLine("Produtos");
                //Write a second line of text
                sw.WriteLine("Adicionando ");
                //Close the file
                sw.Close();
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