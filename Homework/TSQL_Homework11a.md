# File: TSQL Homework 11a
# Name: William Chan
# Date: 27 September, 2020

1. Why do we use variables in T-SQL? How do you declare and initialize T-SQL variables? Can you
declare and initialize a variable in a single step?
	- A name location in memory that holds a value.
	- Use Declare key word.
	- Yes, use declare and As key word.
2. Why is the assignment SET method for setting a variable safer than the assignment SELECT method?
	- The SET statement is safer than the assignment SELECT because it requires you to use a scalar subquery to pull data from a table.
3. Describe what is meant by a batch file in T-SQL? What is the difference between batches and transactions?
	- A batch is one or more T-SQL statements sent by a client application to SQL Server for execution as a
single unit.
	- A transaction is an atomic unit of work. A batch can have multiple transactions, and a transaction can be submitted in parts as multiple batches.
4. Can a transaction be split between multiple batches? Can a batch be split between multiple transactions? Explain.
	- yes.
	- yes.
5. What is meant when the book says that “a batch is a unit of resolution?” Explain binding.
	- This means that checking the existence of objects and columns happens at the batch level.
	- binding is associating objects and implementations with names in programming language so that those objects and implementtions can be accessed by the names.
6. What is the scope of variables with respect to T-SQL batches?
	- only the current batch.
7. Give a practical example of the use of the GO n operator that is not in the book.
	- 
8. How to you delimit if ...else constructions that contain multiple statements?
	- with begin and end.
9. Does T-SQL provide a SWITCH ...CASE type of construct? See chapter 2 if you don’t recall. If it
exists, is it interchangeable with the if ...else construct?
	- yes.
	- no. If else is a programming construct while the switch statement is an expression.
10. What is the difference between a relation and a cursor?
	- a relation is a set but a cursor is not necessarily a set.
	- a nonrelational result with order guaranteed among rows.
11. What are the specific steps to use a cursor? List the steps.
	- 1. Declare the cursor based on a query.
	- 2. Open the cursor.
	- 3. Fetch attribute values from the first cursor record into variables.
	- 4. As long as you haven’t reached the end of the cursor (while the value of a function called
@@FETCH_STATUS is 0), loop through the cursor records; in each iteration of the loop, perform
the processing needed for the current row, and then fetch the attribute values from the next
row into the variables.
	- 5. Close the cursor.
	- 6. Deallocate the cursor.
12. What is the scope of a local temporary table?
	- A local temporary table is destroyed automatically by SQL Server when the creating level in the call stack goes out of scope.
13. When are global temporary tables destroyed? What is the main difference between local temporary
tables and global temporary tables?
	- 
14. Under what conditions would you use a table variable instead of a local temporary table? Why would
you refer to use a local temporary table instead of a table variable?
	- if you have large amount of data, temporary table works better.
	- if one is faster than the other. 
15. What is a table type? What is the syntax for creating a table type? What is the syntax for using a
table type?
	- 