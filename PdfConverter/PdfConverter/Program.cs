using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;



namespace PdfConverter
{
    class Program
    {
        public static string path = @"C:\Users\wade2\Desktop\School\Algorithms\Lectures\L1.pdf";
        public static string Convert(string pdfPath)
        {
            PDDocument document = PDDocument.load(pdfPath);
            PDFTextStripper stripper = new PDFTextStripper();
            return stripper.getText(document);
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(Convert(path));
            Console.ReadKey();
        }
    }
}
