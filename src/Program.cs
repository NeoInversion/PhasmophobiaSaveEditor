using System;
using System.IO;

namespace PhasmophobiaSaveEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string DeserializeSaveData(string input)
            {
                string xorConst = "CHANGE ME TO YOUR OWN RANDOM STRING";
                string output = "";

                for (int i = 0; i < input.Length; i++)
                {
                    output += Convert.ToChar(input[i] ^ xorConst[i % xorConst.Length]);
                }

                return output;
            }

            StreamReader reader = new StreamReader(@"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Kinetic Games\Phasmophobia\saveData.txt");
            StreamWriter writer = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "saveDataExport.json"));
            var saveData = reader.ReadToEnd();
            var parsedSaveData = DeserializeSaveData(saveData);

            Console.WriteLine(parsedSaveData);
            Console.WriteLine("Export save data?");

            var read = Console.ReadLine();
            if (read.ToLower()[0] == 'y')
            {
                writer.Write(parsedSaveData);
                writer.Close();
                Console.WriteLine("Successfully wrote to saveDataExport.json");
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }
    }
}
