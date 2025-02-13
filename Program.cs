// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");
Console.WriteLine("I am Learning C#");
Console.WriteLine("It is awesome!");
Console.WriteLine(3 + 3);
Console.Write("Hi");
Console.WriteLine("Himanshi");
int myNum = 20;
myNum = 25;
Console.WriteLine(myNum);

//double myDoubleNum = 5.99D;
//char myLetter = 'D';
//bool myBool = true;
//string myText = "Hello";

//This is my string with concatination
string fName = "Himanshi";
string lName = "Gandhi";
string fullName = fName + " " + lName;
Console.WriteLine(fullName);

//This is my int 
int x = 5, y = 6, z = 50;
Console.WriteLine(x + y + z);

//Implicit Casting
int myInt = 9;
double myDouble = myInt;       
Console.WriteLine(myInt);      
Console.WriteLine(myDouble);

//Explicit Casting
double myDouble1 = 9.78;
int myInt1 = (int)myDouble1;
Console.WriteLine(myDouble1);
Console.WriteLine(myInt1);
//Type Conversion
int myInt2 = 10;
double myDouble2 = 5.25;
bool myBool = true;
Console.WriteLine(Convert.ToString(myInt2));
Console.WriteLine(Convert.ToDouble(myInt2));
Console.WriteLine(Convert.ToInt32(myDouble2));
Console.WriteLine(Convert.ToString(myBool));


//Usetr Input
Console.WriteLine("Enter your name:");
string userName = Console.ReadLine();
Console.WriteLine("Your name is: " + userName);

//User Input with int
Console.WriteLine("Enter your age:");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is :- " + userAge);