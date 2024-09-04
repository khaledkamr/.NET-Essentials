# Methods
Methods are generally the block of codes or statements in a program that gives the user the ability to reuse the same code which ultimately saves the excessive use of memory, acts as a time saver and more importantly, it provides a better readability of code. So basically, a method is a collection of statements that perform some specific task and return the result to the caller. A method can also perform some specific task without returning anything.

### Syntax :  
```
<Access_Modifier> <return_type> <method_name>([<param_list>])
```
![method](https://media.geeksforgeeks.org/wp-content/uploads/methods-in-java.png)

### Method Calling

Method Invocation or Method Calling is done when the user wants to execute the method. The method needs to be called for using its functionality. A method returns to the code that invoked it when:

- It completes all the statements in the method
- It reaches a return statement
- Throws an exception 
 
**Example :** In the code below, a method named Sum() is called.

```csharp
using System;
namespace ConsoleApplication1 
{	
    class Geeks 
    {
        static int Sum(int x, int y)
        { 
            int a = x;
            int b = y;
            int result = a + b;

            return result;
        }

        static void Main(string[] args)
        {
            int a = 12;
            int b = 23;
            int c = Sum(a, b);
            
            Console.WriteLine("The Value of the sum is " + c);
        }
    }
}
```

#### Output :  
```
The Value of the sum is 35
```
# Method Parameters
There might be certain situations the user want to execute a method but sometimes that method requires some valuable inputs in order to execute and complete its tasks. These input values are known as Parameters in computer language terms.
### C# contains the following types of Method Parameters:
- Named Parameters
- Ref Parameters
- Out Parameters
- Default or Optional Parameters
- Dynamic Parameters
- Value Parameters
- Params

## Named Parameters
Named parameters in C# 4.0 allow you to specify argument values by name rather than position. This makes code more readable, especially with many parameters. However, named parameters must follow positional arguments.

### Example
```csharp
using System; 
public class GFG 
{ 
	public static void addstr(string s1, string s2, string s3) 
	{ 
		string result = s1 + s2 + s3; 
		Console.WriteLine("Final string is: " + result); 
	} 

	static public void Main() 
	{ 
		addstr(s1: "Geeks", s2: "for", s3: "Geeks"); 			
	} 
} 
```
#### Output:
```
Final string is: GeeksforGeeks
```

## Ref Parameters
The `ref` keyword in C# allows you to pass value types by reference. Any changes made to the argument within the method will be reflected in the original variable. However, `ref` cannot be used with properties. Arguments must be initialized before being passed using `ref`. `ref` is useful when a method needs to modify the value of a passed parameter.

### Example:
```csharp
using System; 
class GFG 
{ 
    public static void Main() 
    { 
        string val = "Dog"; 
        CompareValue(ref val); 
        Console.WriteLine(val); 
    } 
  
    static void CompareValue(ref string val1) 
    { 
        if (val1 == "Dog")  
        { 
            Console.WriteLine("Matched!"); 
        }
        val1 = "Cat"; 
    } 
} 
```
#### Output:
```
Matched!
Cat
```

## Out Parameters
The `out` keyword in C# allows you to pass arguments to methods by reference. It's often used for methods returning multiple values. Like `ref`, `out` cannot be used with properties. Unlike `ref`, parameters don't need to be initialized before being passed using `out`. `out` is useful when a method needs to return multiple values.

### Example:

```csharp
using System; 
class GFG 
{ 
    static public void Main() 
    {  
        int num; 
        AddNum(out num); 
        Console.WriteLine("The sum of" + " the value is: {0}",num);                       
    } 
  
    public static void AddNum(out int num) 
    { 
        num = 40; 
        num += num; 
    } 
} 
```
#### Output:
```
The sum of the value is: 80
```

## Default or Optional Parameters
Optional parameters in C# 4.0 are not required. They have default values that are used if not provided. Optional parameters must be defined at the end of the parameter list.

Example:

```csharp
using System;  
class GFG 
{  
    static public void detail(string ename, int eid, string bgrp = "A+", string dept = "Review-Team")  
    {  
        Console.WriteLine("Employee name: {0}", ename);  
        Console.WriteLine("Employee ID: {0}", eid);  
        Console.WriteLine("Blood Group: {0}", bgrp);  
        Console.WriteLine("Department: {0}", dept);  
    }  
    
    static public void Main()  
    {    
        detail("XYZ", 123);  
        detail("ABC", 456, "B-");  
        detail("DEF", 789, "B+",  "Software Developer");  
    }  
}  
```
#### Output:
```
Employee name: XYZ
Employee ID: 123
Blood Group: A+
Department: Review-Team
Employee name: ABC
Employee ID: 456
Blood Group: B-
Department: Review-Team
Employee name: DEF
Employee ID: 789
Blood Group: B+
Department: Software Developer
```

## Dynamic Parameters
Dynamic parameters in C# 4.0 allow for dynamic typing. The compiler doesn't check the type at compile-time, but rather at runtime. Dynamic variables are declared using the `dynamic` keyword.

### Example:

```csharp
using System; 
class GFG 
{   
    public static void mulval(dynamic val) 
    { 
        val *= val; 
        Console.WriteLine(val); 
    } 
  
    static public void Main() 
    { 
        mulval(30); 
    } 
} 
```
#### Output:
```
900
```

## Params
The `params` keyword in C# allows you to pass a variable number of arguments to a method. Only one `params` keyword is allowed per method, and it must be the last parameter. The `params` array will be empty if no arguments are passed.


### Example:
```csharp
using System; 
namespace Examples 
{   
    class Geeks 
    { 
        public static int mulval(params int[] num) 
        { 
            int res = 1; 
            foreach(int j in num) 
            { 
                res *= j; 
            } 
            return res; 
        } 
    
        static void Main(string[] args) 
        { 
            int x = mulval(20, 49, 56, 69, 78); 
            Console.WriteLine(x); 
        } 
    } 
} 
```
#### Output:
```
295364160
```

### Advantages of using the Methods : 
There are many advantages of using methods. Some of them are listed below: 

- It makes the program well structured.
- Methods enhance the readability of the code.
- It provides an effective way for the user to reuse the - existing code.
- It optimizes the execution time and memory space. 