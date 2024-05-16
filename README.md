## Fundamentals Of Computer Programming With C Sharp (The Bulgarian C# Programming Book), Svetlin Nakov & Co. ##
This repo contains my own personal solutions to the exercises in the C# programming book with the same name title above.

This project was created using .NET 7. Pleae make sure to refer to the exercises in each chapter's readme file before looking  
at the solutions to them, as no attempt is made to explain the purpose of a solution except what may be inferred from the code.
  

### Structure Of The Solutions ###
#### Folder And File Structure ####
A folder is created for each chapter's exercises. The solutions to the exercises are contained in the chapter folders in separate files. This means there is a file for each exercise, so the solutions to the different exercises are in different files.

#### Code Structure ####
A template for the code structure is available at [Code Structure](Exercises/code_structure_template.txt). Plese refer to this template. Basically, the namespace "FundamentalsOfComputerProgrammingWithCSharp" contains everything regardinig the exercises from the book. Then, specifically, solutions to exercises are organized into a Chapter namespace (for example, chapter 1 solutions in Chapter1 namespace). Each solution is a class of its own, therefore a Chapter is made up of a bunch of classes. Each classs follows a particular naming pattern I chose and is named after the exercise it solves. The main code for each exercise class is contained in its Solution() method. There is thus a consistent way of accessing the solution to each exercise. As examples:

        Chapter1.Ex05_<Name>.Solution();
        Chapter1.Ex06_<Name>.Solution();
        Chapter2.Ex01_<Name>.Solution();

where "Name" is a placeholder for the name portion of the class which solves the exercise. The name is usually descriptive of the problem the exercise wants solved. An example:
        
        Chapter1.Ex05_GoodDay.Solution();

In the above example, Chapter1 is a namespace which contains all the solutions for the exercises from chapter one of the book. Ex05_GoodDay is a class, while the Solution() method is the main code for the exercise. It's sort of like the "Main" method.  
  
  
I have adopted this structure to make each exercise a self-contained unit. Also, by making each exercise solution a class of its own, it would encourage dividing the problem into several smaller pieces (methods), which will be beneficial for complex exercises.  
  
  
Note: To keep the solutions brief, input validation is only done when it is expressly required by the exercise or where it makes sense to (Like requesting an input within a particular range). When input validation is done it may be partial (ranged/constrained input check) or in full (a total validation - ranged input and valid data type entry/valid parsing check). Otherwise, it is assumed that the user will enter input correctly.