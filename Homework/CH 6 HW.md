1. **What is the primary idea that underlies Dependency Injection?**



2. **Describe the role of interfaces in implementing a dependency injection container.**



3. **List the three stages of building basic Ninject functionality, and brieﬂy deﬁne each stage.**

1- Prepare Ninject for use - create an instance of a Ninject kernel
2- Configure the kernel - make Ninject understand which implementation objects you want to use for each interface
3- Create an object

4. **What is the purpose of a custom dependency resolver?**

Ensures the MVC Framework uses Ninject whenever it creates an object.

5. **What is the purpose of conditional binding? Describe how it works.**

The bindings specify what class Ninject should use as implementation of an interface when creating a particular object.

6. **Why is setting the object scope important when using dependency injection?**

Lets you control the lifecycle of the objects you create.

7. **Brieﬂy describe the Test Driven Development approach in developing an application.**

TDD is a development approach where a test is written first, then the code is written to fulfill the test, followed by refactoring.

8. **Consider the Assert class. How do you access the methods of that class?**

using Microsoft.VisualStudio.TestTools.UnitTesting;

9. **Why is it useful to mock objects when developing software?**

Because they simulate the functionality of real objects from your project in a specific and controlled way.

10. **Brieﬂy describe the two main issues that arise when attempting to do Unit Tests without the aid of some sort of mocking library.**

The tests will fail if the discount logic in the implementation changes.
If the test fails, you won't know where the problem is.
