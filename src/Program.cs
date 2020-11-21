using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PhasmophobiaSaveEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConvertSaveData(string input)
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
            StreamWriter writer = new StreamWriter(@"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\Kinetic Games\Phasmophobia\EditedSaveData.txt");
            var saveData = reader.ReadToEnd();
            var parsedSaveData = ConvertSaveData(saveData);
            var jsonData = JsonConvert.DeserializeObject<Dictionary<dynamic, dynamic>>(parsedSaveData);

            foreach (var v in jsonData)
            {
                if (v.Key == "StringData")
                {
                    foreach (var dataArray in v.Value)
                    {
                        Console.WriteLine(dataArray.Key + ": " + dataArray.Value);
                        Console.WriteLine("Enter new value:");
                        var read = Console.ReadLine();
                        dataArray.Value = read;
                    }
                }
                else if (v.Key == "IntData")
                {
                    foreach (var dataArray in v.Value)
                    {
                        Console.WriteLine(dataArray.Key + ": " + dataArray.Value);
                        Console.WriteLine("Enter new value:");
                        var read = Console.ReadLine();
                        dataArray.Value = Convert.ToInt32(read);
                    }
                }
            }


            writer.Write(ConvertSaveData(JsonConvert.SerializeObject(jsonData)));
            writer.Close();

            Console.WriteLine("Success! You can find the edited save data under the name 'EditedSaveData.txt'");

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }
    }
}
