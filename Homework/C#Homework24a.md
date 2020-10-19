# File: C# Homework 24a
# Name: William Chan
# Date: 12 October, 2020

1. What is an asynchronous method? When the book talks about a contract, what is the contract and
who is it with?
	- An asynchronous method is one that does not block the current thread on which it starts to run.
	- expects the method to return control to the calling environment quite quickly and to perform its work on a separate thread.
	- With the application?
2. What can be the problem with decomposing a series of discrete method calls into a set of tasks, such
as we saw in chapter 23?
	- You might end up having a delegate specifying another delegate.
3. What can be the problem with decomposing a series of discrete method calls into a set of continuations?
When does the last continuation “complete” as compared to the previous continuations? What problem
might this cause?
	- The code after the last continuation might be executed before the continuation is completed.
	- If you want your code to run procedurally, it's not going to anymore.
4. What might be the problem with implementing the previous solution as a continuation passing a delegate? What would be your interpretation with this error message: “The application called an interface
that was marshaled for a different thread.”?
	- The issue here is that only the user interface thread can manipulate user interface controls, and now you are attempt-
ing to write to a TextBox control from a different thread—the thread being used to run the Task.
5. The book suggests a solution using a continuation delegate calling another continuation delegate via
an anonymous function. What does the book ientify as a problem with this suggested solution?
	- but it is messy and diffi cult to maintain. You now have a delegate (the continuation)
specifying another delegate.
6. What does the async modifier do? What does the await operator do?
	- The async modifi er indicates that a method contains functionality that can be run
asynchronously.
	- The await operator specifi es the points at which this asynchronous functionality should be performed.
7. What is an awaitable object? Be specific.
	- An awaitable object is a type that provides the GetAwaiter method, which returns an object that in turn pro-
vides methods for running code and waiting for it to complete. It's a task.
8. In a method definition, how do you create and run a Task and return a reference to the Task? What
is the type of such a method? What does the method return?
	- Use Async and Await. Asyncronous method, a reference to the Task that
runs this continuation.
9. How do you define method calls in the implementation of an async method? Specifically, you must
define a task, you must run the task, you must implement the task, and you must await the task.
What is the syntax for doing this?
	- private async Task doFirstLongRunningOperation()
{
Task first = Task.Run(() => { /* code for first operation */ });
Task second = Task.Run(() => { /* code for second operation */ });
await first;
await second;
}
10. What is the difference between decomposing a series of method calls that do not return values, and
a series of method calls that return values? What is the Result property of a method that returns a
value? How do you use the await operator in this circumstance?
	- Notice that because the compiler now
determines the return value of the method, you no longer specify a return value yourself
11. What is the difference between the await operator and the Wait method?
	- The await operator reformats the operands.
	- The wait method blocks the execution of current method.
