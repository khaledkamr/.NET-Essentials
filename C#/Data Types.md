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
## value type VS Reference type

| Value types | Reference types |
|-------------|-----------------|
| byte, int, char, decimal, double, enum, bool, long, float, struct | Class, string, array, Delegate |
|stor value directly | stor reference for memory location |
| Value independent | Value shared |
| stored in stack memory | stored in heap memory |

## Dynamic type
Dynamic type is used to avoid the compile-time type checking. The compiler does not check the type of the dynamic type variable at compile time, instead of this, the compiler gets the type at the run time. The dynamic type variable is created using dynamic keyword.

#### Important Points:
- In most of the cases, the dynamic type behaves like object types.
- You can get the actual type of the dynamic variable at runtime by using GetType() method. The dynamic type changes its type at the run time based on the value present on the right-hand side. As shown in the below example.
    ```csharp
    using System; 
    class cls
    { 
        static public void Main() 
        { 
            dynamic value1 = "GeeksforGeeks"; 
            dynamic value2 = 123234; 
            dynamic value3 = false; 

            Console.WriteLine("Get the actual type of value1: {0}", value1.GetType().ToString()); 
            Console.WriteLine("Get the actual type of value2: {0}", value2.GetType().ToString()); 
            Console.WriteLine("Get the actual type of value3: {0}", value3.GetType().ToString()); 
        } 
    } 
    ```
    #### Output
    ```
    Get the actual type of value1: System.String
    Get the actual type of value2: System.Int32
    Get the actual type of value4: System.Boolean
    ```
- When you assign a class object to the dynamic type, then the compiler does not check for the right method and property name of the dynamic type which holds the custom class object.
- You can also pass a dynamic type parameter in the method so that the method can accept any type of parameter at run time. As shown in the below example.

    **Example:**

    ```csharp
    using System; 
    class GFG 
    { 
        public static void addstr(dynamic s1, dynamic s2) 
        { 
            Console.WriteLine(s1 + s2); 
        } 

        static public void Main() 
        { 
            addstr("G", "G"); 
            addstr("Hello", 1232); 
            addstr(12, 30); 
        } 
    } 
    ```
    #### Output
    ```
    GG
    Hello1232
    42
    ```
- The compiler will throw an exception at runtime if the methods and the properties are not compatible.
- It does not support the intellisense in visual studio.
- The compiler does not throw an error on dynamic type at compile time if there is no type checking for dynamic type.

## Var keyword
var is a keyword, it is used to declare an implicit type variable, that specifies the type of a variable based on initial value (at compile-time).

```csharp []
using System; 
using System.Text; 
namespace Test 
{ 
    class GFG 
    { 
        static void Main(string[] args) 
        {   
            var c = 120; 
            var d = 150.23m; 
            var f = "Khaled"; 

            Console.WriteLine("value of a {0}, type {1}", a, a.GetType()); 
            Console.WriteLine("value of b {0}, type {1}", b, b.GetType()); 
            Console.WriteLine("value of c {0}, type {1}", c, c.GetType());  
        } 
    } 
} 
```
#### Output
```
value of a 120, type System.Int32
value of b 150.23, type System.Decimal
value of c Khaled, type System.String
```

## Var VS Dynamic

| Var | Dynamic |
|-----|---------|
| The type of the variable is decided by the compiler at compile time. | The type of the variable is decided by the compiler at run time. |
| The variable must be initialized at the time of declaration. So that the compiler will decide the type of the variable according to the value it initialized. | the variable can ve declared without initialization. because the compiler only know the type of the variable at the run-time. |
| It cannot be used for properties or returning values from the function. It can only used as a local variable in function. | It can be used for properties or returning values from the function. |


