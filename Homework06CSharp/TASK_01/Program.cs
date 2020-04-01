using System;

namespace TASK_01
{

    public class PhotoAlbum
    {
        // Deafult constructor
        public PhotoAlbum()
        {

        }
        // Constructor with one parametar
        public PhotoAlbum(int yourNoPages)
        {
            numberOfPages = yourNoPages;
        }


        private int numberOfPages = 16;
        public void GetNumberOfPages()
        {
            Console.WriteLine($"It`s album with: {numberOfPages} pages.");
        }


    }

    // new Class
    public class BigPhotoAlbum
    {
        public BigPhotoAlbum()
        {

        }
        public int numberOfPages = 64;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TASK1 first album");

            PhotoAlbum MyFirstAlbum = new PhotoAlbum();
            MyFirstAlbum.GetNumberOfPages();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TASK1 second album");

            int ForB = 24;//Or any other number
            PhotoAlbum MySecondAlbum = new PhotoAlbum(ForB);
            MySecondAlbum.GetNumberOfPages();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("TASK1 third album");

            BigPhotoAlbum MyBigPhotoAlbum = new BigPhotoAlbum();
            Console.WriteLine($"It`s album with: {MyBigPhotoAlbum.numberOfPages} pages.");





            Console.ReadLine();
        }
    }
}