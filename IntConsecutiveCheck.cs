            Ask for input.

            Console.Write("Please enter some numbers in the format of 12-3-1-4-51-2-4. The system will tell you if they are consecutive or not.");
            string UserInput = Console.ReadLine().Trim();

            if (String.IsNullOrEmpty(UserInput) || String.IsNullOrWhiteSpace(UserInput) || !UserInput.Contains('-') || UserInput[UserInput.Length - 1] == '-')
            {
                Console.WriteLine("Please try again. Input should be 12-13-14-15-6-1-2-3... and contain at least 2 numbers.");
            }

            //get just numbers
            String[] Numbers = UserInput.Split('-');
            int[] NumbersAsInt = new int[Numbers.Length];
            //convert to numbers

            int count = 0;
            foreach (var num in Numbers)
            {
                NumbersAsInt[count] = Convert.ToInt32(num);
                count++;
            }

            bool Consecutive = false;

            for (int i = 0; i < NumbersAsInt.Length - 1; i++)
            {
                int checkNo = NumbersAsInt[i] + 1;

                if (NumbersAsInt[i + 1] == checkNo)
                {
                    Consecutive = true;
                }
                else
                {
                    break;
                }
            }

            if (Consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
