# Loops
Looping in C# is a way to execute a statement or a set of statements multiple times depending on the result of the condition to be evaluated to execute statements. The result condition should be true to execute statements within loops.
### loops in C#:
- while loop
- for loop
- do while loop
- foreach loop

## while loop
The test condition is given in the beginning of the loop and all statements are executed till the given Boolean condition satisfies when the condition becomes false, the control will be out from the while loop.

```csharp
using System;
class whileLoop
{
    public static void Main()
    {
        int x = 1;
 
        // Exit when x becomes greater than 4
        while (x <= 4)
        {
            Console.WriteLine("csharp");
 
            x++; // Increment the value 
        }
    }
}
```
#### Output
```
csharp
csharp
csharp
csharp
```

## For loop
for loop has similar functionality as while loop but with different syntax. for loops are preferred when the number of times loop statements are to be executed is known beforehand. The loop variable initialization, condition to be tested, and increment/decrement of the loop variable is done in one line in for loop thereby providing a shorter, easy to debug structure of looping.

1. **Initialization of loop variable**: Th expression / variable controlling the loop is initialized here. It is the starting point of for loop. An already declared variable can be used or a variable can be declared, local to loop only.

2. **Testing Condition**: The testing condition to execute statements of loop. It is used for testing the exit condition for a loop. It must return a boolean value true or false. When the condition became false the control will be out from the loop and for loop ends.

3. **Increment / Decrement**: The loop variable is incremented/decremented according to the requirement and the control then shifts to the testing condition again.

Note: Initialization part is evaluated only once when the for loop starts.
### Example
```csharp
using System;
class forLoopDemo
{
    public static void Main()
    {
        // for loop begins when x=1
        // and runs till x <= 4
        for (int x = 1; x <= 4; x++)
            Console.WriteLine("csharp");
    }
}
```
#### Output
```
csharp
csharp
csharp
csharp
```

## do-while loop
do while loop is similar to while loop with the only difference that it checks the condition after executing the statements, i.e it will execute the loop body one time for sure because it checks the condition after executing the statements.

```csharp
using System;

class dowhileloop
{
    public static void Main()
    {
        int x = 21;
        do
        {
            // The line will be printed even
            // if the condition is false
            Console.WriteLine("csharp");
            x++;
        }
        while (x < 20);
    }
}
```
#### Output
```
csharp
```

## foreach loop
The foreach loop is used to iterate over the elements of the collection. The collection may be an array or a list. It executes for each element present in the array.

```csharp
using System; 
class cls 
{ 
	static public void Main() 
	{ 
		Console.WriteLine("Print array:"); 

		int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 }; 

		// foreach loop begin it will run till the last element of the array 
		foreach(int items in a_array) 
		{ 
			Console.WriteLine(items); 
		} 
	} 
} 
```
#### Output:
```
Print array:
1
2
3
4
5
6
7
```
## Infinite Loops
The loops in which the test condition does not evaluate false ever tend to execute statements forever until an external force is used to end it and thus they are known as infinite loops.

### Example
```csharp
using System;
class infiniteLoop
{
    public static void Main()
    { 
        for(;;)
            Console.WriteLine("This is printed infinite times");
    }
}
```
#### Output
```
This is printed infinite times
This is printed infinite times
This is printed infinite times
.........
```
## Nested Loops
When loops are present inside the other loops, it is known as nested loops.

```csharp
using System;
class nestedLoops
{
    public static void Main()
    {
        // loop within loop printing csharp
        for (int i = 1; i < 3; i++)
            for (int j = 1; j < i; j++)
                Console.WriteLine("csharp");
    }
}
```
#### Output
```
csharp
csharp
```

## continue statement

continue statement is used to skip over the execution part of loop on a certain condition and move the flow to next updation part.

```csharp
using System;
class demoContinue
{
    public static void Main()
    {    
        for (int i = 1; i < 3; i++)
        {
            if (i == 2)
                continue;
            
            Console.WriteLine("csharp"); 
        }
    }
}  
```
#### Output
```
csharp
```