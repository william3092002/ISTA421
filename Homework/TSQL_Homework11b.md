# File: TSQL Homework 11b
# Name: William Chan
# Date: 5 October, 2020

1. What is dynamic SQL?
	- With SQL Server, you can construct a batch of T-SQL code as a character string and then execute that batch.
2. In executing dynamic SQL, what are the differences between using the EXEC command and the
sp executesp stored procedure?
	- The sp_executesql stored procedure can perform better than EXEC because its parameterization
aids in reusing cached execution plans.
	- sp_executesql supports only Unicode character strings as the input batch of code.
3. What is a SQL injection attack? Give an example of an attack.
	- SQL injection is an attack in which malicious code is inserted into strings that are later passed to an instance of SQL Server for parsing and execution. 
	- https://en.wikipedia.org/wiki/SQL_injection
4. How do you execute the EXEC command? Write a complete example using the TSQLV4 database.
	- DECLARE @sql AS VARCHAR(100);
		SET @sql = 'PRINT ''This message was printed by a dynamic SQL batch.'';';
		EXEC(@sql);
5. Describe the use of input parameters and output parameters for the sp executesql stored procedure.
	- parameters that appear in the code cannot
be considered part of the code—they can only be considered operands in expressions. So, by using
parameters, you can eliminate your exposure to SQL injection.
	- You specify
the Unicode character string holding the batch of code you want to run in the first parameter, which
is called @stmt. You provide a Unicode character string holding the declarations of input and output
parameters in the second input parameter, which is called @params.
6. What are the three kinds of routines that T-SQL recognizes?
	- user-defined functions, stored procedures, and triggers.
7. What is the difference between a stored procedure, a user defined function, and a trigger?
	- The purpose of a user-defined function (UDF) is to encapsulate logic that calculates something,
possibly based on input parameters, and return a result.
	- Stored procedures are routines that encapsulate code. They can have input and output parameters,
they can return result sets of queries, and they are allowed to have side effects. Not only can you
modify data through stored procedures, you can also apply schema changes through them.
	- A trigger is a special kind of stored procedure—one that cannot be executed explicitly. Instead, it’s
attached to an event. Whenever the event takes place, the trigger fires and the trigger’s code runs. SQL
Server supports the association of triggers with two kinds of events: data manipulation events (DML
triggers) such as INSERT, and data definition events (DDL triggers) such as CREATE TABLE.
8. What is the primary function of a UDF? This is not specifically stated in the book but is clear fro the
context of the discussion n the book.
	- 
9. (Not in book.) What are side effects, and why are they dangerous?
	- if your method cause something happen out side of the scope, it's a side effect.
10. What is the principle distinction between a UDF and a stored procedure?
	- UDF cannot have side effects
11. Given that you cannot execute a trigger explicitly, what is the advantage of using triggers?
	- 
12. In using error handling in T-SQL, can you mimic a finally block? If so, how?
	- Just have a statement at the end of your query try catch block. 
13. Write a user defined function that returns a Booleans as to whether a customer may purchase alcohol
as of the instant that the function runs.
14. Write a trigger that places a customer in the OFF LIMITS table if he attempt to purchase alcohol
when he is underage.
15. Write a stored procedure that deletes customers from the OFF LIMITS table when they have reached
their 21st birthday.