# File: C# Homework 22
# Name: William Chan
# Date: 30 September, 2020

1. Explain the difference between the concepts of associativity and precedence.
	- Precedence is the priority for grouping different types of operators with their operands. Associativity is the left-to-right or right-to-left order for grouping operands to operators that have the same precedence.
2. Explain the difference between the concepts of binary and unary operators.
	- An operator can act on one operand, and then it is called a unary operator, or, it can act on two operands and then it is called a binary operator.
3. List four constraints imposed by C# with respect to operator overloading.
	- You cannot change the precedence and associativity of an operator. Precedence and
associativity are based on the operator symbol (for example, +) and not on the type (for example, int) on which the operator symbol is being used. Hence, the expression a + b * c is
always the same as a + (b * c) regardless of the types of a, b, and c.
	- You cannot change the multiplicity (the number of operands) of an operator. For example, * (the symbol for multiplication) is a binary operator. If you declare a * operator for your own type, it
must be a binary operator.
	- You cannot invent new operator symbols. For example, you can’t create an operator symbol such as ** for raising one number to the power of another number. You’d have to defi ne a
method to do that.
	- You can’t change the meaning of operators when they are applied to built-in types. For
example, the expression 1 + 2 has a predefi ned meaning, and you’re not allowed to override this
meaning. If you could do this, things would be too complicated.
4. What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter
types and multiplicity.
	- 
5. What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?
	- a symmetric overloaded binary operator's arguments are in the same type.
	- a non-symmetric overloaded binary operator's srgument are different types. 
6. Can you overload compound assignment operators? If so, please state how you do so. If not, explain
why not.
	- No. 
	- Becasue there's no syntax that supports it. 
7. What is the difference between overloading increment and decrement operators for value types and
reference types?
	- 
8. Why do we overload some operators in pairs?
	- becasue some operators only existing in pairs. ==, !=, <, >, <=, >=
9. What is the difference between widening conversion and narrowing conversion?
	-
10. What is the difference between explicit conversion and implicit conversion?
	- explicit conversion requires casting syntax narrowing conversion. 