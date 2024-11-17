namespace Homeworks.Lecture_2
{
    class Task3
    {
        public void ExtractAndModifySubstring()
        {
            //Objective: Given a string with a sentence, extract a word(substring) from it and convert it to uppercase.
            //Instructions: Use methods like Substring() and ToUpper().

            string sentence = "Samo Levski";
            string word = sentence.Substring(5,6).ToUpper();
            Console.WriteLine($"The sentence is: {sentence}");
            Console.WriteLine($"The substring in upper case is:{word}");
        }
    }
}
