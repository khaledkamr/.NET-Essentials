# Arrays

An array is a group of like-typed variables that are referred to by a common name. And each data item is called an element of the array. The data types of the elements may be any valid data type like char, int, float, etc. and the elements are stored in a contiguous location. Length of the array specifies the number of elements present in the array. In C# the allocation of memory for the arrays is done dynamically. And arrays are kinds of objects, therefore it is easy to find their size using the predefined functions. The variables in the array are ordered and each has an index beginning from 0. Arrays in C# work differently than they do in C/C++.

- [Multidimensional Arrays](#multidimensional-arrays)
- [Jagged Arrays](#jagged-arrays)
- [Array methods](#array-methods)

### Important Points to Remember About Arrays in C#
- In C#, all arrays are dynamically allocated.
- Since arrays are objects in C#, we can find their length using member length. This is different from C/C++ where we find length using sizeof operator.
- A C# array variable can also be declared like other variables with [] after the data type.
- The variables in the array are ordered and each has an index beginning from 0.
- C# array is an object of base type System.Array.
- Default values of numeric array and reference type elements are set to be respectively zero and null.
- A jagged array elements are reference types and are initialized to null.
- Array elements can be of any type, including an array type.
- Array types are reference types which are derived from the abstract base type Array. These types implement IEnumerable and for it, they use foreach iteration on all arrays in C#.

```csharp
using System;
namespace prg 
{	
    class cls 
    {
        public static void Main()
        {
            // declares an Array of integers.
            int[] intArray;

            // allocating memory for 5 integers.
            intArray = new int[5];

            // initialize the first elements of the array
            intArray[0] = 10;

            // initialize the second elements of the array
            intArray[1] = 20;

            // so on...
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            // accessing the elements using for loop
            Console.Write("For loop :");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(" " + intArray[i]);
            }

            Console.WriteLine("");
            
            // using for-each loop
            Console.Write("For-each loop :");
            foreach(int i in intArray)
            {
                Console.Write(" " + i);
            }
        }
    }
}
```
#### Output :
```
For loop : 10 20 30 40 50
For-each loop : 10 20 30 40 50
```

# Multidimensional Arrays
The multi-dimensional array contains more than one row to store the values. It is also known as a Rectangular Array in C# because it’s each row length is same. It can be a 2D-array or 3D-array or more. To storing and accessing the values of the array, one required the nested loop. The multi-dimensional array declaration, initialization and accessing is as follows :

```csharp
// C# program to illustrate creating
// an multi- dimensional array
// puts some values in the array,
// and print them
using System;
namespace geeksforgeeks 
{	
    class GFG 
    {    
        public static void Main()
        {
            // Two-dimensional array
            int[, ] intarray = new int[, ] { { 1, 2 },
                                            { 3, 4 }, 
                                            { 5, 6 }, 
                                            { 7, 8 } };
                                            
            // The same array with dimensions 
            // specified 4 row and 2 column.
            int[, ] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 }, 
                                                { 5, 6 }, { 7, 8 } };

            // Three-dimensional array.
            int[,, ] intarray3D = new int[,, ] { { { 1, 2, 3 }, 
                                                { 4, 5, 6 } },
                                                { { 7, 8, 9 }, 
                                            { 10, 11, 12 } } };
                                                
                                                
            // The same array with dimensions 
            // specified 2, 2 and 3.
            int[,, ] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 }, 
                                                    { 4, 5, 6 } }, 
                                                    { { 7, 8, 9 }, 
                                                    { 10, 11, 12 } } };

            // Accessing array elements.
            Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
            Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
            Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
            Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);

            Console.WriteLine("2DArray[1][1] (other) : " + intarray_d[1, 1]);
                                    
            Console.WriteLine("2DArray[1][0] (other) : " + intarray_d[1, 0]);

            Console.WriteLine("3DArray[1][0][1] : " + intarray3D[1, 0, 1]);
                                
            Console.WriteLine("3DArray[1][1][2] : " + intarray3D[1, 1, 2]);

            Console.WriteLine("3DArray[0][1][1] (other): " + intarray3Dd[0, 1, 1]);
                                
            Console.WriteLine("3DArray[1][0][2] (other): " + intarray3Dd[1, 0, 2]);
        }
    }
}
```
#### Output :
```
2DArray[0][0] : 1
2DArray[0][1] : 2
2DArray[1][1] : 4
2DArray[2][0] 5
2DArray[1][1] (other) : 4
2DArray[1][0] (other) : 3
3DArray[1][0][1] : 8
3DArray[1][1][2] : 12
3DArray[0][1][1] (other): 5
3DArray[1][0][2] (other): 9
```

# Jagged Arrays

An array whose elements are arrays is known as Jagged arrays it means “array of arrays“. The jagged array elements may be of different dimensions and sizes. Below are the examples to show how to declare, initialize, and access the jagged arrays. Example : 

```csharp
// C# program to single-dimensional jagged array
// that contains two single-dimensional array
// elements of different sizes.
using System;
namespace geeksforgeeks 
{	
    class GFG 
    {
        public static void Main()
        {
            /*----------2D Array---------------*/
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            // Another way of Declare and
            // Initialize of elements
            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                            new int[] { 2, 4, 6, 8 } };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element [" + i + "] Array: ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
```
#### Output :
```
Element [0] Array: 1 3 5 7 9 
Element [1] Array: 2 4 6 8 
```
# Array methods

- [Clear()](#clear)
- [CopyTo()](#copyto)
- [Any()](#any)
- [Find()](#find)
- [Sort()](#sort)
- [Reverse()](#reverse)

## Clear()
This method is used to set a range of elements in an array to the default value of each element type.

### Syntax:
```
public static void Clear (Array array, int index, int length);
```
### Example:
```csharp
int[] arr = new int[5] {10,20,30,40,50};
Array.Clear(arr,0,arr.Length);
        
Console.WriteLine("Array After Operation: ");
foreach(int n in arr)
{
    Console.WriteLine(n, " ");
}
```
#### Output
```
Array After Operation: 
0 0 0 0 0
```
## CopyTo()
Copies all the elements of the current one-dimensional array to the specified one-dimensional array.

### Syntax: 
```
array.CopyTo(targetArray, index);
```
### Example:
```csharp
int[] original = new int[] { 1, 2, 3, 4, 5 };
int[] copied = new int[original.Length];

original.CopyTo(copied, 0);

foreach(int n in copied)
{
    Console.Write(n + " ");
}
```
#### Output
```
1 2 3 4 5 
```

## Any()
is used to determine if any elements in a collection or sequence satisfy a specified condition. It returns true if at least one element meets the condition, and false otherwise.

```csharp
using System.Linq;

int[] numbers = new int[0];
        
if (numbers.Any())
{
    Console.WriteLine("The array is not empty.");
}
else
{
    Console.WriteLine("The array is empty.");
}
```
#### Output
```
The array is empty.
```
## Find()
is used to find the first element in an array that satisfies a specified condition. It takes a predicate function as an argument, which determines whether an element meets the condition. If an element is found, Find() returns it; otherwise, it returns the default value of the array's element type.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

int evenNumber = Array.Find(numbers, n => n % 2 == 0);

if (evenNumber != 0)
{
    Console.WriteLine($"The first even number is: {evenNumber}");
}
else
{
    Console.WriteLine("There are no even numbers in the array.");
}
```
#### Output
```
The first even number is: 2
```

## Sort()
is used to sort the elements of an array in ascending order. It takes an array as input and modifies the array in place, meaning it doesn't create a new array.

```csharp
int[] numbers = { 5, 2, 9, 1, 7 };

Array.Sort(numbers);

foreach (int number in numbers)
{
    Console.Write(number + " ");
}
```
#### Output
```
1 2 5 7 9 
```

## Reverse()
is used to reverse the order of elements in an array. It takes the array as an argument and modifies the original array in place.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

Array.Reverse(numbers);

foreach (int number in numbers)
{
    Console.Write(number + " ");
}
```
#### Output
```
5 4 3 2 1
```