using CreateZIPFile.Model;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateZIPFile.Entities
{
    public class Items
    {
        public Items() { }

        public void CreateAnItem()
        {
            Item item = new Item() { Id = 1, Name = "Computer", Description = "Nice Computer" };
        }

        public void CreateAZipFile(string sourceDirectory, string zipFilePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(sourceDirectory) && !string.IsNullOrEmpty(zipFilePath))
                {
                    ZipFile.CreateFromDirectory(sourceDirectory, zipFilePath);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
