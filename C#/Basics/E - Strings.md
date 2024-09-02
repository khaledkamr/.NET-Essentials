# String

In C#, a string is a sequence of characters enclosed in double quotes (""). It's a fundamental data type used to represent text.

### Key points about strings in C#:

- **Immutable**: Once a string is created, its value cannot be changed. Any modification creates a new string object.
- **Unicode**: C# strings are Unicode-based, allowing them to represent characters from various languages.

### String literals:

- **Verbatim string literals:** Use `@` before the opening quote to preserve formatting and escape sequences.
    ```csharp
    string path = @"C:\Users\John\Documents\";
    ```

- **Interpolated strings:** Use `$` before the opening quote to embed expressions within the string.
    ```csharp
    int age = 30;
    string message = $"I am {age} years old.";
    ```

### string methods:
- **Length:**

    returns the number of characters in a string.
    ```csharp
    string text = "Hello, world!";
    int length = text.Length; // length = 13
    ```
-  **Substring:**

    Extracts a substring from a string, starting at a specified index and optionally ending at another index.

    ```csharp
    string text = "Hello, world!";
    string substring = text.Substring(7); // substring = "world!"
    ```
- **IndexOf:**

    Finds the index of the first occurrence of a character or substring within a string.

    ```csharp
    string text = "Hello, world!";
    int index = text.IndexOf("world"); // index = 7
    ```
- **Replace:**

    Replaces all occurrences of a specified character or substring with another string

    ```csharp
    string text = "Hello, world!";
    string newText = text.Replace("world", "everyone"); // newText = "Hello, everyone!"
    ```
- **ToUpperCase & ToLowerCase:**

    Converts all characters in a string to uppercase or lowercase.

    ```csharp
    string text = "Hello, world!";
    string uppercaseText = text.ToUpper(); // uppercaseText = "HELLO, WORLD!"
    string lowercaseText = text.ToLower(); // lowercaseText = "hello, world!"
    ```
- **Trim:**

    Removes leading and trailing whitespace characters from a string.

    ```csharp
    string text = "   Hello, world!   ";
    string trimmedText = text.Trim(); // trimmedText = "Hello, world!"
    ```
- **Contains:**

    Checks if a string contains a specified substring.

    ```csharp
    string text = "Hello, world!";
    bool containsWorld = text.Contains("world"); // containsWorld = true
    ```
- **Split:**

    Divides a string into an array of substrings based on a specified delimiter.

    ```csharp
    string text = "Hello, world!";
    string[] words = text.Split(','); // words = ["Hello", " world!"]
    ```
- **Join:**

    Combines an array of strings into a single string, separated by a specified separator.

    ```csharp
    string[] words = { "Hello", "world" };
    string joinedText = string.Join(", ", words); // joinedText = "Hello, world"
    ```


# String formatting
String formatting is a technique used to create formatted strings by combining static text with dynamic values. It allows you to present data in a structured and readable way.

### Common string formatting methods:
- Concatenation:
- String.Format method:
- Composite formatting:

## Concatenation
This involves using the `+` operator to combine strings and variables.

```csharp
string name = "Alice";
int age = 30;
string message = "My name is " + name + " and I am " + age + " years old.";
Console.WriteLine(message);
```
#### Output
```
My name is Alice and I am 30 years old.
```

## String.Format method:
This method uses placeholders (`{0}`, `{1}`, etc.) to represent dynamic values.

```csharp
string name = "Alice";
int age = 30;
string message = String.Format("My name is {0} and I am {1} years old.", name, age);
Console.WriteLine(message);
```
#### Output
```
My name is Alice and I am 30 years old.
```
Formatting options:

- Alignment: Use {0,10} to right-align the value within a 10-character field.
- Padding: Use {0:000} to pad a number with leading zeros.
- Number formatting: Use {0:C} for currency, {0:P} for percentage, {0:D} for decimal, etc.
- Date and time formatting: Use {0:d} for short date, {0:t} for short time, {0:f} for full date and time, etc.

## Composite formatting:
This uses a `$` before the string literal to embed expressions directly within the string.

```csharp
string name = "Alice";
int age = 30;
string message = $"My name is {name} and I am {age} years old.";
Console.WriteLine(message);
```
#### Output
```
My name is Alice and I am 30 years old.
```


# String builder
A StringBuilder is a mutable class in C# that provides efficient ways to build strings. Unlike the `string` class, which is immutable, a StringBuilder allows you to modify its contents without creating new string objects. This makes it particularly useful for scenarios where you need to perform frequent string modifications or concatenations.

- **Methods:** The StringBuilder class provides various methods for manipulating strings, such as:
    - **Append:** Adds a string or character to the end of the StringBuilder.
    - **Insert:** Inserts a string or character at a specified position within the StringBuilder.
    - **Remove:** Removes a specified number of characters from the StringBuilder.
    - **Replace:** Replaces a specified substring with another string.
    - **Clear:** Removes all characters from the StringBuilder.
    - **ToString:** Converts the StringBuilder to a string.

### Example
```csharp
StringBuilder builder = new StringBuilder();
builder.Append("Hello, ");
builder.Append("world!");
builder.Insert(5, "beautiful ");
builder.Remove(0, 5);
builder.Replace("world", "everyone");

string result = builder.ToString(); // result = "beautiful everyone!"
```

### When to use StringBuilder:

- When you need to build strings dynamically and perform frequent modifications.
- When you're working with large strings or concatenating multiple strings.
- When you want to improve performance and memory efficiency compared to string concatenation.