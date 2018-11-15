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

        }

    }
}
