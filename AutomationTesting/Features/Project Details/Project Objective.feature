Feature: Project Objective

#Scenario Outline: (1) Verify url and page title
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the Project Objective page '<url>'
#	Then I should see the the Project Objective page with URL '<url>' and title '<title>'
#
#Examples: 
#	| project_title                    | url							   | title			   |
#	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | Project Objective |
#
#
#Scenario Outline: (2) Verify Objectives edit button
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the Project Objective page '<url>'
#	And I click on the Objectives edit button
#	Then the Objectives editor is displayed
#
#Examples: 
#	| project_title                    | url							   |
#	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective |
#
#
#Scenario Outline: (3) Verify Objectives Save button
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the Project Objective page '<url>'
#	And I click on the Objectives edit button
#	And I write text '<text>' inside the Objectives editor
#	And I click on the Objectives Save button
#	Then the Objectives text '<text>' is saved
#
#Examples: 
#	| project_title                    | url                               | text            |
#	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | This is a test. |


Scenario Outline: (4) Verify Objectives Cancel button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	And I click on the Objectives edit button
	And I write text '<text>' inside the Objectives editor
	And I click on the Objectives Cancel button
	Then the text is not saved

Examples: 
	| project_title                    | url                               | text            |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | This is a test. |


Scenario Outline: (5) Verify Methodology edit button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	And I click on the Methodology edit button
	Then the Methodology editor is displayed

Examples: 
	| project_title                    | url							   |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective |


Scenario Outline: (6) Verify Methodology Save button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	And I click on the Methodology edit button
	And I write text '<text>' inside the Methodology editor
	And I click on the Methodology Save button
	Then the Methodology text '<text>' is saved

Examples: 
	| project_title                    | url                               | text            |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | This is a test. |


Scenario Outline: (7) Verify Objectives Cancel button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the Project Objective page '<url>'
	And I click on the Objectives edit button
	And I write text '<text>' inside the Objectives editor
	And I click on the Objectives Cancel button
	Then the text is not saved

Examples: 
	| project_title                    | url                               | text            |
	| ABBV-085 in SCCHN TPP assessment | project-details/project-objective | This is a test. |
