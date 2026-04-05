using System;
using System.Collections.Generic;
using System.Text;

namespace TpModul6
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null dan maksimal 100 karakter");
            }

            this.title = title;

            Random random = new Random();
            this.id = random.Next(10000, 99999);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentOutOfRangeException("Penambahan maksimal 10000000 per panggilan");
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Jumlah Play Count melebihi batas maksimal integer");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video   : " + this.id);
            Console.WriteLine("Judul      : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
        }
    }
}
