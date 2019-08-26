# Optical-character-recognition-OCR-
Optical character recognition (OCR) is a process for extracting textual data from an image. Apart from that, it finds it's   applicability in the field of pattern recognition, artificial intelligence ,computer vision etc. tesseract-ocr is high   accuracy of character recognition and contains prepared trained data sets for 39 languages.


Environment Setup

1/ Install-Package Tesseract -Version 2.4.1.0


Language Files

1) Download your language files from https://github.com/tesseract-ocr/tessdata/tree/3.04.00

For example, for eng, download all files with eng prefix.

2) Put them into tessdata directory inside of some folder. Add this folder into System Path variables as TESSDATA_PREFIX.

Result will be System env var: TESSDATA_PREFIX=D:/Java/OCR And OCR folder has tessdata with languages files.


At first we are creating a new instance of TesseractEngine with Default engineMode and English as the language. Next we 

are loading the image file by using the Pix object which is a wrapper for Leptonica PIX structure.The tEngine.Process(img) 

accepts the image as an input, process the image and returns a Page. Once we get the text from the image, we displays the 

same on the console. Also for getting the confidence, we are using GetMeanConfidence() method of Page class.


References
 https://github.com/charlesw/tesseract
