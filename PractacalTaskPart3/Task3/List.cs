using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PractacalTaskPart3.Task3
{
    class List
    {
        private static List<string> list;
        private static int itemsCount = 100;

        public static void Menu()
        {
            list = ListCreater(itemsCount);
            Console.WriteLine("List Count before organazing - " + list.Count);
            ListOrganizer(list);
            Console.WriteLine("List Count after organazing - " + list.Count);
            Console.WriteLine("Enter the number of page to view it, or any symbol to exit");
            int input = Checker();
            DisplayPage(input);
        }

        static private int Checker()
        {
            string value;
            int result = 0;
            bool temp = true;

            while (temp)
            {
                try
                {
                    value = Console.ReadLine();
                    result = Convert.ToInt32(value);
                    temp = false;
                }
                catch
                {
                    Environment.Exit(0);
                }
            }
            return result;
        }

        private static List<string> ListCreater(int Count)
        {
            var list = new List<string> { };
            for (int i = 0; i < Count; i++)
            {
                list.Add(RandomString(4));
            }
            return list;
        }

        private static List<string> ListOrganizer(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (Equals(list[i], list[j]))
                    {
                        list.RemoveAt(i);
                    }
                }
                if (list[i].StartsWith("Z"))
                {
                    list.RemoveAt(i);
                }
            }
            list.Sort();
            list.Reverse();
            return list;
        }

        private static void DisplayPage(int PageNumber)
        {
            Console.Clear();
            const int pageItems = 10;
            var page = new List<List<string>> { };
            int temp = pageItems;

            for (int i = 0; i < itemsCount; i = i + pageItems)
            {
                var tempList = new List<string> { };
                for (int j = i; j < temp; j++)
                {
                    if (j < list.Count)
                    {
                        tempList.Add(list[j]);
                    }
                }
                page.Add(tempList);
                temp = temp + pageItems;
            } 
            
            try
            {
                Console.WriteLine("This is {0} page", PageNumber);
                foreach (var item in page[PageNumber - 1])
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("Enter the correct page Number!");
                PageNumber = Checker();
                DisplayPage(PageNumber);
            }
            Console.WriteLine("To change the page enter a number of it, to exit just enter another symbol ");
            int input = Checker();
            DisplayPage(input);
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

    }
}
