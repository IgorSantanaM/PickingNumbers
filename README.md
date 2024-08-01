# Picking Numbers

## Problem Description

Given an array of integers, find the longest subarray where the absolute difference between any two elements is less than or equal to 1.

### Example

There are two subarrays meeting the criterion: `[3, 3, 4]` and `[4, 5, 6]`. The maximum length subarray has 3 elements.

### Function Signature

```csharp
public static int pickingNumbers(List<int> a)
```
### Parameters
`a`: A list of integers.
Returns
An integer representing the length of the longest subarray that meets the criterion.
Input Format
The first line contains a single integer n, the size of the array a.
The second line contains n space-separated integers, each an element of a.
### Solution Approach
Count Frequencies: First, count how often each number appears in the array using an array freq where freq[i] represents the count of number i.
Evaluate Subarrays: For each unique number i in the array (from the smallest to the largest), calculate the maximum length of subarrays that can be formed:
Include elements i and i+1 (if they exist in the array), as their absolute difference is ≤ 1.
The length of such subarray is freq[i] + freq[i+1].
Track Maximum Length: Keep track of the maximum length found during the iterations.

### How to Run
1. Ensure you have the .NET Core SDK installed.
2. Copy the code into a .cs file.
3. Compile the code using csc (C# compiler) or run it using dotnet run if using a project setup.
4. Provide input through standard input (as shown in the sample input) and observe the output.
