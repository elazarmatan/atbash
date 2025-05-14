using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace atbash
{
    internal class Program
    {

        static string dencription(string txtencription)
        {
            char oop = ' ';
            string oyu = " ";
            string finel = "";
            Dictionary<string , string> dictLitters = new Dictionary<string, string> { { "a", "z" }, { "b", "y" }, { "c", "x" }, { "d", "w" }, { "e", "v" }, { "f", "u" }, { "g", "t" }, { "h", "s" },{ "i","r"},{ "j","q"}, { "k", "p" }, { "l", "o" }, { "m", "n" }, { "n", "m" }, { "o", "l" }, { "p", "k" }, { "q", "j" }, { "r", "i" }, { "s", "h" }, { "t", "g" },{"u","f" },{"v","e" },{"w","d" },{"x","c"},{"y","b" },{"z","a" } };
            foreach (char leeter in txtencription) 
            {
                if (char.IsLetter(leeter)) 
                {    
                        oop = char.ToLower(leeter);
                    
                    oyu = oop + "";
                    finel += dictLitters[oyu];
                }
                else { finel += leeter + ""; }
            }
            return finel;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(manager ());



        }

        static int dangerousWords(string mesage, string[] danWor)
        {

           
            int counter = 0;
            List <string> listMesage = new List <string>(mesage.Split (' '));
            foreach (string word in listMesage)
            {
                for (int i =0;i < danWor.Length; i++)
                {
                    if (word == danWor[i])
                    {
                        counter++;
                    }
                }
            }
            return counter;

 


            
        }

        static string  Warning(string mesage, int points) 
        {
            string finalMesagge = "";
            string warning = "";
            if (points >= 1 && points <= 5)
            {
                warning = "WARNING ";
            }
            else if (points >= 6 && points <= 10)
            {
                warning = "DANGER ";
            }
            else if (points >= 11)
            {
                warning = "ULTRA ALERT ";
            }
            finalMesagge += mesage += warning += points + "";

            return finalMesagge;
        }

        static string manager()
        {
            string o = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.";

            string[] u = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            string g = dencription(o);
            int y = dangerousWords(g,u);
            string t = Warning (g,y);
            return t;
        }

           
    }
}
