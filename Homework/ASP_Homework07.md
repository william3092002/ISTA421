# File: ASP.NET Core Homework 7
# Name: William Chan
# Date: 10 September, 2020

1. For the Sports Store application, what requirements does the author identify for implementation?
	- MVC and Views/Home, Views/Shared folders.
2. What is the purpose of the Startup class in ASP.NET Core applications?
	- The Startup class is responsible for configuring the ASP.NET Core application.
3. What is the purpose of the CofitureServices method in the Startup class?
	- The ConfigureServices method is used to set up objects, known as services, that can be used throughout the application and that are accessed through a feature called dependency injection
4. What is a request pipeline and how does it work?
	- It is where ASP.NET Core receives and passes HTTP requests. 
	- it is is populated with middleware components registered in the Configure method.
5. What is the View Start class and how do we use it?
	- The view start file tells Razor to use a layout file in the HTML that it generates, reducing the amount of duplication in views.
	- This file defines a simple HTML document into which the contents of other views will be inserted by the @RenderBody
expression. 
6. What is the feature in ASP.NET Core that generates the database schema for us? What does the file
created by this feature contain?
	- Migration. Migrastions folders.
7. When ASP.NET Core sees that a controller instance needs to be created, and that the controller object
required another object that iplements some interface, how does it determine which interface should b
e implemented?
	- ASP.NET Core consults the configuration in the Startup class, in another word dependency injection.
8. Explain how the paging mechanism works. How does the application calculate the number of pages
required? How is this data passed to the view?
	- Skip((productPage - 1) * PageSize)
	- action method
9. How does the book describe dependency injection? How is dependency injection used?
	- dependency injection means that the controller will continue to work without changes.
	- dependency will be supplied as a parameter. 
10. How are the routes in MapDefaultControllerRoute() method arranged? Why is this important?
	- Controller = "Home", action = "Index" 
	- so the computer knows which controller to go to and which action method to invoke.
