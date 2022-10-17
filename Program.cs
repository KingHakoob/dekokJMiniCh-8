// Jacob Dekok
// 10/17/2022
// Git Hub Transfer - Mini Challenge #8 Guess it
// This is a console project that allows the user to play a guessing game
// where the program generates a random number and the user has to guess it.

Console.Clear();


string playAgain = "YES";

while(playAgain == "YES"){

Random random = new Random();

bool validChoice = false;

string enteredMin;
string enteredMax;
int min = 0;
int max = 0;
string guess = "";
int guesses = 0;
int number;
bool isConverted = false;
bool minConverted = false;
bool maxConverted = false;
bool isNumber;
int validNum = 0;
bool minLessMax = false;

string mode;

Console.WriteLine("Hello!");

while(!validChoice){

Console.WriteLine("Would you like to play easy(1-10) medium(1-50) hard(1-100) or custom?");
mode = Console.ReadLine().ToLower();
switch(mode){

        case "easy":

            validChoice = true;

            number = random.Next(min = 1, max = 11);

            while(validNum != number){
             Console.Write("Guess a number between 1-10: ");
             guess = Console.ReadLine();

             while(!isConverted){

              isNumber = Int32.TryParse(guess, out validNum);

             if(isNumber == true){
               isConverted = true;
                   }else{
            Console.WriteLine("How about you try an actual number?");
            guess = Console.ReadLine();
                  }

              }
             guesses ++;

            if(validNum > number){
             Console.WriteLine(guess + " is to high. ");
             isConverted = false;

            }else if(validNum < number){
             Console.WriteLine(guess + " is to low. ");
             isConverted = false;

            }else if(validNum == number && guesses == 1){
             Console.WriteLine("");
              Console.WriteLine("You got it! The number was: " + number);
              Console.WriteLine("It only took you " + guesses + " try!");

            }else{
              Console.WriteLine("");
             Console.WriteLine("You got it! The number was: " + number);
             Console.WriteLine("It only took you " + guesses + " tries!");

            }
            }

        break;

        case "medium":

            validChoice = true;

            number = random.Next(min = 1, max = 51);

            while(validNum != number){
             Console.Write("Guess a number between 1-50: ");
             guess = Console.ReadLine();
              
             while(!isConverted){

              isNumber = Int32.TryParse(guess, out validNum);

             if(isNumber == true){
               isConverted = true;
                   }else{
            Console.WriteLine("How about you try an actual number?");
            guess = Console.ReadLine();
                  }
              }
              
             guesses ++;

            if(validNum > number){
             Console.WriteLine(guess + " is to high. ");
             isConverted = false;

            }else if(validNum < number){
             Console.WriteLine(guess + " is to low. ");
             isConverted = false;

            }else if(validNum == number && guesses == 1){
             Console.WriteLine("");
              Console.WriteLine("You got it! The number was: " + number);
              Console.WriteLine("It only took you " + guesses + " try!");

            }else{
              Console.WriteLine("");
             Console.WriteLine("You got it! The number was: " + number);
             Console.WriteLine("It only took you " + guesses + " tries!");

            }
            }

        break;

        case "hard":

            validChoice = true;

            number = random.Next(min = 1, max = 101);

            while(validNum != number){
             Console.Write("Guess a number between 1-100: ");
             guess = Console.ReadLine();

             while(!isConverted){

              isNumber = Int32.TryParse(guess, out validNum);

             if(isNumber == true){
               isConverted = true;
                   }else{
            Console.WriteLine("How about you try an actual number?");
            guess = Console.ReadLine();
                  }
              }

             guesses ++;

            if(validNum > number){
             Console.WriteLine(guess + " is to high. ");
             isConverted = false;

            }else if(validNum < number){
             Console.WriteLine(guess + " is to low. ");
             isConverted = false;

            }else if(validNum == number && guesses == 1){
             Console.WriteLine("");
              Console.WriteLine("You got it! The number was: " + number);
              Console.WriteLine("It only took you " + guesses + " try!");

            }else{
              Console.WriteLine("");
             Console.WriteLine("You got it! The number was: " + number);
             Console.WriteLine("It only took you " + guesses + " tries!");

            }
            }
        break;

        case "custom":

            validChoice = true;

            while(!minLessMax){

          Console.Write("Enter the minimum number you would like to guess from: ");
            enteredMin = Console.ReadLine();

            while(!minConverted){

            isNumber = Int32.TryParse(enteredMin, out min);

            if(isNumber == true){
               minConverted = true;
            }else{
              Console.WriteLine("How about you try an actual number?");
              enteredMin = Console.ReadLine();
              }
              }
            Console.Write("Enter the maximun number you would like to guess from: ");
            enteredMax = Console.ReadLine();

              while(!maxConverted){

              isNumber = Int32.TryParse(enteredMax, out max);

              if(isNumber == true){
                maxConverted = true;
              }else{
                Console.WriteLine("How about you try an actual number?");
                enteredMax = Console.ReadLine();
              }
              }
              min = Convert.ToInt32(enteredMin);
              max = Convert.ToInt32(enteredMax);

              if(min > max){
                Console.WriteLine("Quit trying to break my code!");
              }else{
                minLessMax = true;
              }
            }

            number = random.Next(min, max + 1);

            while(validNum != number){
             Console.Write($"Guess a number between {min}-{max}: ");
             guess = Console.ReadLine();

             while(!isConverted){

              isNumber = Int32.TryParse(guess, out validNum);

             if(isNumber == true){
               isConverted = true;
                   }else{
            Console.WriteLine("How about you try an actual number?");
            guess = Console.ReadLine();
                  }
              }

             guesses ++;

            if(validNum > number){
             Console.WriteLine(guess + " is to high. ");
             isConverted = false;

            }else if(validNum < number){
             Console.WriteLine(guess + " is to low. ");
             isConverted = false;

            }else if(validNum == number && guesses == 1){
             Console.WriteLine("");
              Console.WriteLine("You got it! The number was: " + number);
              Console.WriteLine("It only took you " + guesses + " try!");

            }else{
              Console.WriteLine("");
             Console.WriteLine("You got it! The number was: " + number);
             Console.WriteLine("It only took you " + guesses + " tries!");

            }
            }

        break;

        default:
            Console.WriteLine("Sorry that wasn't one of the options.");
        break;

}

}


 Console.WriteLine("");
    Console.WriteLine("Would you like to play again? 'YES' 'NO'");
    playAgain = Console.ReadLine().ToUpper(); 

if(playAgain == "NO"){
        Console.WriteLine("Good Bye!");
    }else if (playAgain != "YES" && playAgain != "NO"){
        Console.WriteLine("I'll take that as a no... ");
    }

} 
