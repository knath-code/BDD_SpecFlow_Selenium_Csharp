Feature: MyTestExp
	
@testExp
Scenario: Add_two_numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result of 50 and 70 should be 120


Scenario Outline: Add_Number
	Given the first number is <Number1>
	And the second number is <Number2>
	When the two numbers are added
	Then the result of <Number1> and <Number2> should be <Result>
Examples: 
| Number1 | Number2 | Result |
| 2       | 3       | 5      |
| 4       | 6       | 10     |