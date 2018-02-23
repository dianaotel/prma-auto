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
#Scenario Outline: (3) Verify total summary modal open and title
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then a modal with title '<modal_title>' appears
#
#Examples:
#	| project_title                    | modal_title			   |
#	| ABBV-085 in SCCHN TPP assessment | All domains, all agencies |
#	#| Automation Project 1             | All domains, all agencies |
#
#
#Scenario Outline: (4) Verify the total summary modal Close button
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then the modal appears
#	When I click on the Close button
#	Then the modal disappears
#	
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (5) Verify the total summary modal X button
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then the modal appears
#	When I click on the X button
#	Then the modal disappears
#	
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |


Scenario Outline: (6) Verify the number of all requirements and KVs in modal
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the heatmap
	When I click on the total summary cell
	Then the number of all requirements and KVs is correct 
	| total_req | total_kv | not_met_req | not_met_kv | partial_req | partial_kv | met_req | met_kv |
	| 356       | 154      | 56          | 56         | 219         | 98         | 78      | 0      |
	

Examples: 
	| project_title                    |
	| ABBV-085 in SCCHN TPP assessment |


#Scenario: Verify the colouring of the summary cell
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then I check the number of each requirement 
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |

