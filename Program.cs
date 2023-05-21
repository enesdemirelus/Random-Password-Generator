    Console.Write("Please provide the password length you want: ");
    string passwordLengthUserData = Convert.ToString(Console.ReadLine()!);
    int passwordLength = Convert.ToInt32(passwordLengthUserData);
    string[] letters = File.ReadAllLines("/Users/enesdemirel/Desktop/randomPasswordGenerator/password.txt");
    int[] randomNumbersArray = new int[passwordLength];
    string[] finalPassword = new string[passwordLength];

    for (int i = 0; i < passwordLength; i++)
    {
        Random randomNumberGenerator = new Random();
        int randomNumber = randomNumberGenerator.Next(46);
        randomNumbersArray.SetValue(randomNumber, i);
    }

    for (int i = 0; i < passwordLength; i++)
    {
        finalPassword.SetValue(letters[randomNumbersArray[i]], i);

    }


    string wordsInOneLine = string.Join("", finalPassword);
    Console.WriteLine("Your Password: " + wordsInOneLine);


