Feature: Feature1

A short summary of the feature

@tag1
Scenario: Create Factorial
	Given the input of 4
	When calculating factorial
	Then the result should be 24

Scenario Outline: Create and Calculate Multiple Factorials
	Given the input of <number>
	When calculating factorial
	Then the result should be <factorial>

	Examples: 
	| number | factorial  |
	| 3      | 6          |
	| 10     | 3628800    |
	| 5      | 120        |
	| 6      | 720        |
	| 1      | 1          |
