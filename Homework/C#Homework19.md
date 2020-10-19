# File: C# Homework 19
# Name: William Chan
# Date: 9 September, 2020

1. What is an enumerable collection?
	- it is a collection that implements the System.Collections.IEnumerable interface.
	- a collection you can iterate through with foreach loop. 
2. What properties and methods does the IEnumerable interface contain?
	- IEnumerator GetEnumerator();
	
3. What properties and methods does the IEnumerator interface contain?
	- object Current { get; }
	- bool MoveNext();
	- void Reset();
4. What values does the MoveNext() method return? What does it do?
	- returns a boolean value. 
	- You call the MoveNext method to move the pointer down to the next (first) item in the list
5. What values does the Reset() method return? What does it do?
	- return void
	- you use the Reset method to return the pointer back to before the fi rst item in the list.
6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type
safety?
	- no, it returns an object rather than a specific type. 
	- use generic type interface instead. 
7. Why don’t recursive methods retain state when used with data structures like binary trees?
	- when defining an enumerator, you need to remember where you are in the structure so that subsequent calls to the MoveNext method can update the position appropriately. 
8. How do you define an enumerator?
	- class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
9. What is an iterator?
	- An iterator is a block of code that yields an ordered sequence of values.
10. What does yield do?
	- The yield keyword indicates the value that should be returned by each iteration.