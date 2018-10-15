1. **What is a view engine?**

A way to process ASP.NET content and look for instructions to insert content into the output sent to a browser.

2. **What is Razor?**

The MVC Framework view engine.

3. **What do views do? List two speciﬁc things in your answer to this question.**

Presents content to the user. Format data.

4. **How does Razor respond when it encounters statements that begin with the at character (@)? Be speciﬁc.**

It treats what follows as code.

5. **How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)? Be speciﬁc.**

The @: prevents Razor from interpreting text as a C# statement. It is a line prefix.

6. **Describe how you implement a standard formatting for all pages in an ASP.NET application.**

view imports and basic layouts

7. **What is the diﬀerence in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?**



8. **What is a view start ﬁle and where is it located?**

A file within the Views folder that the MVC Framework uses to render a view. It can be used to set a value for the Layout property.

9. **What is a Razor code block? What is the syntax of a Razor code block?**

Allows you to include C# statements in a view. @{  }

10. **Describe the diﬀerent roles of action methods and views.**

Action Method - Passes a view model object to the view.
View - Uses the view model object to present content to the user.

11. **Describe the use of the @using statement. Give an example of how you would use it.**

Brings an entire namespace into context.
