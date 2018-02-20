@hta @login
Feature: LoginHTA
	

#Scenario: (1) Login to the new HTA
#	Given I navigate to the login URL
#	And I enter valid prma admin credentials
#	Then I should see the landing page
#
#
#Scenario Outline: (2) verify error message on invalid email address
#	Given I navigate to the login URL
#	And I enter email address '<invalid_email>'
#	Then I should see the error message '<message>' for invalid email
#
#Examples: 
#	| invalid_email | message               |
#	| invalid_email | Must be a valid email |
#
#
#Scenario Outline: (3) verify error message on missing password
#	Given I navigate to the login URL
#	And I enter email address '<valid_email>'
#	Then I should see the error message '<message>' for required password
#
#Examples: 
#	| valid_email		   | message |
#	| valid_email@test.com | Required |


Scenario Outline: (4) Verify error message on invalid login 
	Given I navigate to the login URL
	And I enter invalid credentials '<email>' '<password>'
	Then I should see the error message '<message>' for invalid credentials

Examples: 
	| email                        | password | message					  |
	| invalid_credentials@test.com | a        | Invalid Email or Password |



