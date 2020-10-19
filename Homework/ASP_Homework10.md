
# File: ASP.NET Core Homework 10
# Name: William Chan
# Date: 30 September, 2020

1. What is Blazor?
	- Blazor relies on a Razor Page to provide the initial content to the browser, which includes the JavaScript code that connects to the
server and renders the Blazor HTML content.
2. What do the methods AddServerSideBlazor() and MapBlazorHub() do?
	- The AddServerSideBlazor method creates the services that Blazor uses, and the MapBlazorHub method registers the Blazor
middleware components.
3. Where are Blazor files conventionally located?
	- Pages folder
4. What is the purpose of the Routed.razor file?
	- The component element is used to insert a Razor Component in the output from the Razor Page.
5. (Not in book) What is the purpose of the <NavLink> element, and what does it do?
	- give you multiple links
6. What is the purpose of an @code { ... } block? Where are they located and what is their purpose?
	- The view part of the component is supported by the statements in the @code section.
7. How can a single component be configured to present two different sets of data without the need to
duplicate code and content?
	- View Model
8. What is CRUD? What are the equivalent SQL statements?
	- Create, Read, Update and Delete.
	- Set, Select, Update, Delete
9. Does Blazor use the same approach to validation as the rest of ASP.NET Core? If not, how is Blazor
different?
	- Blazor uses the same approach to validation as the rest of ASP.NET Core
10. What is the purpose of the Inject attribute?
	- The component uses the Inject attribute to declare that it requires an implementation of the IStoreRepository interface,
which is one of the ways that Blazor provides access to the application’s services.
11. What is the NavigationManager class? What does it do?
	- which is used to programmatically navigate between components without
triggering a new HTTP request.