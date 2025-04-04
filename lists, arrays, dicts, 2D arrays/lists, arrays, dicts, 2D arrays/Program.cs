using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    internal class Program
    {
        static void PrintList(List<string> stringlist)
        {
            foreach (string name in stringlist)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            int[] numberArray = new int[10];
            int[] numberArray2 = { 1, 2, 7, 8, 77 };
            numberArray[7] = 22;
            numberArray[6] = 22;
            numberArray[5] = 22;
            numberArray[4] = 22;
            //numberArray[10] = 22; out of bounds

            int[,] array2D1 = new int[4, 7];
            int[,] array2D2 = { { 1, 4, 7 }, { 14, 17, 18 } };
            array2D1.GetLength(1);
            
            for(int i = 0; i < numberArray.GetLength(0); i++)
            {
                DownloadStringCompletedEventHandler ReferenceEquals;
            }
            //                          kapacita     jednotlive prvky
            List<int> list = new List<int>(10) { 777, 987, 1365, 2424 };
            list[0] = 10;
            list[1] = 10;
            list[2] = 10;
            list[3] = 10;
            list.Add(10); //pridava vzdy nakonec
            list.Insert(0, 10);//pridaa na urcitem miste
            list.Remove(10);//odebira prvni
            list.RemoveAt(0);//odevira na urcitem miste
            list.RemoveAll(x => x > 5);
            //list.RemoveRange(0, 10);
            list.AddRange(numberArray);
            list.ForEach(x => { });
            list.Find(x => x > 5);//vrati pozici

            Dictionary<int, string> slovnik1 = new Dictionary<int, string>();
            slovnik1[1] = "dawg";
            slovnik1[2] = "mozes mi skocit na kokoot";
            slovnik1[3] = "das ist klar fantazie";
            Dictionary<int, string[]> slovnik2 = new Dictionary<int, string[]>();
            List<string> list2 = new List<string>() { "boom", "boom", "boom", "boom", "boom"};
            slovnik2[1] = list2.ToArray();
            foreach (KeyValuePair<int, string[]> kvp in slovnik2)
            {
                Console.WriteLine(kvp.Key + "->" + kvp.Value);
            }
            //Zaklady
            List<string> mylist = new List<string>();
            mylist.Add("Škoda");
            mylist.Add("Lada");
            mylist.Add("Koenigsegg");
            mylist.Add("Audi");
            mylist.Add("McMurtry");

            PrintList(mylist);
            Console.WriteLine();
            mylist.Remove("Lada");
            PrintList(mylist);
            mylist.RemoveAt(2);
            Console.WriteLine();
            PrintList(mylist);
            while (true)
            {
                Console.WriteLine(":");
                string userInput = Console.ReadLine();
                if (/*v listu exituje hodnota exsistuje automobilka na velky k*/mylist.Exists(carMaker => carMaker.StartsWith(userInput)))
                {
                    Console.WriteLine("V listu je automobilka na " + userInput);
                    break;
                }
                else
                {
                    Console.WriteLine("v listu neni automobilka na " + userInput);
                }
            }


            List<string> mylist1 = new List<string>();
            mylist.Add("chicken wings");
            mylist.Add("watermelon");
            mylist.Add("banana");
            mylist.Add("chicken strips");
            mylist.Add("watermelonbananachickenwings");
            while (true)
            {
                Console.WriteLine("chces pridat ci odebrat jidlo?  (add/rem)");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "add")
                {
                    while (true)
                    {
                        Console.WriteLine("kam a co chces pridat? (hodnoty rozdel mezerou): ");
                        string userInput = Console.ReadLine();
                        userInput.Split(' ');
                        if (mylist1.Contains(Convert.ToString(userInput[1])))
                        {

                            Console.WriteLine("list už obsahuje tuto položku");

                        }
                        else
                        {
                            mylist1.Insert(Convert.ToInt32(userInput[0]), Convert.ToString(userInput[1]));
                        }


                        break;
                    }


                }
                else if (userAnswer == "rem")
                {
                    Console.WriteLine("co a kde chces smazat?:(hodnoty rozdel mezerou) ");
                    string userInput = Console.ReadLine();
                    mylist.Remove(userInput);
                    break;
                }



            }
            PrintList(mylist1);


            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict["Wasser"] = "Voda";
            myDict["Bagger"] = "Bagr";
            myDict["Naturwissenschaft"] = "Věda";
            myDict["Bundespräsidenttischwahlwiederholungverschiebung"] = "Voda";

            foreach (KeyValuePair<string, string> translation in myDict)
            {
                string germanWord = translation.Key;
                string czechWord = translation.Value;
                Console.WriteLine("překlad slova" + germanWord + "do češtiny je " + czechWord);
            }

            while (true)
            {
                Console.WriteLine("key:");
                string userInput = Console.ReadLine();
                if (/*ve slovníku exituje hodnota */myDict.ContainsKey(userInput))
                {
                    Console.WriteLine("V listu je automobilka na " + userInput);
                    break;
                }
                else
                {
                    Console.WriteLine("v listu neni automobilka na " + userInput);
                }
            }

            Console.ReadKey();





        }
    }
}
