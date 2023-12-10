using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13practice
{
    public class Program
    {
        static void Main()
        {
            MusicCatalog catalog = new MusicCatalog();
            // Добавление дисков и песен
            catalog.AddDisk("Диск");
            catalog.AddSong("Диск1", "Песня1", "Автор1");
            catalog.AddSong("Диск1", "Песня2", "Автор2");
            catalog.AddDisk("Диск2");
            catalog.AddSong("Диск2", "Песня3", "Автор1");
            catalog.AddSong("Диск2", "Песня4", "Автор3");
            // Вывод каталога
            catalog.DisplayCatalog();
            // Поиск по исполнителю
            catalog.SearchByArtist("Автор1");
            Console.ReadKey ();
        }
    }
}
