# C# Homework 20

## chapter 20 Decoupling application logic and handling events

### Name: Malachi Evans

#### file: C#hw20

#### date: April 02, 2019

------------------------------

1. What is a delegate? Explain delegates in terms of pointers and reference types. 
    + A delegate is a reference to a method. 
     --------its is a stored memory location that can point to one or several memory locations.--------  
2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
    + the delegate keyword followed by the return type the delegate name then parameter list(methods) public delegate int MyDelegate (string s) 
3. How do you create instances of delegates and assign values to the instance? What are the values?
    +  by using new then the delegate name along with the parameter (method) the value is the return of the method
4. How do you invoke a method that has been added to a delegate?
    + by passing the delegate to another method  (the += operator)
5. What is an event? Why do we have events?
    + events define and trap significant actions. To handle significant actions.
6. How do you declare events?
    + declare an event in a class intended to act as an event source. event the delegate type name and then the event name 
7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
    + += operator and then the delegate. –= operator. 
8. How do you raise an event? How do you declare code that raises an event?
    + by calling it like a method and by using an if statement and checking it against null.
9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.
    + It can ony be raised by methods in the class that defines it.
