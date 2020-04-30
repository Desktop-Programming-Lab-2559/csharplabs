using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab12_3
{  //1.	Реалізувати клас, що представляє одновимірний масив і містить опис індексатора для доступу до елементів.
    //Передбачаити методи введення/виведення, знаходження максимального та мінімального елементів
    class Array
    {
        private double[] arr;
        public Array(params double[] arr)
        {
            this.arr = new double[arr.Length];
            arr.CopyTo(this.arr, 0);

        }
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }
        public double Max()
        {
              return arr.Max();
        }
        public double Min()
        {
              return arr.Min();
            
        }


        public double this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Length)
                    return arr[i];
                else
                    return 0;
            }
            set
            {
                if (i >= 0 && i < this.Length )
                    arr[i] = value;
                else
                    throw new Exception("Out of range");
            }
        }
        public override string ToString()
        {
            return string.Join(",", arr); ;
        }
    }
        



    }
