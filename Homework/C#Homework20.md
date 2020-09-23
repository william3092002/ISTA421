# File: C# Homework 20
# Name: William Chan
# Date: 16 September, 2020

1. What is a delegate? Explain delegates in terms of pointers and reference types.
	- A delegate is a reference to a method. 
2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
	- delegate void stopMachineryDelegate();
3. How do you create instances of delegates and assign values to the instance? What are the values?
	- private stopMachineryDelegate stopMachinery;
	- this.stopMachinery += folder.StopFolding;
	- memory address to the methods you assigned to your delegates
4. How do you invoke a method that has been added to a delegate?
	- through the instance of the delegate. You invoke it just a like a method.
5. What is an event? Why do we have events?
	- Events enable a class or object to notify other classes or objects when something of interest occurs. The class that sends (or raises) the event is called the publisher and the classes that receive (or handle) the event are called subscribers.
6. How do you declare events?
	- public event SampleEventHandler SampleEvent;
7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
	- you inlude the delegeate name in your event declaration.
	- -=
8. How do you raise an event? How do you declare code that raises an event?
	- You can raise an event by calling it like a method.
	- public delegate void StopMachineryDelegate();
 public event StopMachineryDelegate MachineOverheating;
9. Explain with specificity what happens when an event fires and that event has been attached to a
delegate.
	- Methods assigned to the delegate will be invoked by the order it is assigned.
