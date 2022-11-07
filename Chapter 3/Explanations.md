# Exercise 1: Even Or Odd #
The goal is to check if an integer is odd or even. Odd numbers are numbers that are not  
divisible by 2. Even numbers are divisible by 2. So all that needs to be done here is to  
check if the number is divisible by 2:

  if num is divisible by 2:  
  .    print "Even"  
  else:  
  .    print "Odd"  

With this logic, zero (0) which is neutral will be seen as an even number as 0/2 = 0.  
The code is meant to be simple, so there's no check for zero as input.  
  
  



# Exercise 2: Divisible By 5 and 7 #
We are tasked with finding out if an integer is divisible by both 5 and 7. For an integer  
to be divisible by any number <b>x</b> and <b>y</b>, for example, it has to be divisible by the lowest  
common multiple (LCM) of x and y. The LCM of two or more numbers is at least the  
maximum of all the numbers involved.  
&emsp;So, for any integer to be divisible by both 5 and 7, the integer has to be divisible by the  
LCM of 5 and 7 (which is 35). All that needs to be done then is to check if the integer is  
divisible by 35.  

<b>Note: The LCM of two or more numbers is not the multiplication of the numbers themselves.  
Sometimes it is not different from the multiplication of the numbers involved (just like in  
the case of 5 and 7), but this is not always the case. If you're interested in how to find  
the LCM of numbers then lookup the link below:</b>  

<I><a href="https://www.smartick.com/blog/mathematics/multiplication-and-division/least-common-multiple/">Least Common Multiple</a></i>
  
  



# Exercise 3: Third Digit #
The task is to determine if the third digit of an integer (starting from the right) is 7. 
Given the right to left condition, the third digit of any integer would be in the <b><i>hundreds</i></b>  
column. We can achieve this by checking the remainder when the number is divided by 1000. 
This is because the remainder would then lie between 0 - 999. The range we're interested in  
is 700 - 799. Another way to rephrase all of this stuff is: <b>"If we slice up the number  
into two parts, in between the third and fourth digits, what would be the starting digit  
of the right part?"</b>. The solution can be similar to:

rem = remainder of num divided by 1000   
if rem is within the range from 700 to 799:  
&emsp;print "Third digit is 7"  
else:  
&emsp;print "Third digit is not 7"
  
  



# Exercise 4: Third Bit #
Integers are represented internally as a sequence of bits. We're tasked with finding out  
what the third bit of an integer is. There are different ways to this, but they involve  
the use of bitwise operators:

&emsp;<b>1. </b>Shift the third bit two places to the right so it becomes the first bit, then zero out all the  
&emsp;other bits except the first bit. The resulting integer (0 or 1) is the bit. This is the method I used.  

&emsp;<b>2. </b>Zero out all the bits in the integer except the one in the third position. If the resulting integer  
&emsp;is 0, then the bit is zero. Else, the bit is 1. But if you were to use this method, the resulting integer will 
&emps;either be 0 or NOT zero (2<sup>3-1</sup> to be specific, or 2<sup>n-1</sup>, where n is the bit position). To  

&emsp;<b>3. </b>Left-shift the third bit to the last position, then right-shift it to the first position. The effect of  
&emsp;the first Left-shift is to throw away all the bits before the third bit. Then the right-shift's effect would cause  
&emsp;all the bits after the third bit (which is now the last bit) to be tossed away. The resulting integer would be 0 or  
&emsp;1, and that would be the third bit's value.  

Even though I later used the first method (after a review of the solution provided in the book), my initial solution was  
<b>no. 3</b> above :)
