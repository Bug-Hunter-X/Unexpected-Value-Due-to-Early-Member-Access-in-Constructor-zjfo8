# Unexpected Value Due to Early Member Access in Constructor

This example demonstrates a subtle bug in C# that can occur when a member variable is accessed within a method before the constructor has fully initialized the object.  This can lead to unexpected values or exceptions.

## Bug Description
The `ExampleClass` has a constructor that initializes `MyProperty`. However, `MyMethod` accesses `MyProperty` before the constructor has finished assigning a value.  This could result in an unexpected default value being printed (0 in this case), before the assignment in the constructor takes effect. 

## How to Reproduce
1. Compile and run the code in `bug.cs`.
2. Observe the output. The first output might be 0, demonstrating the unexpected value before the assignment in the constructor.

## Solution
The solution involves ensuring all member accesses happen after the constructor has finished initializing all members. This can be achieved through proper ordering of code within methods, or by introducing temporary variables to store values during initialization. The `bugSolution.cs` file provides a corrected version.