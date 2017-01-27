using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SortingArray = new int[] { 1, 2454, 34634, 23323, 15787, 22, 754, 125 };
            Console.WriteLine(BetterGnomeSortIntegers(SortingArray, true));
            if (LinearSearchIntegers(SortingArray, 20) == -1)
            {
                Console.WriteLine("WOOHOO");
            }
        }
        public static Array BetterGnomeSortStrings(string[] ToSort, bool asc)
        {
            if (asc)
            {
                for (int pos = 0; pos < ToSort.Length; pos++)
                {
                    ToSort = (GnomeSortStrings(ToSort, pos, asc) as string[]);
                };
            }
            else
            {
                for (int pos = ToSort.Length - 1; pos >= 0; pos--)
                {
                    ToSort = (GnomeSortStrings(ToSort, pos, asc) as string[]);
                };
            };
            return ToSort;
        }
        public static Array GnomeSortStrings(string[] NeedSort, int Position, bool Asc)
        {
            if (Asc)
            {
                while (Position > 0 && string.Compare(NeedSort[Position - 1], NeedSort[Position]) == 1)
                {
                    string HoldingVariable = NeedSort[Position - 1];
                    NeedSort[Position - 1] = NeedSort[Position];
                    NeedSort[Position] = HoldingVariable;
                    Position--;
                }
            }   
            else
            {
                while (Position > 0 && string.Compare(NeedSort[Position - 1], NeedSort[Position]) == -1)
                {
                    string HoldingVariable = NeedSort[Position - 1];
                    NeedSort[Position - 1] = NeedSort[Position];
                    NeedSort[Position] = HoldingVariable;
                    Position++;
                }
            }

            return NeedSort;
        }
        public static Array BetterGnomeSortIntegers(int[] ToSort, bool asc)
        {
            if (asc)
            {
                for (int pos = 0; pos < ToSort.Length; pos++)
                {
                    ToSort = (GnomeSortIntegers(ToSort, pos, asc) as int[]);
                };
            }
            else
            {
                for (int pos = ToSort.Length - 1; pos >= 0; pos--)
                {
                    ToSort = (GnomeSortIntegers(ToSort, pos, asc) as int[]);
                };
            };
            return ToSort;
        }
        public static Array GnomeSortIntegers(int[] NeedSort, int Position, bool Asc)
        {
            if (Asc)
            {
                while (Position > 0 && NeedSort[Position - 1] > NeedSort[Position])
                {
                    int HoldingVariable = NeedSort[Position - 1];
                    NeedSort[Position - 1] = NeedSort[Position];
                    NeedSort[Position] = HoldingVariable;
                    Position--;
                }
            }
            else
            {
                while (Position > 0 && NeedSort[Position - 1] < NeedSort[Position])
                {
                    int HoldingVariable = NeedSort[Position - 1];
                    NeedSort[Position - 1] = NeedSort[Position];
                    NeedSort[Position] = HoldingVariable;
                    Position++;
                }
            }

            return NeedSort;
        }
        public static int LinearSearchStrings(string[] list, string ToFind)
        {
            bool Found = false;
            int currentElement = 0;
            do
            {
                if (list[currentElement] == ToFind)
                {
                    Found = true;
                }
                else
                {
                    currentElement = currentElement + 1;
                }
            } while (!(Found == true || currentElement > list.Length - 1));

            if (Found == true)
            {
                return currentElement;
            }
            else
            {
                ///If it is not found
                return -1;
            }
        }
        public static int LinearSearchIntegers(int[] list, int ToFind)
        {
            bool Found = false;
            int currentElement = 0;
            do
            {
                if (list[currentElement] == ToFind)
                {
                    Found = true;
                }
                else
                {
                    currentElement = currentElement + 1;
                }
            } while (!(Found == true || currentElement > list.Length - 1));

            if (Found == true)
            {
                return currentElement;
            }
            else
            {
                ///If it is not found
                return -1;
            }
        }
    }
}
