using System;
using System.Collections.Generic;
using System.Text;

namespace lab10_1
{
    class Text
    {
        private string text;
        public string Text1
        {
            get { return text; }

            set { text = value; }
           
        }
        private string theme;
        public string Theme
        {
            get { return theme; }

            set { theme = value; }
        }
        public Text(string enterUs,string enterUs2)
        {
            Text1 = enterUs;
            Theme = enterUs2;
        }

        public int cntOfLttrs()
        {
            return Text1.Length;
        }
        public int cntOfSpaces()
        {
            int count = 0;
            for(int i = 0; i < Text1.Length; i++)
            {
                if(Text1[i]==' ')
                {
                    count++;
                }
            }
            return count;
            
        }
        public string Replacelttrs(char from, char to)
        {
            return Text1.Replace(from, to);

        }
        public string DelWord (int index)
        {   
            string[] words = Text1.Split(' ');
            string[] result = new string [words.Length-1];
            string newText1 = " ";
            for (int i = 0; i < words.Length; i++)
            {

                if (i < index)
                {
                    result[i] = words[i];
                }
                else if (i > index)
                {
                    result[i - 1] = words[i];
                }
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                newText1 += result[i] + " ";

            }
            return newText1;
        }
        
        public override string ToString()
        {
            return $"{Text1},{Theme}";

        }
    }
}
