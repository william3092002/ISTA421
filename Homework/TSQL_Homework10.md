# File: TSQL Homework 10
# Name: William Chan
# Date: 21 September, 2020

1. What is the purpose of transactions? Why do we use transactions in SQL scripts?
	- A transaction is a unit of work that might include multiple activities that query and modify data and
that can also change the data definition.
2. Briefly describe each of the ACID properties.
	- Atomicity, A transaction is an atomic unit of work. Either all changes in the transaction take
place or none do.
	- Consistency, The term consistency refers to the state of the data that the relational database
management system (RDBMS) gives you access to as concurrent transactions modify and
query it.
	- Isolation ensures that transactions access only consistent data. You control what
consistency means to your transactions through a mechanism called isolation levels.
	- Durability, Data changes are always written to the database’s transaction log on disk before
they are written to the data portion of the database on disk.
3. What do we mean when we talk about the granularity of locks?
	- The granularity of locks in a database refers to how much of the data is locked at one time. In theory, a database server can lock as much as the entire database or as little as one column of data.
4. What do we mean when we talk about the modes of locks?
	- Different type of locks, shared or exclusive.
	- If a lock is acquired on a data item to perform a write operation, it is an exclusive lock.
5. In your ownh words, describe blocking, and give an example.
	- Blocking occurs when two or more rows are locked by one SQL connection and a second connection to the SQL server requires a conflicting on lock on those rows. This results in the second connection to wait until the first lock is released.
6. What are the properties of locks? That is, list the column name and column type of the fields in
sys.dm tran locks.
	- https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-tran-locks-transact-sql?view=sql-server-ver157. 
7. What are the properties of sessions? That is, list the column name and column type of the fields in
sys.dm exec connections.
	- https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sessions-transact-sql?view=sql-server-ver15
8. What are the requests of sessions? That is, list the column name and column type of the fields in
sys.dm exec requests.
	- https://docs.microsoft.com/en-us/sql/relational-databases/system-dynamic-management-views/sys-dm-exec-sessions-transact-sql?view=sql-server-ver15
9. What is an isolation level? Give an example of the operation of an isolation level.
	- SQL Server isolation levels are used to define the degree to which one transaction must be isolated from resource or data modifications made by other concurrent transactions. The different Isolation Levels are: Read Uncommitted.
10. (Not in the book.) What do we mean when we say that an object is serializable?
	- Serialization in C# is the process of converting an object into a stream of bytes to store the object to memory, a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed. 
11. What is an deadlock? Give an example of a deadlock?
	- A deadlock occurs when 2 processes are competing for exclusive access to a resource but is unable to obtain exclusive access to it because the other process is preventing it.
	- 