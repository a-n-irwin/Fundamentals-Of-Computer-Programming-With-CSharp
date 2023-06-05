## Fundamentals Of Computer Programming With C Sharp (The Bulgarian C# Programming Book), Svetlin Nakov & Co.
This repo contains my own personal solutions for the C# book with the same name title above.

This project was created with .NET 7.0.203 and takes advantage of the implicit using statements which is provided
by C#10 and Up. If you're  interested in knowing the namespaces which are implicitly provided - [C# 10's implicit usings](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/overview#implicit-using-directives)

A folder is created for each chapter where the respective exercises from the book are from. The solutions
to the exercises are contained in the chapter folders. A file is created for each exercise, so the solutions to 
the different exercises are in different files.

Rather than having a Main() function for each exercise, it's easier to create just one project, and then keep solutions
to the exercises in a class (for example, chapter 1 solutions in Chapter1 class). Each solution in the class is named after 
the exercise they solve. This way we can have a consistent way of accessing a solution through one 
Main function. As examples:

        Chapter1.Ex05_<Name>();
        Chapter1.Ex06_<Name>();
        Chapter2.Ex01_<Name>();

where "Name" is a placeholder for the name of the function (the solution to the exercise). An example:
        
        Chapter1.Ex05_GoodDay();

This approach might make the structure differ from the idea of creating self-contained solutions, But it feels
easier to have one project manage everything. Even though the structure differs, I think the underlying code in 
each function is what matters.