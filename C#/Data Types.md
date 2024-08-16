# Data Types
Data types in C# is mainly divided into two categories

- Value Data Types
- Reference Data Types

## Value Data Type
In C#, the Value Data Types will directly store the variable value in memory and it will also accept both signed and unsigned literals. The derived class for these data types are System.ValueType.

| Data Type |   Size   |    Range                                             |
|-----------|----------|------------------------------------------------------|
| byte      |  1 byte  | 0 to 255                                             |
| sbyte     |  1 byte  | -128 to 127                                          |
| short     |  2 byte  | -32768 to 32767                                      |
| ushort    |  2 byte  | 0 to 65535                                           |
| int       |  4 byte  | -2<sup>31</sup> to 2<sup>31</sup>-1                  |
| uint      |  4 byte  | 0 to 2<sup>32</sup>                                  |
| long      |  8 byte  | -2<sup>63</sup> to 2<sup>63</sup>-1                  |
| ulong     |  8 byte  | 0 to 2<sup>63</sup>                                  |
| float     |  4 byte  | ±1.5 × 10<sup>-45</sup> to ±3.4 × 10<sup>38</sup>    |
| double    |  8 byte  | ±5.0 × 10<sup>-324</sup> to ±1.7 × 10<sup>308</sup>  |
| decimal   |  16 byte | ±1.0 × 10<sup>-28</sup> to ±7.9228 × 10<sup>28</sup> |
| char      |  2 byte  | U +0000 to U +ffff                                   |
| bool      |  1 byte  | True or False                                        |

#### notice that when you increment number over their maximum value it overflows and loop back within the range
```csharp
using System;
namespace ValueTypeTest 
{
    class cls 
    {
        static void Main()
        {
            // sbyte is 8 bit singned value
            sbyte a = 126;
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            // It overflows here because byte can hold values from -128 to 127
            a++;
            Console.WriteLine(a);

            // Looping back within the range
            a++;
            Console.WriteLine(a);
        }
    }
}
```
#### Output
```
126
127
-128
-127
```

## Reference data Type
The Reference Data Types will contain a memory address of variable value because the reference types won’t store the variable value directly in memory. When you create a reference type variable, such as an object or a string, you are actually storing a reference (or pointer) to the location in memory where the data is held. The actual data for reference types is stored on the heap. The heap is a large pool of memory used for dynamic memory allocation. The built-in reference types are string, object.
- **string :** It represents a sequence of Unicode characters and its type name is System.String. So, string and String are equivalent. **Example :** 
```
string s1 = "hello"; // creating through string keyword  
String s2 = "welcome"; // creating through String class   
```

- **Object :** In C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from Object. So basically it is the base class for all the data types in C#. Before assigning values, it needs type conversion. When a variable of a value type is converted to object, it’s called boxing. When a variable of type object is converted to a value type, it’s called unboxing. Its type name is System.Object.

```csharp
using System;
namespace ValueTypeTest 
{    
    class cls 
    {    
        static void Main() 
        {          
            object obj = 7;

            Console.WriteLine("object = " + obj);
            Console.WriteLine("type: " + obj.GetType()); // To show the type of object

            obj = " Khaled";

            Console.WriteLine("object = " + obj);
            Console.WriteLine("type: " + obj.GetType());
        } 
    }
}
```
#### Output
```
object = 7
type: System.Int32
object =  Khaled
type: System.String
```