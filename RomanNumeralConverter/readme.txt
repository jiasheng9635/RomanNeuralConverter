Step 1 (Around 2 hour)
======================
After looking through 10 questions, I found this Roman Numeral Conversion is a very interesting project.

Getting a test case listing help a lot in troubleshoot my programming logic.

I begin my coding from "arabicToRoman" function first, as it is more easier to test with numbers as input.

After study and have an understanding on the structure, I have come to a common understanding of a standard handling case for number 4 and number 9
Example: 
- 4 is stated as IV getting V from 5
- 9 is stated as IX getting X from 10
- similar technique applied goes on (Able to further simplify the logic if able to use a list to keep all the Roman Numeral together)

So, in my logical checking, I had to use a boolean variable "specialHandlingCase" to differentiate normal and special case out.

As the intention of using a loop to deduct integer value to 0, so using a first digit simplify the logic.


Step 2 (Around 2 hour)
=================
Apply "romanToArabic" function as well as condition checking with an input string.

There is couple things to do on the checklist for invalid input
- Convert to correct numeric value (Easy Part)
- Checking the same grading level (The most struggle part, apply "penaltyCount" variable to compensate the specialHandlingCase)
- Checking no more than 3 repeated value in the same grading (Finding support idealogy from internet to proof this as number 3999 keep showing error, solved it by changing the grading level value)
- Checking special case like IXI (Not the best solution, but simply run it with the arabicToRoman function again)


Step 3 (Around 1 hour)
======================
After reviewing value after 4000 is very similar to the initial structure, so there is no difficulty on applying it with a new class "RomanNumbers4M.cs"

Roman Numerals Chart
Roman	Number		Use As
Numeral	Value		Inputs
I		1			I
V		5			V
X		10			X
L		50			L
C		100			C
D		500			D
M		1,000		M
I		1,000		_I
V		5,000		_V
X		10,000		_X
L		50,000		_L
C		100,000		_C
D		500,000		_D
M		1,000,000	_M


Ending
======
Total time used on this project : 5 hours (4pm to 9pm)


