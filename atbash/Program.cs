using System;
using System.Collections.Generic;
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
    }
}
