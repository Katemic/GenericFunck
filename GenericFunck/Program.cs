﻿using GenericFunck;

// Opgave 1
List<int> intList = new List<int>() { 5, 10, 3, 8, 15 };

//Console.WriteLine("Largest element in intList: " + Functions.FindLargest(intList)); // Output: 15
Console.WriteLine("Largest element in intList: " + Functions.FindLargestCompare(intList));


// Opgave 2
List<double> doubleList = new List<double>() { 3.14, 2.718, 12.4564, 2.0 };
Console.WriteLine("Largest element in doubleList: " + Functions.FindLargestCompare(doubleList)); // Output: 3.14

List<string> stringList = new List<string>() { "appleeeeeeee", "banana", "orange", "kiwi" };
Console.WriteLine("Largest element in stringList: " + Functions.FindLargestCompare(stringList)); // Output: orange

// Opgave 3
//List<Car> carList = new List<Car>() { new Car("AB43412", "Toyota", 160), new Car("CC6562", "Volvo", 200) };
//Console.WriteLine("Largest element in carList: " + Functions.FindLargest(carList)); // {Id=0, Regno=CC6562, Make=Volvo, Speed=200}
