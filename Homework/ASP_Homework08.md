# File: ASP.NET Core Homework 7
# Name: William Chan
# Date: 10 September, 2020

1. For chapter 8 of the ASP.NET Core 3 book, what are the three requirements as the author describes
them?
	- Enhance the Index action method in the HomeController class so that it can filter the Product objects in the
repository
	- Revisit and enhance the URL scheme
	- Create a category list that will go into the sidebar of the site, highlighting the current category and linking to
others
2. When adding new routes in Startup.cs, in what order should you add the new routes? Why?
	- catepage, page, catergory, pagination
	- Routes are applied in the order in which they are defined, and you will get some odd effects if you change the order
3. Does ASP.NET Core 3 handle outgoing HTTP requests as well as incoming requests? If so, what is one
reason that this is important?
	- yes, middleware
4. What is a view component? Why do you use view components?
	- A view component is a C# class that provides a small amount of reusable application logic with the ability to select and display Razor
partial views.
 	-  to create items such as reusable navigation controls
5. When you use a view component in a view, how is the view component referenced, and what nameing
convention do you use?
	- InvokeAsync
6. When ASP.NET Core 3 needs to create a instance of a component, how does it know what value to give
the new instance?
7. How do ASP.NET Core 3 components get information about a user’s current HTTP request? Why
would it be important for the component to get this information?
8. What does the PathAndQuery extension method do with an incoming HTTP request? What does the
method do with the return value? What is the return value?
	- The PathAndQuery extension method operates on the HttpRequest class, which ASP.NET Core uses to describe an HTTP
request. The extension method generates a URL that the browser will be returned to after the cart has been updated, taking into
account the query string, if there is one. 
9. What is session state?
	- enables you to store and retrieve values for a user as the user navigates ASP.NET pages in a Web application. 
10. What three types does a session state store? Suppose you want to store data that has a type that
session state does not store, is it possible to do so? If so, how do you do it?
