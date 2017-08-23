using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Logic
    {
        private int size;
        private string log;
        private int[,] box;

        public Logic(int size)
        {
            this.size = size;
            box = new int[size, size];
            Generate();
        }

        private void Generate()
        {
            Log("Matrix generated.");

            for(int x=0, z=1; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    box[x, y] = z++;
                }
            }
        }

        public void Diagonal()
        {
            Log("Matrix diagonal numbers.");

            for (int i = 0; i < size; i++) Console.WriteLine(box[i, i]);
        }

        public void Negative()
        {
            Log("Matrix negative numbers.");

            int count = 0;

            for(int x=0; x < size; x++)
            {
                for (int y=0; y < size; y++)
                {
                    if(box[x, y] < 0) count++;
                }
            }

            Console.WriteLine(count);
        }

        public void Show()
        {            
            Log("Matrix display.");

            for(int x=0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    log += $"{box[x, y]}";
                }

                Console.WriteLine(log);
                log = null;
            }
        }

        private void Log(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("==================");
        }   
    }
}
