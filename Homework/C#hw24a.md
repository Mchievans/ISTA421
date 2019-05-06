# C# Homework 2

## chapter 24 Improving response time by performing asynchronous operations

### Name: Malachi Evans

#### file: C#hw24

#### date: May 01, 2019

------------------------------
1. What is an asynchronous method? When the book talks about a contract, what is the contract and who is it with?
    An asynchronous method is one that does not block the current thread on which it starts to run. When an application invokes an asynchronous method, an implied contract expects the method to return control to the calling environment quite quickly and to perform its work on a separate thread. The contact is with the controlling environment (program giving an input). (DOES NOT BLOCK CURRENT THREAD FROM RUNNING)

2. What can be the problem with decomposing a series of discrete method calls into a set of tasks, such as we saw in chapter 23?
    The program will be not usable until the series of methods are complete.

3. What can be the problem with decomposing a series of discrete method calls into a set of continuations? When does the last continuation "complete" as compared to the previous continuations? What problem might this cause?
    Even if they are running on separate threads one still has to wait on the other to complete.
   
4. What might be the problem with implementing the previous solution as a continuation passing a delegate? What would be your interpretation with this error message: \The application called an interface that was marshaled for a different thread."? 
    The problem may be that the delegate the method is referencing is running on a different thread but may not return the value to the thread calling the method.

5. The book suggests a solution using a continuation delegate calling another continuation delegate via an anonymous function. What does the book identify as a problem with this suggested solution? 
    This is difficult to debug and messy.

6. What does the async modier do? What does the await operator do?
    The async modifier indicates that a method contains functionality that can be run asynchronously. The method can be divided into one or more continuations. When these continuations run, they execute on the same thread as the original method call.

7. What is an awaitable object? Be specificc.
     An awaitable object is a type that provides the GetAwaiter method, which returns an object that in turn provides methods for running code and waiting for it to complete.

8. In a method definition, how do you create and run a Task and return a reference to the Task? What is the type of such a method? What does the method return?
    you have to create a method of the type task and in the method body have a task run method that returns a task object and return that task object to the task method.

9. How do you define method calls in the implementation of an async method? Specificly, you must define a task, you must run the task, you must implement the task, and you must await the task. What is the syntax for doing this?
    private async Task doFirstLongRunningOperation()
    {
        Task first = Task.Run(() => { /* code for first operation */ });
        Task second = Task.Run(() => { /* code for second operation */ });
        await first;
        await second;
    }

10. What is the difference between decomposing a series of method calls that do not return values, and a series of method calls that return values? What is the Result property of a method that returns a value? How do you use the await operator in this circumstance?
    if they return values you do not have to specify await to make them run async but if they don't return values then you must use await to make them run async. The result property is a generic property of task. 

11. What is the difference between the await operator and the Wait method?
    The await operator is applied to a task in an asynchronous method to insert a suspension point in the execution of the method until the awaited task completes. The task represents ongoing work. 
    The wait method specifies the amount of time a process should wait before completing 