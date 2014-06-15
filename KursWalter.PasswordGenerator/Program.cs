using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Classes;


namespace KursWalter.PasswordGenerator
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var pwgenerator = new Coding();
            Console.WriteLine("Passwort generator");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Bitte geben Sie ihr Passwort ein: ");
            var password = Console.ReadLine();
            Console.WriteLine();
            password = pwgenerator.generateHashMD5(password);

            //ToDo: muss vlt nochmal umgewandelt werden...

            Console.WriteLine("MD5-string: {0}",password);

            System.Windows.Forms.Clipboard.SetText(password);
            Console.WriteLine("Das Passwort ist jetzt in der Zwischenablage!");

            Console.ReadLine();

            
            
        }
    }
}
