// See https://aka.ms/new-console-template for more information

using MyListApp;

var testList = new MyList<int>();
string? input;
Console.WriteLine("Provide some values to check list class. Type 'stop' to finish.:");
do
{
    input = Console.ReadLine();
    if (input?.ToLower() != "stop")
    {
        if (int.TryParse(input, out var number))
        {
            testList.Add(number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number or 'stop' to finish.");
        }
    }
} while (input?.ToLower() != "stop");

//testList.Add(100);
//testList.Add(23);
//testList.Add(69);
//testList.Add(369);
//testList.Add(35);

Console.WriteLine("Element at index 1: " + testList[1]);

Console.WriteLine("Total count: " + testList.Count);

testList.RemoveAt(1);

Console.WriteLine("After removing element at index 1, count: " + testList.Count);
Console.WriteLine("After removing element at index 1, new element at index 1: " + testList[1]);

Console.WriteLine("Elements in the list:");
foreach (var item in testList)
{
    Console.WriteLine(item);
}

var array = testList.GetArray();
Console.WriteLine("Elements in the array:");
foreach (var item in array)
{
    Console.WriteLine(item);
}

var filtered = testList.Where(x => x < 100).Select(x => x * 2);
Console.WriteLine("Filtered and transformed elements:");
foreach (var item in filtered)
{
    Console.WriteLine(item);
}