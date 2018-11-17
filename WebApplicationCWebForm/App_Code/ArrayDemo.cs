using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * Array : fix lenght
 * 
 * Single-dimensional Arrays
 * Multidimensional Arrays : string[,]
 * Jagged Arrays: string[][]
 * Mixed Arrays: included Multi-dimensional and Jagged Arrays
 * .Length : return a 32-bit integer total number of items in all the dimension of an Array
 * .Rank : return the number of dimensions of an Array
 * .IsReadOnly
 * .LongLength : return a 64-bit integer total number of items in all the dimension of an Array
 * .IsFixedSize
 * 
 * Array Class:
 * Array.CreatInstance
 * .SetValue
 * .BinarySearch (need do Sort first before you can do BinarySearch)
 * .Sort
 * 
 */
namespace WebApplicationCWebForm.App_Code
{
    public class ArrayDemo
    {
        public string output;

        public ArrayDemo()
        {
            
            int[] intArray;
            intArray = new int[5];

            double[] doubleArray = new double[5];
            char[] charArray = new char[5];
            bool[] boolArray = new bool[2];
            string[] stringArray = new string[10];

            int[] staticIntArray1 = new int[3] { 1, 3, 5 };

            int[] staticIntArray = new int[3];
            staticIntArray[0] = 11;
            staticIntArray[1] = 13;
            staticIntArray[2] = 15;

            output += "\r\nSingle Array:";
            foreach (int i in staticIntArray1) { output += "\r\n [" + i + "] "; }

            for (int i = 0; i < staticIntArray.Length; i++)
            {
                output += "\r\n staticIntArray["+i+"] = " + staticIntArray[i];
            }

            string[][] stringJaggedArray = new string[2][];

            int[][] intJaggedArray = new int[3][];
            intJaggedArray[0] = new int[2] { 2, 12 };
            intJaggedArray[1] = new int[3] { 3, 13, 23 };
            intJaggedArray[2] = new int[4];
            output += "\r\n";
            output += "\r\nJagged Array:";
            for (int i =0; i<intJaggedArray.Length; i++)
            {
                for(int j =0; j<intJaggedArray[i].Length;j++)
                {
                    output += "\r\nintJaggedArray[" + i + "][" + j + "] = " + intJaggedArray[i][j];
                }
            }


            int[,] intMultiDimensionalArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] stringNultiDimemsionalArray = new string[2, 2] { {"Sophy", "Yang"} ,{"Tammy", "Chen"}};
            string[,] names  =  { { "La", "Moor" }, { "Esma", "Lee" } };
            string[,] names1 = new string[,] { { "David", "Su" }, { "Larry", "Ma" } };

            output += "\r\n";
            output += "\r\nMulti-Dimensional Array:";
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 2 ; j++)
                {
                    output += "\r\nintMultiDimensionalArray[" + i + "][" + j + "] = " + intMultiDimensionalArray[i, j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output += "\r\nNames[" + i + "][" + j + "] = " + names[i, j];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    output += "\r\nNames1[" + i + "][" + j + "] = " + names1[i, j];
                }
            }

            Array strArray = Array.CreateInstance(typeof(string), 3);
            strArray.SetValue("Sophy", 0);
            strArray.SetValue("Tammy", 2);
            strArray.SetValue("Michael", 1);
            output += "\r\nArray Class";
            foreach (string s in strArray) { output += "\r\n" + s; }
            object name = "Sophy";
            int nameIndex = Array.BinarySearch(strArray, name);
            if (nameIndex  >=0)
            {
                output += "\r\nFind the item in position " + nameIndex ;
            } else
            {
                output += "\r\nItem not found";
            }
            Array.Sort(strArray);
            output += "\r\nArray after sort";
            foreach (string s in strArray) { output += "\r\n" + s; }
            nameIndex = Array.BinarySearch(strArray, name);
            if (nameIndex >= 0)
            {
                output += "\r\nFind the item in position " + nameIndex;
            }
            else
            {
                output += "\r\nItem not found";
            }

            Array intArray3D = Array.CreateInstance(typeof(Int32), 3, 2, 1);


        }

    }
}
