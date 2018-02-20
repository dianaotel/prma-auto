@hta @landingPage
Feature: LandingPage

Scenario Outline: (1) Check landing page information
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	Then I should see the landing page with title '<title>'
	And I should see project cards

Examples: 
	| title |
	| All Projects |


Scenario Outline: (2) Check the contents of a project card
	Given I navigate to the login URL
	And I login with valid client admin credentials
	Then I should see project cards
	And the first project card contains '<title>', '<subtitle>', '<description>', '<req_summary>', '<req_met>', '<req_metKV>', '<req_partial>', '<req_partialKV>', '<req_not>', '<req_notKV>'

Examples:
	| title                | subtitle                | description    | req_summary									   | req_met | req_metKV | req_partial | req_partialKV | req_not | req_notKV |
	| Automation Project 1 | for Automation Disease1 | DO NOT DELETE. | Requirement Summary: (1 key of 2 requirements) | 1       | 0		 | 0           | 0			   | 1       | 1		 |
