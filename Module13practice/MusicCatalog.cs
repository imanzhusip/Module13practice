using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13practice
{
    public class MusicCatalog
    {
        Hashtable catalog = new Hashtable();

        public void AddDisk(string diskTitle)
        {
            if (!catalog.ContainsKey(diskTitle))
            {
                catalog[diskTitle] = new Hashtable();
                Console.WriteLine($"Диск '{diskTitle}' добавлен в каталог.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskTitle}' уже существует в каталоге.");
            }
        }

        public void RemoveDisk(string diskTitle)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                catalog.Remove(diskTitle);
                Console.WriteLine($"Диск '{diskTitle}' удален из каталога.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskTitle}' не найден в каталоге.");
            }
        }

        public void AddSong(string diskTitle, string songTitle, string artist)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                Hashtable disk = (Hashtable)catalog[diskTitle];
                if (!disk.ContainsKey(songTitle))
                {
                    disk[songTitle] = artist;
                    Console.WriteLine($"Песня '{songTitle}' добавлена на диск '{diskTitle}'.");
                }
                else
                {
                    Console.WriteLine($"Песня '{songTitle}' уже существует на диске '{diskTitle}'.");
                }
            }
            else
            {
                Console.WriteLine($"Диск '{diskTitle}' не найден в каталоге.");
            }
        }

        public void RemoveSong(string diskTitle, string songTitle)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                Hashtable disk = (Hashtable)catalog[diskTitle];
                if (disk.ContainsKey(songTitle))
                {
                    disk.Remove(songTitle);
                    Console.WriteLine($"Песня '{songTitle}' удален из каталога '{diskTitle}'.");
                }
                else
                {
                    Console.WriteLine($"Песня '{songTitle}' не найден на диске '{diskTitle}'.");
                }
            }
            else
            {
                Console.WriteLine($"Диск '{diskTitle}' не найден в каталоге.");
            }
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Музыкальный каталог:");
            foreach (string diskTitle in catalog.Keys)
            {
                Console.WriteLine($"- Диск: {diskTitle}");
                Hashtable disk = (Hashtable)catalog[diskTitle];
                foreach (string songTitle in disk.Keys)
                {
                    string artist = (string)disk[songTitle];
                    Console.WriteLine($"  - Песня: {songTitle}, Автор: {artist}");
                }
            }
        }

        public void SearchByArtist(string artist)
        {
            Console.WriteLine($"Результаты поиска для исполнителя '{artist}':");
            foreach (string diskTitle in catalog.Keys)
            {
                Hashtable disk = (Hashtable)catalog[diskTitle];
                foreach (string songTitle in disk.Keys)
                {
                    string songArtist = (string)disk[songTitle];
                    if (songArtist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"- Диск: {diskTitle}, Песня: {songTitle}");
                    }
                }
            }
        }
    }
}
