Feature: Project Objective
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: (1) Verify url and page title
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	Then I should see the the Project Objective page with URL '<url>' and title '<title>'

Examples: 
	| project_title                    | url							   | title			   |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | Project Objective |


Scenario Outline: (2) Verify Objectives edit button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	And I click on the Objectives edit button
	Then the Objectives editor is displayed

Examples: 
	| project_title                    | url							   |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective |


Scenario Outline: (3) Verify Objectives Save button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	And I click on the Objectives edit button
	And I write text '<text>' inside the Objectives editor
	And I click on the Objectives Save button
	Then the text '<text>' is saved

Examples: 
	| project_title                    | url                               | text            |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | This is a test. |
