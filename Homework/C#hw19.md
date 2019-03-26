# C# Homework 19

## chapter 19 Enumerating Collections

### Name: Malachi Evans

#### file: C#hw18

#### date: March 19, 2019

------------------------------

1. What is an enumerable collection?
    + a collection that implements the System.Collections.IEnumerable interface. 
2. What properties and methods does the IEnumerable interface contain?
    + IEnumerator GetEnumerator();
3. What properties and methods does the IEnumerator interface contain?
    + object Current { get;}
    + bool MoveNext();
    + void Reset();
4. What values does the MoveNext() method return? What does it do?
    + true if there is another item and false if not. It moves the pointer down to the next item in the list.
5. What values does the Reset() method return? What does it do?
    + it returns the pointer back to before the first item in the list.
6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?
    + no they are not, they return a object and not a specfic type. Using the generic type.
7. Why don’t recursive methods retain state when used with data structures like binary trees?
    + Encapsulation.
8. How do you deﬁne an enumerator?
    + By implementing the methods of the IEnumerator from scratch.
9. What is an iterator?
    + an iterator is a block of code that returns an ordered sequence of values.
10. What does yield do?
    + it returns a value from each iteration but halts afterwards (lazy evaluation) doesnt evaluate until it is called. 