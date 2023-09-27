# Basic-Maths-Arithmetic-operations-on-very-big-numbers
Basic Maths Arithmetic operations on very big numbers: Addition, Subtraction, Multiplication, Division, Modular, Exponent.


## Introduction

Basic math arithmetic operations are:

·       Addition

·       Subtraction

·       Multiplication

·       Division

Other math arithmetic operations are Modular, Exponent and etc.

Common calculators and calculator software have input number size limit, cannot compute very big input number and output very big & precise number result. Therefore, I write this program that can compute basic math arithmetic operations on very big numbers input and produce precise number result.

In programming language, when we write code to perform math arithmetic on numbers, both input & output numbers are integer. Integer are signed 32-bit data size. To overcome existing math arithmetic computing tool data size limit, I used list to store each digit of input & output of number. Using this way, we can compute very large numbers without simplifying the digits of input & result.

Numbers that having too many digits understandably doesn’t carry significant senses. We compute math arithmetic using the most significant digits of numbers and we will get rationally correct result in all situations.

Below code demonstrates we can get math arithmetic result while still able to show all the digits of the result without simplifying the digits. This code will not able to show every digit of irrational number as they are infinite decimal numbers. Program will only shows the first 50 most significant decimal.

 
### Visual c# Console App

Input numbers in string into static class ‘MathArithmetic.cs’ selected arithmetic operator to compute and in return obtain number result in string. I use string as the input number and output number because string have no size limit.

Static class ‘MathArithmetic’ operators’ Addition, Subtraction, Multiplication, Division and Modular can compute whole number and number with decimal. ‘MathArithmetic’ operator’s Exponent currently can only computer number with no decimal.

Version 0:   [main.cs]()   [MathArithmetic.cs]()

 

 

 

 


 

 

Edit date: 16 Sep 2023
