using System;
using System.Text;
using System.IO;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            Console.WriteLine("                                                         ZENOOS FULLY EDITION");
            string zeno = "Zenoos>";
        whil:
            Console.Write(zeno);
            string rea = Console.ReadLine();
            string[] reaindex = new string[rea.Length];
            //-проверки
            if (rea == "bios")
            {
                Console.WriteLine("bios this");//bios iitation
                goto whil;
            }
            else
            {
                reaindex = rea.Split(' ');
                if (reaindex[0] == "notepad")
                {
                    if (reaindex.Length == 1)
                    {
                        Console.WriteLine("Welcom to notepad!");
                        Console.WriteLine("USE:");
                        Console.WriteLine("notepad open {file_name}");
                        goto whil;
                    } else if (reaindex.Length == 3)
                    {
                        if (reaindex[1] == "open")
                        {
                            string fileContent = File.ReadAllText(reaindex[2]);
                            StringBuilder ciii = new StringBuilder(fileContent);
                            //време
                            Console.WriteLine(ciii.ToString());
                            Console.Write("Zenoos/notepat(" + reaindex[2] + ")<");
                            rea = Console.ReadLine();
                            if (rea.Substring(0, 7) == "notepad")
                            {
                            arg:
                                if (rea.Substring(0, 10) == "notepad + ")
                                {
                                    ciii.Append("\n");
                                    ciii.Append(rea.Substring(11));
                                    goto arg;
                                } else if (rea.Length == 9)
                                {
                                    if (rea.Substring(0, 10) == "notepad - ")
                                    {
                                        string[] not = new string[ciii.Length];
                                        not = ciii.ToString().Split('\n');
                                        ciii.Remove(ciii.Length - not[ciii.Length].Length, ciii.Length);
                                        Console.WriteLine(ciii.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}