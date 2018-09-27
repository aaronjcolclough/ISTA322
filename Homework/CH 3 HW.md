1. **The book states, “Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless.” What does it mean for the view to be stateless?**

no memory is held of the view, so when the interaction is complete, it must be started over.

2. **The book identiﬁes two kinds of models. Brieﬂy describe each of them.**

View Models - data transfer between views and controllers
Domain Models - data in business domains as well as the operations, transformations, and rules for manipulating that data

3. **Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.**

The separation between my work life (military) and my home life.

4. **What is a view engine?**

the component responsible for processing a view in order to generate a response for the browser

5. **The book notes that the three-tier structure, or n-tier model, is “the most widely used pattern for business applications.” Why do you think that this is true? An answer like, “Because it works well,” is not a suﬃcient answer to this question.**

Because of its relative ease and minimal complexity.

6. **This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-ViewModel (MVVM). What is the diﬀerence between MVC and MVVM that makes the ﬁrst good for ASP.NET MVC and the second good for UWP?**



7. **Describe the two parts of the dependency injection (DI) design pattern.**

removing dependencies on concrete classes
injecting dependencies declared by a class when instances of it are created

8. **Give an example of loose coupling from your own life experience. This should be a simple, everyday example.**

The way military units interact.

9. **What are the two types of testing discussed in the book?**

unit-testing - testing individual classes separate from the rest of the application
integration testing - testing multiple components up to and including the whole program

10. **What are the seven steps of the test driven development (TDD) workﬂow, as stated in the book?**

- Determine that you need to add a new feature or method to your application.
- Write the test that will validate the behavior of the new feature when it is written.
- Run the test and get a red light
- Write the code that implements the new feature.
- Run the test again and correct the code until you get a green light.
- Refactor the code if required. For example, reorganize the statements, rename the variables, and so on.
- Run the test to confirm that your changes have not changed the behavior of your additions.
