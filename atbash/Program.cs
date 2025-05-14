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
        

        static void Main(string[] args) 
        { 
     
           

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
                warning = "WARNING";
            }
            else if (points >= 6 && points <= 10)
            {
                warning = "DANGER";
            }
            else if (points >= 11)
            {
                warning = "ULTRA ALERT";
            }
            finalMesagge += mesage += warning += points + "";

            return finalMesagge;
        }

           
    }
}
