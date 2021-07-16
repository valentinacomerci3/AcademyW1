using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Expenses
    {
        public string Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Import { get; set; }

        public void LoadFromFile(string fileName)
        {
            try
            {
                using (StreamReader reader = File.OpenText("C:\\Users\valentina.comerci\\Desktop\testFolder" + fileName))
                {
                    string data = reader.ReadLine();
                    string instanceData = reader.ReadLine();
                    string[] values = instanceData.Split(":");

                    string[] spese = values[1].Split(";");

                    Date = spese[0];
                    Category = spese[1]; 
                    Description = spese[2]; 
                    int.TryParse(spese[3], out int i);
                    Import= i;

                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
