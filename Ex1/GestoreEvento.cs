using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public static class GestoreEvento
    {
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("A new file has just been created {0}", e.Name);
            try
            {
                //Lettura da file
                using (StreamReader reader = File.OpenText(e.FullPath))
                {
                    Console.WriteLine($"Content of {e.Name}");
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }

                    Console.WriteLine("\t End of file.");
                    Console.WriteLine("\n");
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
