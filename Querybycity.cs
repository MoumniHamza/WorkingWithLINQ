using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{



    class DataTransformations
    {
        static void Main()
        {
            string sentence = "Hello my name is hamza and I am 24";
            string[] words = sentence.Split(' ');

            var result = from w in words
                         group w.ToUpper() by w.Length into gr
                         orderby gr.Key
                         select new { length = gr.Key, words = gr };
            foreach(var results in result)
            {
                Console.WriteLine("Words of length {0} : ", results.length);
                     foreach(string finalresults in results.words)
                                  Console.WriteLine(finalresults);
              

            }

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
                         
        }

    }

}

