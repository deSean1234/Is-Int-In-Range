int test = IsIntInRange("Enter number between 1 and 7\n>> ", 1, 1, 7);
Console.WriteLine(test);

// wait before closing
Console.ReadKey();


// Int checker
static int IsIntInRange(string question, int response, int min , int max) {
    bool valid = false; // If the inputed number is valid
    while (valid == false) {    // While the number is not valid
        Console.Write(question);    // Displays the question everytime for when the user inputs wrong it displays question again
        try {   // runs the following code and catches errors
            response = Convert.ToInt32(Console.ReadLine()); // takes the input of the response
            if (Enumerable.Range(min, max).Contains(response)) {    // Checks if the input was within the min and max numbers
                valid = true;   // IF it was the number is now valid and thus will end the loop
            } else {    // (of the number was outside of the range)
                Console.WriteLine("Number is outside of range");    // Tells the user that the number was outsider of the raange
                continue;   // continues the loop asking the user again
            }
        }
        catch (System.Exception) {  // if there was an error
            Console.WriteLine("Invalid Number Entered");    // tells user that there was an error
            continue;   // COntinues the loop
            throw;  // I have no clue what this does
        }
    }

    return response;    // returns the response the user inputed if there was no errors and the number was within the set range;
}
