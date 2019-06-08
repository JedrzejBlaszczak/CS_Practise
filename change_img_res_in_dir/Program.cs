using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace CHaszownik7
{
    class Program
    {
        static void Main(string[] args)
        {
            int newWidth = 0;
            int newHeight = 0;
            string inputDir = "";
            string outputDir = "";
            foreach (string arg in args)
            {
                if (arg.StartsWith("-res="))
                {
                    string temp =  arg.Remove(0, 5);
                    string[] tempTab = temp.Split('x');
                    newWidth = Int32.Parse(tempTab[0]);
                    newHeight = Int32.Parse(tempTab[1]);
                }
                else if (arg.StartsWith("-inputdir="))
                {
                    inputDir = arg.Remove(0, 10);
                }
                else if (arg.StartsWith("-outputdir="))
                {
                    outputDir = arg.Remove(0, 11);
                }
            }

            if((newWidth == 0) || (newHeight == 0))
            {
                Environment.Exit(-1);
            }

            if(inputDir == "")
            {
                inputDir = System.IO.Directory.GetCurrentDirectory() + "\\" ;
            }

            if(outputDir == "")
            {
                outputDir = inputDir;
            }
            
            var files = Directory.GetFiles(inputDir, "*.*");

            List<string> imageFiles = new List<string>();
            foreach (string filename in files)
            {
                if (Regex.IsMatch(filename, @".jpg|.png|.bmp$"))
                {
                    imageFiles.Add(filename);
                }
            }

            foreach (string imageFile in imageFiles)
            {
                Bitmap originalImage = new Bitmap(imageFile);
                Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

                using (Graphics graphics = Graphics.FromImage(newImage))
                {
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                }

                string tempFilename = Path.GetFileName(imageFile);
                string newImagePath = outputDir + tempFilename;
                if (System.IO.File.Exists(newImagePath))
                {
                    string tempFilenameNoExt = Path.GetFileNameWithoutExtension(imageFile);
                    string tempExt = Path.GetExtension(imageFile);
                    for (int i=1; i<99; i++)
                    {
                        newImagePath = outputDir + tempFilenameNoExt + "_" + i.ToString() + tempExt;
                        if (!System.IO.File.Exists(newImagePath))
                        {
                            break;
                        }
                    }
                }
                newImage.Save(newImagePath);
            }
        }
    }
}
