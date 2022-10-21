using System;
using System.Collections.Generic;

namespace _03._Songs
{
    public class Song
    {
        public Song(string typelist, string name, string time)
        {
            TypeList = typelist;
            Name = name;    
            Time = time;    
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for(int i = 0; i < numSongs; i++)
            {
                string[] data  = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];  
                string time = data[2];
                Song song = new Song(type,name,time);
                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if(typeList == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(s => s.TypeList == typeList);
                foreach(Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }

            
        }
    }
}
