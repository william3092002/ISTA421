# File: C# Homework 21
# Name: William Chan
# Date: 23 September, 2020

1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different
query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?
	- You use SQL for external data and LINQ for internal data.
2. What is the one essential requirement for the datastructures used with LNQ? Why is this requirement
important?
	- implement IEnumerable interface. So you can iterate through the elements.
3. Were does the LINQ Select() method live?
	- Its an extension method of class Enumerable. System.LINQ name space
4. (Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);
	- CustomerFirstNames is a collection of strings that implement IEnumerable interface, 
	
5. (Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr =>
String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);
6. (OrderBy) Explain, token by token, each token in this line of code:
IEnumerable<string> companyNames = addresses.OrderBy(addr =>
addr.CompanyName).Select(comp => comp.CompanyName);
7. (Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);
8. (Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();
9. (Join) Explain, token by token, each token in this line of code: