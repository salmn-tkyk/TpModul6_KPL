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
            this.title = title;

            Random random = new Random();
            this.id = random.Next(10000, 99999);

            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video   : " + this.id);
            Console.WriteLine("Judul      : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
        }
    }
}
