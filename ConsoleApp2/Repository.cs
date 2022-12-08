using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Repository
    {
        string[] data = {"Katya", "Ilias", "Tom", "Chan", "Li mi Ho"};

        public async IAsyncEnumerable<string> GetData()
        {
            for (int i = 0; i < data.Length; i++)
            {

                Console.WriteLine($"Element: {i}");
                await Task.Delay(500);
                yield return data[i];
            }
        }
    }
}
