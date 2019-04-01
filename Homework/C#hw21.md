# C# Homework 21

## chapter 21 Querying in-memory data by using query expressions

### Name: Malachi Evans

#### file: C#hw21

#### date: March 26, 2019

------------------------------

1. What is the diﬀerence in the purposes of SQL and LINQ? In other words, why do we need two diﬀerent query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary? 
    + SQL deals with data in storage while LINQ deals with data in memoary. No it doesnt replace SQL and it doesnt make LINQ unnecesary. 
2. What is the one essential requirement for the datastructures used with LNQ? Why is this requirement important?
    + The data stcrtuce must implement the IEnumerable or IEnumerable generic interface. 
3. Were does the LINQ Select() method live?
    + System.Collections.Generic.IEnumerable<TResult> Select<TSource,TResult> 
4. (Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);
+ This string iterates through the cusotmers and only selects the customerfirst names 
5. (Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);
+ This selects the company name "uscomp" where address equals country unted satates from uscompanes
6. (OrderBy) Explain, token by token, each token in this line of code:
IEnumerable<string> companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName); 
+ This query seleects the company name and orders by address.
7. (Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);
+ This selects companies that were grouped by country.
8. (Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();
+ this selects the distinct countries and gives a count of how many times they occur.
9. (Join) Explain, token by token, each token in this line of code:
var companiesAndCustomers = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs => custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) => new {custs.FirstName, custs.LastName, addrs.Country });
+ 
10. Explain the diﬀerence between a deferred collection and a static, cached collection.
    + a static, cached collection. This collection is a copy of the original data and will not change if the data in the collection changes. LINQ provides the ToList method to build a static List object containing a cached copy of the data.LINQ also provides the ToArray method that stores the cached collection as an array.