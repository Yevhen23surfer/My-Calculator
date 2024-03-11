// See https://aka.ms/new-console-template for more information
// int a = 12;
// decimal b=12.0m;
// float u=15.12f;
// double d=14.12;
// bool c = true;

// string s = "Nice";
// Console.WriteLine("This " +s+ " string value\n\n ");
// Console.WriteLine(s);

// string S = "Hello Modul B";


// Greeting message
// string greeting = "Hi there!";

// PascalCase
// For: Interface, Classes, Methods etc.
// Console.WriteLine(greeting);

// int firstNum = 2;
// int secondNum = 8;

// int sum = firstNum + secondNum;

// Console.WriteLine(sum);

// sum = firstNum + firstNum + firstNum + 500;
// Console.WriteLine(sum);

// Console.WriteLine(10 % 2);
// math: 10/2 = whole number without any remainder
// Console.WriteLine(9 % 2); // 9/2=4 ... remainder: 1

// int row = 1;

// Console.WriteLine(row % 3);
// row = row + 1;
// Console.WriteLine(row % 3);
// row = row + 1;
// Console.WriteLine(row % 3);
// row = row + 1;
// Console.WriteLine(row % 3);
// row = row + 1;
// Console.WriteLine(row % 3);
// row = row + 1;
// Console.WriteLine(row % 3);
// row = row + 1;

// int myNum = 5;

// int anotherNum = 100;

// Console.WriteLine(myNum);

// myNum += 1;
// myNum++;
// myNum++;
// myNum++;

// myNum =2 + ((5*100) / 3);
// Console.WriteLine(myNum);

// float, double, decimal

// double myShare = 0.05123;
// Console.WriteLine(100.0 * myShare);

// Console.WriteLine("Enter your username");
// string userName = Console.ReadLine();

// Console.WriteLine("...............................");
// Console.WriteLine("...............................");
// Console.WriteLine("...............................");
// Console.WriteLine("...............................");


// Console.WriteLine("Your entered the username: " + userName);

// basic calculator 
// int numb1;
// int numb2;
// int sum;
// // user input variables (strings)
// string userInput1;
// string userInput2;

// Console.WriteLine("Welcome to my calculator\nEnter a number:");
// // Wait for user to enter the first number
// userInput1 = Console.ReadLine();
// numb1 = Convert.ToInt32(userInput1);

// Console.WriteLine("Enter another number: ");

// userInput2 = Console.ReadLine();
// numb2 = Convert.ToInt32(userInput2);

// sum = numb1 + numb2;

// Console.WriteLine(numb1 + " + " + numb2 + " = " + sum);

// int score = 9999;
// int experience = 10;

// if (score >= 50 && score <= 60)
// {
//     Console.WriteLine("score between 50 to 60");
//     if (experience > 5) {
//         Console.WriteLine("and experience is greater than 5");
//     }

//     string message = "Hi";
//     Console.WriteLine(message);
// }

// else
// {
//     Console.WriteLine("score is outside");
// }

// int userAge = 55;

// bool isUserAnAdult = userAge >= 18;

// // message to user
// string message;

// if (isUserAnAdult)
// {
//     message = "User is an adult";
// }
// else 
// {
//     message = "User is not an adult";
// }

// Console.WriteLine(message);


/*// basic calculator 

// new features and how it should work
// 1. Show thw welcome message
// 2. Ask user to provide a number
// 3. Ask user to provide a mathematical operator (+, -, /, *)
// 4. Ask user to provide another number
// 5. Check which operator the user typed
// 6. Based on #4 calculate the equetion, and display the result

double numb1;
string mathOperator; // +, -, /, *
double numb2;
double result;

Console.WriteLine("Welcome to my calculator\nEnter a number:");
// Wait for user to enter the first number

// convert the user input into a number, using the Convert-class
numb1 = Convert.ToDouble(Console.ReadLine());

// Wait for user operator
Console.WriteLine("Enter operator: +, -, /, * ");

mathOperator = Console.ReadLine();

// check if the user entered a valid operator
if (mathOperator == "+") 
{
    // 3. Run the sum math operation and display the result
    Console.WriteLine("Enter another number: ");
    Console.WriteLine("user entered a plus symbol");
    // convert the user input into a number, using the Convert-class
    numb2 = Convert.ToDouble(Console.ReadLine());
    result = numb1 + numb2;
    Console.WriteLine($"{numb1} + {numb2} = {result}");     
}
if (mathOperator == "-") 
{
    // 3. Run the  math operation and display the result
    Console.WriteLine("Enter another number: ");
    Console.WriteLine("user entered a minus symbol");
    // convert the user input into a number, using the Convert-class
    numb2 = Convert.ToDouble(Console.ReadLine());
    result = numb1 - numb2;
    Console.WriteLine($"{numb1} - {numb2} = {result}");  
}
if (mathOperator == "/") 
{
    // 3. Run the math operation and display the result
    Console.WriteLine("Enter another number: ");
    Console.WriteLine("user entered a / symbol");
    // convert the user input into a number, using the Convert-class
    numb2 = Convert.ToDouble(Console.ReadLine());
    result = numb1 / numb2;
    Console.WriteLine($"{numb1} / {numb2} = {result}"); 
}
if (mathOperator == "*") 
{
    // 3. Run the math operation and display the result
    Console.WriteLine("Enter another number: ");
    Console.WriteLine("user entered a * symbol");
    // convert the user input into a number, using the Convert-class
    numb2 = Convert.ToDouble(Console.ReadLine());
    result = numb1 * numb2;
    Console.WriteLine($"{numb1} * {numb2} = {result}"); 
}
*/

/*
int num = 5;

switch(num)
{
    case >= 5:
        Console.WriteLine("Number is 5 or more");
        break;
    case >= 2:
        Console.WriteLine("Number is 2 or more");
        break;
    default:
        Console.WriteLine("Nothing");
        break;
}
*/

/*
bool isItMonday = true;

if (isItMonday)
{
    Console.WriteLine("Yes is it monday is true");
}

int count = 0;
while (count < 5) {
    Console.WriteLine("count is " + count);
    count += 1;
}

Console.WriteLine("Are we done?");
*/

/*
// 1. While loop
int userNumber = -1;

while (userNumber < 0 || userNumber > 10)
{
    Console.WriteLine("Enter a number between 0 and 10");
    string userResponse = Console.ReadLine();
    userNumber = Console.ToInt32(userResponse);
}
*/

/*
//2. do-while loop

int usersNumber = -1;

do 
{
    Console.WriteLine("Enter a number between 0 and 10");
    string userResponse = Console.ReadLine();
    usersNumber = Convert.ToInt32(userResponse);
}
while (usersNumber < 0 || usersNumber > 10);

*/

int x = 1;

while (x <= 5) {
    Console.WriteLine(x);
    x++;
}

// for loop