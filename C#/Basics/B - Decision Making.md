# Decision Making

C# uses control statements to control the flow of execution of program based on certain conditions. These are used to cause the flow of execution to advance and branch based on changes to the state of a program.
### The conditional statements of C#: 
- [if](#if-statement)
- [if else](#If-else-Statement)
- [if else if](#if-else-if-statement)
- [Switch](#switch-statement)

## if statement
```csharp
using System;
public class cls 
{
	public static void Main(string[] args)
	{
		string name = "khaled";
		if (name == "khaled") 
        {
			Console.WriteLine("hello, khaled");
		}
	}
}
```
#### Output
```
hello, khaled
```
## If else Statement 
```csharp
using System;
public class GFG 
{
	public static void Main(string[] args)
	{
		string name = "yossif";
		if (name == "khaled") 
        {
			Console.WriteLine("hello, khaled");
		}
		else 
        {
			Console.WriteLine("who are you?");
		}
	}
}
```
# Output
```
who are you?
```
## If else if Statement 
```csharp
using System;
class cls 
{
	public static void Main(String[] args)
	{
		int i = 20;

		if (i == 10)
			Console.WriteLine("i is 10");
		else if (i == 15)
			Console.WriteLine("i is 15");
		else if (i == 20)
			Console.WriteLine("i is 20");
		else
			Console.WriteLine("i is not present");
	}
}
```
#### Output
```
i is 20
```

## Switch Statement 
Switch statement is an alternative to long if-else-if ladders. The expression is checked for different cases and the one match is executed. break statement is used to move out of the switch. If the break is not used, the control will flow to all cases below it until break is found or switch comes to an end. There is default case (optional) at the end of switch, if none of the case matches then default case is executed.
```csharp
using System;
public class cls 
{
	public static void Main(String[] args)
	{
		int number = 30;
		switch(number)
		{
		case 10: 
            Console.WriteLine("case 10");
			break;
		case 20: 
            Console.WriteLine("case 20");
			break;
		case 30: 
            Console.WriteLine("case 30");
			break;
		default: 
            Console.WriteLine("None matches"); 
			break;
		}
	}
}
```
#### Output
```
case 30
```
