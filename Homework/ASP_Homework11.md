# File: ASP.NET Core Homework 11
# Name: William Chan
# Date: 8 October, 2020

1. How are user authentication and authorization handled in ASP.NET?
	- ASP.NET Core Identity system
2. What ASP.NET package supports the database functionality backing the identity system?
	- AspNetCore.Identity.EntityFrameworkCore
3. In our Sports Store application, what is the connection string that allows access to our identity
database?
	- "IdentityConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Identity;MultipleActiveResultSets=true"
4. What methods are required to configure the middleware that supports user authentication and authorization?
	- app.UseAuthentication();
	- app.UseAuthorization();
5. When you have multiple databases supporting one ASP.NET application, how do you ensure that
specific components use the correct database?
	- used the -context argument to specify the name of
the context class associated with the database that I want to work with
6. (not in book) In what namespace is the UserManager<T> class located? What is the purpose of the
class? What interface(s) does the class require?
	- Microsoft.AspNetCore.Identity 
	- Provides the APIs for managing user in a persistence store
	- IDisposable
7. How are authentication credentials submitted to the application server? What services does the login
manager use in submitting the authentication credentials?
	- Authentication credentials are submitted to the POST version of the Login method, which uses the
UserManager<IdentityUser> and SignInManager<IdentityUser> services that have been received through the controller’s
constructor to authenticate the user and log them into the system.
8. How does an ASP.NET application determine the environment in which it is running?
	- by reading the environment variables 
9. How do you define configuration settings for differentenvironments, such as development or production?
	- Project => property => debug
10. (not in book) What is Docker? What is a container?
	- Docker is a set of platform as a service products that use OS-level virtualization to deliver software in packages called containers.
	- Containers are isolated from one another and bundle their own software, libraries and configuration files; they can communicate with each other through well-defined channels.
