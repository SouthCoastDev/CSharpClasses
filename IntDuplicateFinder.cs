//Ask for input.

            Console.Write("Please enter some numbers in the format of 12-3-1-4-51-2-4. The system will tell you if there are any duplicates or not.");

            string UserInput = Console.ReadLine().Trim();

            //get just numbers if no numbers exit.
            if (String.IsNullOrEmpty(UserInput) || String.IsNullOrWhiteSpace(UserInput) || !UserInput.Contains('-') || UserInput[UserInput.Length - 1] == '-')
            {
                Console.WriteLine("Please try again. Input should be 12-13-14-15-6-1-2-3... and contain at least 2 numbers.");
            }

            //convert string to numbers. 
            String[] Numbers = UserInput.Split('-');
            int[] NumbersAsInt = new int[Numbers.Length];

            //convert to numbers
            int count = 0;
            foreach (var num in Numbers)
            {
                NumbersAsInt[count] = Convert.ToInt32(num);
                count++;
            }

            // return Duplicate" or "No Duplicates"


            bool Duplicate = false;

            for (int i = 0; i < NumbersAsInt.Length ; i++)
            {
                int DupCount = 0;
                foreach (var num in NumbersAsInt)
                {
                    if (num == NumbersAsInt[i])
                    {
                        DupCount++;
                    }
                }

                if(DupCount > 1)
                {
                    Duplicate = true;
                }
                
            }

            if (Duplicate)
            {
                Console.WriteLine("Duplicate found.");
            }
            else
            {
                Console.WriteLine("No Duplicates found.");
            }
