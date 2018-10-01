1. **What is a type parameter?**



2. **What does a type parameter do?**

Type parameters specify the types of objects on which they operate.

3. **How many type parameters can a generic class have?**

Multiple

4. **What is the diﬀerence between a generic class and a generalized class?**

Generalized classes are run as written, with generic classes the compiler creates a new class each time to have the correct functionality.

5. **What is a constraint? How do you specify a constraint?**

A way to ensure that the type parameter used by the generic class identifies a type that provides certain methods.

6. **What is a generic method? How do you deﬁne a generic method?**

A way to specify the types of the parameters and the return type by using a type parameter like that used when you deﬁne a generic class. . Method<T>()

7. **What do we mean when we say that a generic type interface is invariant?**

where

8. **What do we mean when we say that a generic type interface is covariant?**

As long as there is a valid conversion from one type to another or the first type derives from the second.

9. **Does covariance work with value types? Does it work with reference types?**

As long as there is a valid conversion from one type to another or the first type derives from the second.

10. **What do we mean when we say that a generic type interface is contravariant?**

 It enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A.
