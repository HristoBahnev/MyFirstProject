namespace Lecture7
{
    class FileReaderWithCleanup
    {
        public void ReadFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file at '{Path.GetFullPath(filePath)}' was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO Error for file '{Path.GetFullPath(filePath)}': {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Emtpy file path");
            }
        }

        public static void Main(string[] args)
        {

            FileReaderWithCleanup fileReader = new FileReaderWithCleanup();


            string currentDirectory = Directory.GetCurrentDirectory();
            string validFilePath = Path.Combine(currentDirectory, "testfile.txt");


            Console.WriteLine("Testing with a valid file path:");
            fileReader.ReadFile(validFilePath);

            Console.WriteLine("\nTesting with an invalid file path:");
            string invalidFilePath = "nonexistentfile.txt";
            fileReader.ReadFile(invalidFilePath);

            Console.WriteLine("\nTesting with an empty file path:");
            fileReader.ReadFile("");
        }
    }
}
