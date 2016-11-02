using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] arraytoCheck = new int[size, size];
            Console.WriteLine(CheckDiagArray(size, arraytoCheck));

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    inputDataToArray(row, column, arraytoCheck);
                }
            }

            Console.WriteLine(CheckDiagArray(size, arraytoCheck));
        }

        private static void inputDataToArray(int row, int column,int[,] array)
        {
            array[row, column] = int.Parse(Console.ReadLine());
        }



        private static bool CheckDiagArray(int size, int[,] arraytoCheck)
        {
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    if (!(GetDiagEquals(arraytoCheck, row, column))) return false;
                }
            }
            return true;
        }

        static bool GetDiagEquals(int[,] array, int rowToCheck, int columnToCheck)
        {
            if (array[rowToCheck, columnToCheck] == array[columnToCheck, rowToCheck])
            {
                return true;
            }
            else return false;
        }



    }
}
