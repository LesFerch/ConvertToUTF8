using System;
using System.IO;
using System.Text;
using UtfUnknown;

namespace ConvertToUTF8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Convert files to UTF-8");
                Console.WriteLine("Usage: ConvertToUTF8 <file1> <file2> ...");
                return;
            }

            Console.WriteLine("sep=;"); // For Excel

            foreach (string path in args)
            {
                try
                {
                    Console.Write($"\"{path}\";");

                    // Detect encoding using UtfUnknown
                    Encoding detectedEncoding = DetectEncoding(path);

                    // Read the file using detected encoding and convert to UTF-8
                    bool BOM = false;
                    string readText = File.ReadAllText(path, detectedEncoding);
                    File.WriteAllText(path, readText, new UTF8Encoding(BOM));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error converting file {path}: {ex.Message}");
                }
            }
        }

        static Encoding DetectEncoding(string filePath)
        {
            try
            {
                DetectionResult result = CharsetDetector.DetectFromFile(filePath);
                DetectionDetail resultDetected = result.Detected;
                string encodingName = resultDetected.EncodingName;
                Encoding encoding = resultDetected.Encoding;
                Console.WriteLine(encodingName);
                return encoding;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error detecting encoding for file {filePath}: {ex.Message}");
            }
        }
    }
}