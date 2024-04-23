using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vytvoříme nový list pro ukládání slov
            List<string> slova = new List<string>();
            int currentIndex = -1;

            Console.WriteLine("Zadejte 'pridat:' pokud chcete přidat slovo, 'zpet' pokud se chcete vrátit o slovo zpět a 'vpred' pokud se chcete přejít o slovo dopředu.");

            while (true)
            {
                Console.WriteLine("Zadejte příkaz:");
                string command = Console.ReadLine();

                // Zkontrolujeme, zda příkaz začíná "Pridat:"
                if (command.StartsWith("pridat:"))
                {
                    // Získáme slovo napsané po dvojtečce a přidáme do seznamu
                    string noveSlovo = command.Substring(7).Trim();

                    slova.Add(noveSlovo);

                    // Aktualizujeme aktuální index na poslední přidané slovo
                    currentIndex = slova.Count - 1;

                    Console.WriteLine($"Přidáno slovo: {noveSlovo}");
                }
                // když nenapíšeme příkaz "pridat:" tak se provede tohle
                else if (command.Equals("zpet", StringComparison.OrdinalIgnoreCase))
                {
                    if (currentIndex > 0)
                    {
                        currentIndex--;
                        //vypíše aktuální slovo
                        Console.WriteLine($"Aktuální slovo: {slova[currentIndex]}");
                    }
                    // Pokud jsme na prvním slovu, zůstáváme tam a příkaz zpet se neprovede
                    else if (currentIndex == 0)
                    {   
                        //zobrazí se tento příkaz
                        Console.WriteLine($"Již jste na prvním slovu: {slova[currentIndex]}");
                    }
                    else
                    {   //vypíše se pouze když napíšem příkaz zpet a jěště jsme nepřidali slovo
                        Console.WriteLine("Nejsou žádná přidaná slova.");
                    }
                }
                        //provede se pouze pokud jsme se vrátili o slovo zpátky a posune nás o slovo dopředu
                else if (command.Equals("vpred", StringComparison.OrdinalIgnoreCase))
                {
                    // Pokud nejsme na posledním slovu tak můžeme jít dál
                    if (currentIndex < slova.Count - 1)
                    {
                        currentIndex++;
                        //vypíše aktuální slovo
                        Console.WriteLine($"Aktuální slovo: {slova[currentIndex]}");
                    }
                    // Pokud jsme na posledním slovu, zůstaneme tam
                    else if (currentIndex == slova.Count - 1)
                    {
                        //vypíše se když dáme příkaz vpred a jsme na posledním slovu
                        Console.WriteLine($"Již jste na posledním slovu: {slova[currentIndex]}");
                    }
                    else
                    {
                        //vypíše se když napíšeme příkaz vpred a nemáme přidané žádné slovo
                        Console.WriteLine("Nejsou žádná přidaná slova.");
                    }
                }
                else
                {
                    //vypíše se když zadaný příkaz neni správný
                    Console.WriteLine("Neznámý příkaz.");
                }
            }
        }
    }
}
