using System;
using Tesseract;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var testImagePath = @"C:\Kofax\Optical CharacterRecognition -OCR - Tesseract\SampleProgram\SampleImage\TestImage.png";
            var dataPath = @"C:\Kofax\Optical CharacterRecognition -OCR - Tesseract\SampleProgram\SampleImage\output.txt";

            try
            {  
                using (var tEngine = new TesseractEngine(dataPath, "eng", EngineMode.Default)) //creating the tesseract OCR engine with English as the language
                {
                    using (var img = Pix.LoadFromFile(testImagePath)) // Load of the image file from the Pix object which is a wrapper for Leptonica PIX structure
                    {                        
                        using (var page = tEngine.Process(img)) //process the specified image
                        {
                            var text = page.GetText(); //Gets the image's content as plain text.
                            Console.WriteLine(text); //display the text
                            Console.WriteLine(page.GetMeanConfidence()); //Get's the mean confidence that as a percentage of the recognized text.
                            Console.ReadKey();                            
                        }
                    }
                }
            }
            catch (Exception e)
            {                
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}
