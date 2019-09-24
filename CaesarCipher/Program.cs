using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i]; //wyciagniecie literki z tablicy znakow
                letter = (char)(letter + shift); // literka + przesuniecie
                if (letter > 'z')
                {
                    letter = (char)(letter - 26); // przesuniecie po kodzie ascii jezeli jest dalej niz "z" to cofa
                }
                else if (letter < 'a') // przesuniecie po kodzie ascii, jezeli jest mniej, niz "a" to przesuwa do przodu
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer); //zwraca nowy zaszyfrowany 
        }

        static void Main()
        {
            string a = "damianobajtek";
            string b = Caesar(a, 3); // Ok
            string c = Caesar(b, -8); // Ok

            string d = Caesar(a, 2); // Ok
            string e = Caesar(d, -5); // Ok

            string f = "szyfrcezara";
            string g = Caesar(f, -4); // Ok

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
