using System;
public class PhotoBook
{
    protected int numPages;
 
    public PhotoBook()
    {
        numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }
 
    public int GetNumberPages()
    {
        return numPages;
    }
}
public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook()
    {
        numPages = 64;
    }
}
public class PhotoBookTest
{
    public static void Main()
    {
        PhotoBook a = new PhotoBook();
        Console.WriteLine("Album1 pages is :");
        Console.WriteLine(a.GetNumberPages());
 
        PhotoBook c = new PhotoBook(24);
        Console.WriteLine("Album2 PAges is :");
        Console.WriteLine(c.GetNumberPages());
 
        BigPhotoBook b = new BigPhotoBook();
        Console.WriteLine("Big Photobook Pages is :");
        Console.WriteLine(b.GetNumberPages());
    }
}