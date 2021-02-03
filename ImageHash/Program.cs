using System;

namespace ImageHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string image1 = @"C:\Users\admin\Downloads\EtCpGN9U0AEl8Zf.jpg";
            string image2 = @"C:\Users\admin\Downloads\EtCpGN9U0AEl8Zf (1).jpg";


            var hash1 = new SimilarPhoto(image1).GetHash();
            var hash2 = new SimilarPhoto(image2).GetHash();

            var comp = SimilarPhoto.CalcSimilarDegree(hash1, hash2);


            Console.WriteLine($"差異度:{comp}");
        }
    }
}
