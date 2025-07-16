# Basic-Maths-Arithmetic-operations-on-very-big-numbers
Basic Maths Arithmetic operations on very big numbers: Addition, Subtraction, Multiplication, Division, Modular, Exponent.


## Introduction

Basic math arithmetic operations are:

·       Addition

·       Subtraction

·       Multiplication

·       Division

Other math arithmetic operations are Modular, Exponent, Exponent Root and etc.

Common calculators and calculator software have input number size limit, cannot compute very big input number and output very big & precise number result. Therefore, I write this program that can compute basic math arithmetic operations on very big numbers input and produce precise number result.

In programming language, when we write code to perform math arithmetic on numbers, both input & output numbers are limited to data size of integer. Integer are signed 32-bit data size. To overcome existing math arithmetic computing tool data size limit, I used list to store each digit of input & output of number. By this way, we can compute very large numbers without simplifying the digits of input & result, as long as computer hardware & system can support.

Numbers that having too many digits understandably doesn’t carry significant senses. We compute math arithmetic using the most significant digits of numbers and we will get rationally correct result in all situations.

Below code demonstrates we can get math arithmetic result while still able to show all the digits of the result without simplifying the digits. This code will not able to show every digit of irrational number as they are infinite decimal numbers. Program will only shows the first 50 most significant decimal.

This program still has data size limitations. Lists’ index, FOR loop’s index, power of exponent are using integer data size, due to compiler restraint.

 
### Visual c# Console App

Input numbers in string into static class ‘MathArithmetic.cs’ selected arithmetic operator to compute and in return obtain number result in string. I use string as the input number and output number because string have no size limit.

Static class ‘MathArithmetic’ operators’ Addition, Subtraction, Multiplication, Division and Modular can compute whole number and number with decimal. ‘MathArithmetic’ operator’s Exponent currently can only computer number with no decimal.

<ins>Version 0:</ins>

Version ‘0’ compute arithmetic operator single digit by single digit. Each digit of the input numbers are stored as a node inside the linked-lists.
[main_v0.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/main_v0.cs.txt)         [MathArithmetic_v0.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/MathArithmetic_v0.cs.txt)


<ins>Version 1</ins>

Version ‘1’ compute arithmetic operator in ‘long integer’ data size.

In Addition, Subtraction operators, each 18 digits of the input numbers are stored as a node inside the linked-lists during computation. In Multiplication, Division, Modular and Exponent arithmetic operator, each 9 digits of the input numbers are stored as a node inside the linked-lists during computation.

When computing Addition, Subtraction and Multiplication arithmetic operation, version ‘1’ (‘MathArithmetic.Addition_UnlimitedDataSize_long’, ‘MathArithmetic.Minus_UnlimitedDataSize_long’, ‘MathArithmetic.Multiplication_UnlimitedDataSize_long’) should be faster than version ‘0’ (‘MathArithmetic.Addition_UnlimitedDataSize_1Digit’, ‘MathArithmetic.Minus_UnlimitedDataSize_1Digit’, ‘MathArithmetic.Multiplication_UnlimitedDataSize_1Digit’). Because the program can compute 18 digits or 9 digits numbers in one go.

However when come to Division and Modular operator, inversely version ‘0’ (‘MathArithmetic.Division_UnlimitedDataSize_1Digit’) is faster than version ‘1’ (‘MathArithmetic.Division_UnlimitedDataSize_long’). Version ‘1’ Division operator occasionally need to reiterate many times to get to the closest number; on the other hands, version ‘0’ Division operator reiterates maximum 9 times each cycle to get to the closest number.

Division and Modular operators both using brute force method to derive the result. Firstly get an approximate outcome at most significant ‘long’ node, then in each iteration deduct least significant ‘long’ node by 1 to get to the closest number. Hence, when compute very big numbers, the program takes very long time.

We can choose to use either version ‘0’ or version ‘1’ as both of them accept input number in string format and produce result in string format.

  [main_v1.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/main_v1.cs.txt)            [MathArithmetic_v1.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/MathArithmetic_v1.cs.txt)

 

<ins>Version 2</ins>

In version 1 Division (‘MathArithmetic.Division_UnlimitedDataSize_long’) and Modular operators, firstly get an approximate outcome at most significant ‘long’ node, then in each iteration deduct least significant ‘long’ node by 1 to get to the closest number.

Version 2 Division operator (‘MathArithmetic.Division_UnlimitedDataSize_long’), get an approximate outcome at most significant ‘long’ node, then in each iteration deduct 1 from the following most significant digits, then to the next digits to get to the closest number. Therefore version 2 Division operator (‘MathArithmetic.Division_UnlimitedDataSize_long’) will be faster than version 1 division operator. However, it is still slower than version 0 Division operator (‘MathArithmetic.Division_UnlimitedDataSize_1Digit’).

[main_v2.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/main_v2.cs.txt)           [MathArithmetic_v2.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/MathArithmetic_v2.cs.txt)

 

<ins>Version 3</ins>

In previous version Addition, Subtraction, Multiplication arithmetic, each digit needs to wait for the previous digit to finish calculation sequentially. When result overflown (example single digit addition 5+7=12=10+2. 10 is the overflow), the overflow will carry-over to the next digit. Arithmetic calculation start from least significant digit, then to the next digit sequentially.

This version Addition, Subtraction, Multiplication arithmetic, each digit of the 2 input numbers can compute concurrently instead of sequentially. This makes the mentioned basic arithmetic compute faster using multithreading computer. Each digit doesn’t need to wait for the previous digit to finish the arithmetic calculation. Each digit / node of the result is catered with data size big enough for the overflow. After finished the mentioned arithmetic computation, the program will check each digit / node for the overflow. If digit / node overflown, the overflow will carry-over to the next digit / node. This part can even be concurrent too.

Optimization on divisions ‘MathArithmetic.Division_UnlimitedDataSize_1Digit’. ‘MathArithmetic.Division_UnlimitedDataSize_1Digit’ computed result’s decimal value randomly having zero appear, while ‘MathArithmetic.Division_UnlimitedDataSize_long’ computed result doesn’t have such problem. Checking in progress.

Similar to Division and Modular operators, Exponential Root arithmetic (a^(1/b), where b value only integers are accepted) also uses brute force method to derive the result. First assume maximum value (999..) is the result. If overflowed after multiplication, reduced the result by one, digits-by-digits. Hence, when compute very big numbers, the program takes very long time and memory.

When computing exponent power with integer only, the program uses multiplication method. Therefore overall faster.

When Exponent arithmetic’s exponent power has decimal points (example 5^1.5), decimals part computation will be using Exponential Root arithmetic. Therefore, take very long times and memory to compute. As we all know, exponential increment is very rapid. Hence is a bad idea to compute Exponential Root arithmetic using brute force method. May consider using logarithm to compute Exponent Root arithmetic in future.

[main_v3.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/main_v3.cs.txt)           [MathArithmetic_v3.cs.txt](https://github.com/lksark/Basic-Maths-Arithmetic-operations-on-very-big-numbers/blob/main/MathArithmetic_v3.cs.txt)
 

 

 


 

 

Edit date: 02 Jul 2025
