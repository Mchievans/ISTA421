# C# Homework 22

## chapter 22 Overloading Operators 

### Name: Malachi Evans

#### file: C#hw22

#### date: April 09, 2019

------------------------------

1. Explain the difference between the concepts of associativity and precedence.
    + Precedence is the order which is evaluated against other operators while associativity is the order which the problem its self is calculated where right to left or left o right.
2. Explain the difference between the concepts of binary and unary operators.
    + A unary operator has one operand while a binary operator has two.
3. List four constraints imposed by C# with respect to operator overloading.
    + You cannot change the precedence and associativity of an operator
    + You cannot invent new operator symbols
    + You can’t change the meaning of operators when they are applied to built-in types.
    + you can’t overload the dot (.) operator,
4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter types and multiplicity.
    + The operator is public.The operator is static.  Operators cannot use the virtual, abstract, override, or sealed modifiers.A binary operator has two explicit arguments, and a unary operator has one explicit argument. at least one of the parameters must always be of the containing type.
5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?
    + Symmetric is having binary operators of the same type on both sides.
6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain why not.
    + Yes if the first operator in the order of associativity has the same type has a method with the second type as a parameter.This cant not be done if it doesn't have the type in it. 
7. What is the difference between overloading increment and decrement operators for value types and reference types?
    + Value types it works on changing thr original value while reference types it changes the a copy but not the original.
8. Why do we overload some operators in pairs?
    + The operand will call for it and can not be evaluated with out it.
9. What is the difference between widening conversion and narrowing conversion?
    + widening conversion because the result is wider than the original value—it contains at least as much information as the original value, and nothing is lost. a narrowing conversion because the result is narrower than the original value (that is, it can contain less information) and can throw an OverflowException exception if the resulting value is out of the range of the target type.
10. What is the difference between explicit conversion and implicit conversion?
    + If the conversion operator had been declared with explicit, the explicit conversion operator requires a cast.