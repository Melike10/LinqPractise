### LINQ Practices - Week 7 (Patika.dev)
This repository contains a C# console application developed as part of the LINQ practices for Week 7 of the Patika.dev course. The purpose of this project is to demonstrate the use of LINQ (Language-Integrated Query) in C# to perform various operations on a list of random integers.

## Project Overview
The application generates a list of 10 random integers, both positive and negative, within the range of -100 to 100. It then performs various LINQ operations to filter and transform the list, displaying the results in a clean and organized manner.

## Operations Performed:
Even Numbers: Filters and displays the even numbers from the list.
Odd Numbers: Filters and displays the odd numbers from the list.
Positive Numbers: Filters and displays the positive numbers from the list.
Negative Numbers: Filters and displays the negative numbers from the list.
Numbers Between 15 and 22: Filters and displays the numbers that lie between 15 and 22 (exclusive).
Squared Numbers: Transforms the list by squaring each number and then displays the squared values.
## Code Structure
The main logic of the program is encapsulated within a method called Show, which takes an IEnumerable<int> as an argument and displays its elements. This method is used to avoid repetitive code and to maintain clean and readable code.

## Key Elements:
LINQ Filtering: The program uses LINQ to filter the list based on various conditions (e.g., even/odd, positive/negative, range filtering).
LINQ Transformation: The program also demonstrates how to transform a list using LINQ, specifically by squaring each number.
Reusable Method: The Show method is used to display the results of each LINQ operation, promoting code reuse and readability.
## Example
Below is a potential example of the program's output:

```diff

---Even Numbers---
-4
22
64
---Odd Numbers---
-3
15
35
---Positive Numbers---
15
22
35
64
---Negative Numbers---
-4
-3
---Numbers Between 15 && 22---
22
---Squared Numbers---
16
9
225
484
1225
4096
```
## Usage
Clone the repository or download the source code.
Compile and run the program in your preferred C# development environment.
The program will automatically generate a list of random integers and display the results of the LINQ operations.
## Conclusion
This project is a practical example of how LINQ can be used to filter and transform collections in C#. It provides hands-on experience with basic LINQ operations, emphasizing clean code practices and efficient data manipulation.

