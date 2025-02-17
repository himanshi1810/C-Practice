//// See https://aka.ms/new-console-template for more information
//using System.Linq;

//Console.WriteLine("Hello World!");
//Console.WriteLine("I am Learning C#");
//Console.WriteLine("It is awesome!");
//Console.WriteLine(3 + 3);
//Console.Write("Hi");
//Console.WriteLine("Himanshi");
//int myNum = 20;
//myNum = 25;
//Console.WriteLine(myNum);

////double myDoubleNum = 5.99D;
////char myLetter = 'D';
////bool myBool = true;
////string myText = "Hello";

////This is my string with concatination
//string fName = "Himanshi";
//string lName = "Gandhi";
//string fullName = fName + " " + lName;
//Console.WriteLine(fullName);

////This is my int 
//int x = 5, y = 6, z = 50;
//Console.WriteLine(x + y + z);

////Implicit Casting
//int myInt = 9;
//double myDouble = myInt;
//Console.WriteLine(myInt);
//Console.WriteLine(myDouble);

////Explicit Casting
//double myDouble1 = 9.78;
//int myInt1 = (int)myDouble1;
//Console.WriteLine(myDouble1);
//Console.WriteLine(myInt1);
////Type Conversion
//int myInt2 = 10;
//double myDouble2 = 5.25;
//bool myBool = true;
//Console.WriteLine(Convert.ToString(myInt2));
//Console.WriteLine(Convert.ToDouble(myInt2));
//Console.WriteLine(Convert.ToInt32(myDouble2));
//Console.WriteLine(Convert.ToString(myBool));


////Usetr Input
////Console.WriteLine("Enter your name:");
////string userName = Console.ReadLine();
////Console.WriteLine("Your name is: " + userName);

////User Input with int
////Console.WriteLine("Enter your age:");
////int userAge = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Your age is :- " + userAge);


////Math
//Console.WriteLine(Math.Max(5, 10));

////String Interpolation
//string lastName = "Gandhi";
//string firstName = "Himanshi";
//string name = $"My full name is: {firstName} {lastName}";
//Console.WriteLine(name);


////For Each Lop
//int[] numbers = { 10, 20, 30, 40, 50 };
//foreach (int i in numbers)
//{
//    Console.WriteLine(i * 5);
//}
//Console.WriteLine(numbers);

////Break 
//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}

////Continue
//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

////sort an array
//Array.Sort(numbers);
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

////Reverse an array
//Array.Reverse(numbers);
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

////System.Linq
//int[] myNumbers = { 5, 1, 8, 9 };
//Console.WriteLine(myNumbers.Max());  // returns the largest value
//Console.WriteLine(myNumbers.Min());  // returns the smallest value
//Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

////Multidimensional Array
//int[,] multiNumbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//Console.WriteLine(multiNumbers[1, 2]);
//C_Practice.Methods.MyMethod();
//C_Practice.Methods methodsInstance = new C_Practice.Methods();
//methodsInstance.name("Himanshi");
//methodsInstance.nameAge("Himanshi", 21);
//methodsInstance.Country("India");
//methodsInstance.Country();
//Console.WriteLine("Sum of 5 and 6 is: " + methodsInstance.sum(5, 6));
//methodsInstance.namedArguments(child3: "John", child1: "Liam", child2: "Emma");
//Console.WriteLine("Sum of 5 and 6 is: " + methodsInstance.plusMethod(5, 6));
//Console.WriteLine("Sum of 5.5 and 6.6 is: " + methodsInstance.plusMethod(5.6, 6.6));


//Classes
//C_Practice.Classes myObj = new C_Practice.Classes();
//Console.WriteLine(myObj.color);
//Console.WriteLine(myObj.model);
//Console.WriteLine(myObj.year);
//myObj.fullThrottle();

//Inheriance
//C_Practice.Inheritance myCar = new C_Practice.Inheritance();  
//myCar.honk();
//Console.WriteLine(myCar.brand + " " + myCar.modelName);

//Polymorphism
//C_Practice.Polymorphism myAnimal = new C_Practice.Polymorphism();  // Create a Animal object
//C_Practice.Polymorphism myPig = new C_Practice.Polymorphism();  // Create a Pig object
//C_Practice.Polymorphism myDog = new C_Practice.Polymorphism();  // Create a Dog object

//Abstarction
//C_Practice.tomato myTomato = new C_Practice.tomato();
//myTomato.color();

//Interface
//C_Practice.Book myBook = new C_Practice.Book();
//myBook.Read();

//Multiple Inheritance
//C_Practice.DemoClass demoClassInstance = new C_Practice.DemoClass();
//demoClassInstance.myMethod();
//demoClassInstance.myOtherMethod();

//Interface Inheritance
//C_Practice.ImplementationClass myClass = new C_Practice.ImplementationClass();
//myClass.Add(5, 6);
//myClass.Sub(5, 6);

//Ambiguity in Interface
C_Practice.InterfaceClass myClass = new C_Practice.InterfaceClass();
myClass.Test();
C_Practice.IInterface1 myInterface1 = myClass;
myInterface1.Show();
C_Practice.IInterface2 myInterface2 = myClass;
myInterface2.Show();