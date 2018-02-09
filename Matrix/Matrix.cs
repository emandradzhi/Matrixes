using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Matrix
{
    public class Matrix
    {
        private int size;
        private List<int[]> matrix;
        public Matrix(int size)
        {
            this.size = size;
            matrix = new List<int[]>(size);
        }

        public void PrintMatrix()
        {
            ReadData();
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        private void ReadData()
        {
            using (StreamReader sr = new StreamReader("Matrix.txt"))
             {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(null);
                    int size = line.Length - 1;
                    int[] row = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        row.SetValue(int.Parse(line[i]), i);
                    }
                    matrix.Add(row);
                }
            }
        }
        
    }
}
