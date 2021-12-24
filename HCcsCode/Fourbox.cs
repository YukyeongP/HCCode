using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

// Fourbox problem

namespace HCcsCode
{
    public class Fourbox
    {
        private string boxPstr;

        // constructor
        public Fourbox(string boxPstr)
        {
            this.boxPstr = boxPstr;
        }

        public int Area()
        {
            var boxP = toBoxes(boxPstr); //
            var pt = new List<Tuple<int, int>>();

            for (var i = 0; i < 4; i++)
                for (int j = boxP[i, 0] + 1; j < boxP[i, 2] + 1; j++)
                    for (int k = boxP[i, 1] + 1; k < boxP[i, 3] + 1; k++)
                        pt.Add(new Tuple<int, int>(j, k));

            return pt.Distinct().Count();
        }

        private int[,] toBoxes(string s)
        {
            // put Exception Handling
            var exp = new int[,] { {0}, {0} };
            try
            {
                var strboxP = s.Split(' ')
                           .Where(x => !string.IsNullOrEmpty(x)).ToArray();

                var intBoxP = Array.ConvertAll(strboxP, int.Parse);
                var boxes = new int[4, 4];

                for (int i = 0; i < boxes.GetLength(0); i++)
                    for (int j = 0; j < boxes.GetLength(1); j++)
                        boxes[i, j] = intBoxP[i * 4 + j];

                return boxes;
            }
            catch when (s == null)
            {
                return exp;
            }

        }

    }

    class Program
    {
        static void Main1(string[] args)
        {
            var b1 = "0 0 200 200    0 0 200 200    0 0 200 200    0 0 200 200";
            var b2 = "1 2 4 4    2 3 5 7    3 1 6 5    7 3 8 6";
            var b3 = "";

            var box = new Fourbox(b1);
            //box.ToBoxes();
            //box.Area();

            Debug.Assert(box.Area() == 40000);
            box = new Fourbox(b2);
            Debug.Assert(box.Area() == 26);

            box = new Fourbox(b3);

        }
    }
}



