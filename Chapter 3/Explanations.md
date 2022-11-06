#### Exercise 1: Even Or Odd ####
The goal is to check if an integer is odd or even. Odd numbers are numbers that are not  
divisible by 2. Even numbers are divisible by 2. So all that needs to be done here is to  
check if the number is divisible by 2:

  if num is divisible by 2:  
  .    print "Even"  
  else:  
  .    print "Odd"  

With this logic, zero (0) which is neutral will be seen as an even number as 0/2 = 0.  
The code is meant to be simple, so there's no check for zero as input.  

-----------------------------------------------------------------------------------------  

#### Exercise 2: Divisible By 5 and 7 ####
We are tasked with finding out if an integer is divisible by both 5 and 7. For an integer  
to be divisible by any number <b>x</b> and <b>y</b>, for example, it has to be divisible by the lowest  
common multiple (LCM) of x and y. The LCM of two or more numbers is at least the maximum  
of all the numbers involved.  
So, for any integer to be divisible by both 5 and 7, the integer has to be divisible by the  
LCM of 5 and 7 (which is 35). All that needs to be done then is to check if the integer is  
divisible by 35.  

<b>Note: The LCM of two or more numbers is not the multiplication of the numbers themselves.  
Sometimes it is not different from the multiplication of the numbers involved (just like in  
the case of 5 and 7), but this is not always the case. If you're interested in how to find  
the LCM of numbers then lookup the link below:  

<a href="https://www.smartick.com/blog/mathematics/multiplication-and-division/least-common-multiple/">Least Common Multiple</a>

