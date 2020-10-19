# File: C# Homework 22
# Name: William Chan
# Date: 7 October, 2020

1. List two reasons for multitasking, and explain the rationale for them.
	- To improve responsiveness, it does not make sense to have a program burn CPU cycles waiting for the operation to complete when the program could be doing something more useful instead (such as responding to user input).
	- To improve scalability, If an operation is CPU bound, you can improve scalability by making effi cient use of the processing resources available and using these resources to reduce the
time required to execute the operation.
2. Explain Moore’s law. What does Moore’s law have to do with multitasking?
	- the number of transistors that can be placed inexpensively on an integrated circuit will increase exponentially, doubling approximately every two years.
	- most modern processors now have two or more processor cores. Effectively,
chip manufacturers have put multiple processors on the same chip and added the necessary logic to enable them to communicate and coordinate with one another.
3. In UWP, what namespace is used as the container for the multitasking methods?
	- System.Threading
4. What is the difference between tasks and threads? Explain.
	- Task is the degree of paralleliztion
	- Thread is the units of paralleliztion.
5. What is the ThreadPool?
	- a thread pool maintains multiple threads waiting for tasks to be allocated for concurrent execution by the supervising program.
6. What parameters does the Task() constructor take?
	- Action delegate 
7. How do you start a thread?
	- Thread.start();
8. What is the difference between the Start() and Run() methods?
	- The difference is that when program calls start() method, a new thread is created and code inside run() is executed in the new thread: while if you call run() method directly, no new thread will be created and code inside run() will execute in the current thread directly.
9. What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel?
Explain.
	- With the Parallel class, you can parallelize some common programming constructs without having to redesign an application.
	- By using the Task class, you have complete control over the number of tasks your application creates.
10. Explain how manual cancellation works using a cancellation token
	- You create a cancellation token by instantiating a CancellationTokenSource object, which manages cancellation tokens retrieved from its CancellationTokenSource.