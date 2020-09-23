# File: TSQL Homework 9
# Name: William Chan
# Date: 13 September, 2020

1. What is a temporal table?
	- temporal table is a type of user table designed to keep a full history of data changes to allow easy point in time analysis.
2. Under what circumstances would you use a temporal table? Temporal tables are in widespread use in
certain kinds of businesses.
	- When you need to be able to access historical states of the data. 
	- Perhaps you need these states for auditing, point-in-time analysis, comparing current states
with older states, slowly changing dimensions (details of which you can find in the Wikipedia article
at https://en.wikipedia.org/wiki/Slowly_changing_dimension), restoring an older state of rows because
of accidental deletion or updating, and so on. 
3. What are the semantics of a temporal table? There are seven of them.
	- A primary key
	- Two columns defined as DATETIME2 with any precision, which are non-nullable and represent the start and end of the row’s validity period in the UTC time zone
	- A start column that should be marked with the option GENERATED ALWAYS AS ROW START
	- An end column that should be marked with the option GENERATED ALWAYS AS ROW END
	- A designation of the period columns with the option PERIOD FOR SYSTEM_TIME (<startcol>, <endcol>)
	- The table option SYSTEM_VERSIONING, which should be set to ON
	- A linked history table (which SQL Server can create for you) to hold the past states of modified rows
4. How do you search a history table?
	- write select query with FOR SYSTEM_TIME clause.
5. How do you modify a history table?
	- write an Alter query specify the data with SYSTEM_TIME
6. How do you delete date from a history table? Why would you want to delete data from a history table?
	- You delete data in the current table with a regular DELETE statement. The end period column for deleted rows will be populated with the begin time of underlying transaction. You cannot directly delete rows from history table while SYSTEM_VERSIONING = ON. Set SYSTEM_VERSIONING = OFF and delete rows from current and history table but keep in mind that way system will not preserve history of changes. 
7. How do you search a history table?
	- write select query with FOR SYSTEM_TIME clause.
8. How do you query all data from both a history file and the current data?
	- 
9. How do you drop a temporal table?
	- set system_versioning = off