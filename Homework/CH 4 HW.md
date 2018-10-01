1. **Using automatic properties is a shortcut that avoids several explicit steps. List the steps that the use of automatic properties avoids.**

change get/set statements without changing the classes, create the pattern of a field-backed property without defining the field or specifying the get/set

2. **Using the object initializer syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.**

allows creation and population in a single step

3. **What is the purpose of creating extension methods?**

adding methods that you cant modify directly

4. **What is the one feature of extension methods that will always allow you to identify a method as an extension method?**

the this keyword

5. **How do you create an extension method that ﬁlters the results returned by the method on a user speciﬁed criterion?**

The yield keyword.

6. **Explain the syntax of a lambda expression. The term “lambda expression” originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930’s. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.**

The => characters are read aloud as “goes to” and links the parameter to the result of the lambda expression.

7. **This will require some outside research. What is the distinction between an anonymously typed variable and a dynamically typed variable?**

A dynamically typed variable isn't assigned a type until run-time. An anonymously typed variable is given type var so that an explicit specification is not required.

8. **You are having a discussion about C# with a friend of yours that uses another language. You are telling him about C#’s LINQ library. How would you describe to him the diﬀerence between LINQ’s SQL-like notation and LINQ’s dot notation?**

Dot notation is a way to utilize extension methods because of the lack of corresponding keywords.

9. **What, exactly, does the await keyword do?**

Applying the await keyword means I can treat the result from a method as though it were a regular method and just assign the return to a variable.

10. **What is the connection between await and the async keywords?**

In order to use the await keyword, you must use the async keyword to the method signature.
