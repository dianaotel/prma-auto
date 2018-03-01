Feature: Heatmap
	Testing the heatmap on a project
	That is set on detailed (requirements) view

#Scenario Outline: (1) Verify url and page title
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I should see the heatmap page with URL '<url>' and title '<title>'
#
#Examples: 
#	| project_title                    | url	 | title   |
#	| ABBV-085 in SCCHN TPP assessment | heatmap | Heatmap |
#
#
#Scenario Outline: (2) Verify the breadcrumbs
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then the breadcrumbs '<breadcrumbs>' are correct
#
#Examples: 
#	| project_title		   | breadcrumbs							  |
#	| Automation Project 1 | Automation Project 1 > Project Details > |
#
#
#Scenario: Verify the colouring of the summary cell
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then I check the number of each requirement type
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |

