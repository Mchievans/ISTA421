# C# Homework 2

## chapter 24 Improving response time by performing asynchronous operations

### Name: Malachi Evans

#### file: C#hw24

#### date: May 01, 2019

------------------------------

1. What are the two scenarios in which you can use PLINQ to speed up operations? Why does using PLINQ in these scenarios speed up processing?
    * PLINQ is ideal for scenarios that involve data sets with large numbers of elements, or if the criteria specified for matching data involve complex, computationally expensive operations.
    by dividing a data set into partitions and then using tasks to retrieve the data that matches the criteria specified by the query for each partition in parallel. When the tasks have completed, the results retrieved for each partition are combined into a single enumerable result set. 

2. How doesAsParallel qualify as an extension method? First, explain what an extension method is and how you dene extension methods, and them explain why AsParallel qualifieses as an extension method.
    * 

3. How do you cancel a PLINQ query before it finishes? Be specific with respect to the variables and methods used for the cancellation operation, and how the variables abd methods are used.
    *  specify a CancellationToken object from a CancellationTokenSource and use the WithCancellation extension method of the ParallelQuery.

4. Why is it important to synchronize concurrent access to a server? Give an example of a specific condition that will cause an error in your application if concurrent access is not synchronized.
    * if a store with limited amount of stock is not being updated.

5. What does the lock statement do?
    * The lock statement attempts to obtain a mutual-exclusion lock over the specified object (you can actually use any reference type, not just object), and it blocks if this same object is currently locked by another thread. When the thread obtains the lock, the code in the block following the lock statement runs. At the end of this block, the lock is released

6. This is not in the book. Dene mutex, dene semaphore, and explain the difference between them.
     * Mutex is a mutual exclusion object that synchronizes access to a resource. It is created with a unique name at the start of a program. The Mutex is a locking mechanism that makes sure only one thread can acquire the Mutex at a time and enter the critical section.
     A Mutex is different than a semaphore as it is a locking mechanism while a semaphore is a signalling mechanism. A binary semaphore can be used as a Mutex but a Mutex can never be used as a semaphore.
     A semaphore is a signalling mechanism and a thread that is waiting on a semaphore can be signaled by another thread. 
7. What does it mean to say that some collection classes are not thread safe? Explain how not being thread safe may lead one of these collection classes to produce a malfunction in the program.
    * it is highly probable that some of the calls to Add will interfere with one another and cause some corruption.  

8. Explain how thread safe collection classes are made thread safe.
    * 
9. Why are thread safe classes slower than non-thread safe classes? Be specific.
    * It takes a significant amount of resources to lock a collection and make it thread safe.
