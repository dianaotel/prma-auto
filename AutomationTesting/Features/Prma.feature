﻿Feature: PrmaLogin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag @yourtag
Scenario: 1 Add two numbers
	Given I navigate to the login URL
	And I enter valid credentials
	When I go to heatmap

@Dia
Scenario: 2 Steel Request
	Given I navigate to the login URL
	And I enter valid credentials

@dur
Scenario: 3 Add my pickle
	Given I navigate to the login URL
	And I enter valid credentials
	

@mytag @someTag
Scenario Outline: 4 Data Driven Add to login
	Given I navigate to the login URL
	And I enter valid credentials

Examples: 
| Head |
| 2    |
| 3    |