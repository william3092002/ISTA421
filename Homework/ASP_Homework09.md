# File: ASP.NET Core Homework 9
# Name: William Chan
# Date: 24 September, 2020

1. The text contains the folowing:
I defined a Cart model class in the previous chapter and demonstrated how it can be stored
using the session feature, allowing the user to build up a set of products for purchase. The
responsibility for managing the persistence of the Cart class fell to the Cart Razor Page,
which has to deal with getting and storing Cart objects as session data.
The problem with this approach is that I will have to duplicate the code that obtains and
stores Cart objects in any other Razor Page or controller that uses them.
In your own words, describe thee “problem” the author identifies and explain why the proposed solution
is not satisfactory.
	- 
2. What are services, and how do they work.
	- Dependency injection. 
3. (Not in book) The author states, “The static GetCart method is a factory for creating SessionCart
objects and providing them with an ISession object so they can store themselves.” What does he
mean by calling the GetCart method a factory?
4. What does the AddScoped method do?
	- The AddScoped method registers the service with a scoped lifetime, the lifetime of a single request.
5. How is an HTML form element with a tag handler of asp-page-handler programmed to execute the
functionality exposed by the form?
	- 
6. What does the BindNever attribute do? Why is it useful?
7. What does the tag helper <asp-for> do?
8. Using Entity Framework, how do you add a new model to your database?
9. What, speciically, does this command do: dotnet ef migrations add Model?
10. How does Entity Framework understand to load data that is contained in multiple tables? For example,
suppose you want to load data from both Orders and Order.Details. What LINQ methods accomplish
this?
11. Why do we validate data on the client side? Why do we validate data on the server side? What are
the advantages and disadvantages of cliet side validation and server side validation?

