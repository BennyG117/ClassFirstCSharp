// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//!in JS: 
// let myName = "Ben Gomez";
// console.log(myName); // would say: Ben Gomez

//In C# write ";" at the end of lines

// Console.WriteLine("Ben Gomez is my name");

//?declaring variable name and type
// string myName = "Ben Gomez";
// Console.WriteLine(myName);

//? error below because string comes with "", but char comes with '' & char is only 1 character
// string myName2 = 'Benny Gomez';
// Console.WriteLine(myName2);
//<<OR>>
// char myName3 = 'B';
// Console.WriteLine(myName3);

//? Int type
// int myNum = 7; 
// Console.WriteLine(myNum);

//?Double
// double myDecimal = 01.17;
// Console.WriteLine(myDecimal);

//? float
// float myFloat = 09.24f;
// Console.WriteLine(myFloat);

//? boolean
// bool isTired = true;
// Console.WriteLine(isTired);

//?Arrays are fixed length
// string[] groceryList = new string[4];
//?[null, null, null, null]
// Console.WriteLine(groceryList);
// Console.WriteLine(groceryList[0]);

Console.WriteLine("=======================");
Console.WriteLine("=========ARRAYS========");

//? Arrays
string[] groceryList2 = {"Carrots", "Turkey", "Bread", "Milk"};
Console.WriteLine(groceryList2[0]);

foreach(string i in groceryList2)
{
    Console.WriteLine($"My grocery list contains {i}");
    // Console.WriteLine("What's in my grocery list: " + i);
}

Console.WriteLine("=======================");
// alt appraoch with above -  Changes first item
groceryList2[0] = "salad";
foreach(string i in groceryList2)
{
    Console.WriteLine("What's in my grocery list: " + i);
}
Console.WriteLine("=======================");
//Arrays use Length
Console.WriteLine(groceryList2.Length);

//! Lists use Count instead of Length*
// Console.WriteLine(groceryList2.Count);


Console.WriteLine("=======================");
Console.WriteLine("=========LISTS========");
//?Lists Data Type:
List<int> numList = new List<int>();
numList.Add(1);
numList.Add(2);
numList.Add(3);
numList.Add(4);
numList.Add(5);
numList.Add(6);
Console.WriteLine(numList.Count);

Console.WriteLine("=======================");
//Remove th value 3
numList.Remove(3);

// remove the location index 3
numList.RemoveAt(3);

// Console.WriteLine(numList.Count);
Console.WriteLine("=======================");
foreach(int i in numList)
{
Console.WriteLine("What's in my numList: " + i);
}

Console.WriteLine("=======================");
Console.WriteLine("========Function======");
// static void SayHello()
// {
//     Console.WriteLine("Hello, how are you doing today?");
// }
// SayHello();


// Console.WriteLine("=======================");
static void SayHello2()
{
    Console.WriteLine("Hello, how are you doing today?");
}
SayHello2();

Console.WriteLine("=======================");
//without void, need to use return...
static int Calculate(int x, int y)
{
    return x - y;
}
Console.WriteLine(Calculate(50, 30));
Console.WriteLine("=======================");

int thisCanBeAnything = Calculate(4000, 2823);
Console.WriteLine("This is the real estate adjustment for the court case #500.45151: $" + thisCanBeAnything);

Console.WriteLine("=======================");
Console.WriteLine("=======================");



