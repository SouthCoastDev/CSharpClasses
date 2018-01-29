        static string SummerizeText(string text , int maxLength = 20)
        {

            if (text.Length < maxLength)
            {
               return text;
            }
            else
            {
                String[] Words = text.Split(' ');
                int totalCharacters = 0;
                List<String> summaryWords = new List<string>();

                foreach (string word in Words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;

                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                return String.Join(" ", summaryWords) + "...";
 
            }
        }
