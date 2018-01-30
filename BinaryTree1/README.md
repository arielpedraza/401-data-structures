# Binary Tree Console App - Find Min/Max

**Author**: Ariel R. Pedraza <br />
**Version**: 1.0.0

## Overview
<b>Purpose:</b><br />
This application demonstrates the ability to find the min or max node of a non ordered binary tree.

<b>Solution:</b>
Given a starting root node...
1. If a left child node exists:
    1. recursively call method, passing left child node as argument
    2. assign return value to temp variable
2. If right child node exists:
    1. recursively call method, passing right child node as argument
    2. assign return value to temp variable
    3. If child node doesn't exist, return value of node.
3. Return the greater or lesser of both temp variables.

## Getting Started
The following is required to run the program.
1. Visual Studio 2017 
2. The .NET desktop development workload enabled 

## Example Output

```
Hello World!

          A
         / \
        B   C
       / \ / \
      D  E F  G

A = 8, B = 4, C = 6, D = 9, E = 3, F = 5, G = 7

E is the smallest with 3. D is the largest with 9.

FindMin(A): 3
FindMax(A): 9
```

## Whiteboarding
![Whiteboarding](whiteboarding.jpg)<br/>

## Architecture
This application is created using ASP.NET Core 2.0 Console applicaiton. <br />
*Language*: C# <br />
*Type of Applicaiton*: Console Application <br />