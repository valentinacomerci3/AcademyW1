using System;
using System.IO;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___ Watcher Files ___");
            FileSystemWatcher fsw = new FileSystemWatcher();

            //percorso da tenere monitorato
            fsw.Path = @"C:\Users\valentina.comerci\Desktop";

            //definisco il filtro di controllo sui file .txt
            fsw.Filter = "*.txt";

            fsw.NotifyFilter = NotifyFilters.LastWrite |
                NotifyFilters.LastAccess | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;

            //Abilito le notifiche 
            fsw.EnableRaisingEvents = true;

            //Iscrizione all'evento
            fsw.Created += GestoreEvento.HandleNewTextFile;

            Console.WriteLine("q - to quit");
            while (Console.Read() != 'q') ;

        }
    }
}
