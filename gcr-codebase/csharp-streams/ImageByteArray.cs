using System;
using System.IO;

class ImageByteArray
{
    static void Main()
    {
        Console.Write("Enter source image path: ");
        string sourceImage = Console.ReadLine();

        Console.Write("Enter destination image path: ");
        string destImage = Console.ReadLine();

        try
        {
            byte[] imageBytes;

            // Read image into byte array using MemoryStream
            using (FileStream fs = new FileStream(sourceImage, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    imageBytes = ms.ToArray();
                }
            }

            // Write byte array back to image file
            File.WriteAllBytes(destImage, imageBytes);

            Console.WriteLine("Image converted and saved successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("IO Error: " + e.Message);
        }
    }
}
