﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Project
{

    class Class1
    {
        public static string[] SplitString(string s)
        {
            string[] array = new string[6];
            array = s.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (isServiceWord(array[i]))
                    array[i] = " ";
            }
            return array;
        }

        public static string SearchInBase(string str)
        {
            using (StreamReader reader = new StreamReader(@"C:\Documents and Settings\Admin\Мои документы\Visual Studio 2010\Projects\Project\Project\TestFile.txt"))
            {
                string line;//look for adress:district-street-house
                while ((line = reader.ReadLine()) != null)
                {
                    string[] array = SplitString(line);
                    if (RightAdress(array[2], array[1], int.Parse(array[3]), SplitString(str)))
                        return line;
                }
                return " ";
            }
        }
        /**
        * function shows if this string is integer number or not
        */
        public static bool isNum(string str)
        {
            int Num;
            bool checker = int.TryParse(str, out Num);
            return checker;
        }

        public static bool RightAdress(string street, string district, int house, string[] inputArray)
        {
            bool checker1 = false;
            bool checker2 = false;
            bool checker3 = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (street == inputArray[i])
                    checker1 = true;
                if (district == inputArray[i])
                    checker2 = true;
                if (isNum(inputArray[i]))
                {
                    if (house == int.Parse(inputArray[i]))
                        checker3 = true;
                }
            }
            if (checker1 && checker2 && checker3)
                return true;
            checker1 = false;//look for street and house
            checker2 = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (street == inputArray[i])
                    checker1 = true;
                if (isNum(inputArray[i]))
                {
                    if (house == int.Parse(inputArray[i]))
                        checker2 = true;
                }
            }
            if (checker1 && checker2)
                return true;
            for (int i = 0; i < inputArray.Length; i++)//look for street
            {
                if (street == inputArray[i] && ArrayHasNoNumber(inputArray))
                    return true;
            }
            return false;
        }

        public static bool ArrayHasNoNumber(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (isNum(array[i]))
                    return false;
            }
            return true;
        }

        public static bool isServiceWord(string s)
        {
            return (s.Equals("улица") || s.Equals("ул")
                 || s.Equals("набережная") || s.Equals("наб")
                 || s.Equals("проспект") || s.Equals("просп") || s.Equals("пр-т")
                 || s.Equals("переулок") || s.Equals("пер")
                 || s.Equals("проезд") || s.Equals("пр")
                 || s.Equals("площадь") || s.Equals("пл")
                 || s.Equals("линия") || s.Equals("лин")
                 || s.Equals("аллея")
                 || s.Equals("шоссе") || s.Equals("ш")
                 || s.Equals("дорога") || s.Equals("дор")
                 || s.Equals("бульвар") || s.Equals("бул"));
        }

        public static string GetLongitude(string input)
        {
            string[] array = SplitString(SearchInBase(input));
            return array[4];
        }

        public static string GetLatitude(string input)
        {
            string[] array = SplitString(SearchInBase(input));
            return array[5];
        }

        static void Main(string[] args)
        {
            string input;
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Documents and Settings\Admin\Мои документы\Visual Studio 2010\Projects\Project\Project\InputFile.txt"))
                {
                    input = reader.ReadLine();
                    input = input.ToLower().Replace('.', ' ').Replace(',', ' ');

                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Documents and Settings\Admin\Мои документы\Visual Studio 2010\Projects\Project\Project\OutputFile.txt"))
                {
                    file.WriteLine(GetLongitude(input));
                    file.Write(GetLatitude(input));

                }
            }
            catch (SystemException)
            {

            }
        }
    }
}
