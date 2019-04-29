# C# Homework 23

## chapter 23 Decoupling application logic and handling events

### Name: Malachi Evans

#### file: C#hw23

#### date: April 16, 2019

------------------------------

1 List two reasons for multitasking, and explain the rationale for them.
 + To improve responsiveness by being able to handle more than one task at a time.
 + To improve scalability by creating more instances of task running in parallel

2 Explain Moore's law. What does Moore's law have to do with multitasking?
 + computer chips amount of transistors double every two years making for faster connections. this speeds up multitasking by completing processes faster ans the price of chips has dropped so you can multiple in a computer. 

3 In UWP, what namespace is used as the container for the multitasking methods
 + system.threading.task

4 What is the difference between tasks and threads? Explain.
 + task is a object is an object that runs in a block of code. Thread is multiple task run in parallel a thread distinguishes how many and and is a class it is the block of code.

5 What is the ThreadPool?
 + a class that implements a a number of optimizations and work stealing algorithms to schedule threads successfully.

6 What parameters does the Task() constructor take?
 + an action delegate a method that does not return a value 

7 How do you start a thread?
 + using thr task.run method passing it  a delegate to the task constructor 

8 What is the difference between the Start() and Run() methods?
 + start is used after created an class and signals when to start the task while run will start the task immediately.

9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel?
Explain.
 + task you have complete control and control the number of task the application creates you synch the code to run while parallel class creates its own set of task and synch them automatically.

10 Explain how manual cancellation works using a cancellation token.
 + a structure that represents a request to cancel one ore more task. It has a boolean property isCancledRequested that a task checks periodically and if true cancels

