@hta @login
Feature: LoginHTA
	I login to the new HTA

Scenario: (1) Login to the new HTA
	Given I navigate to the login URL
	And I enter valid prma admin credentials
	Then I should see the landing page


