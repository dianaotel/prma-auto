Feature: HeatmapRequirementsModal
	

#Scenario Outline: (1) Verify total summary modal open and title
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
#	| Automation Project 1             | All domains, all agencies |
#
#
#Scenario Outline: (2) Verify the total summary modal Close button
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
#Scenario Outline: (3) Verify the total summary modal X button
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
#
Scenario Outline: (4) Verify the total summary modal View requirements button
	Given I navigate to the login URL
	And I login with valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the heatmap
	When I click on the total summary cell
	Then the modal appears
	When I click on the View requirements button
	Then I am redirected to the requirements page
	

Examples: 
	| project_title                    |
	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (5) Verify the total number of requirements and KVs in page and modal
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then the total number of requirements and KVs on the page is saved in file
#	When I click on the total summary cell
#	Then the total number of requirements and KVs in modal is correct 
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (6) Verify the links of total requirements in modal
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then the total number of requirements and KVs on the page is saved in file
#	When I click on the total summary cell
#	And I click on the total requirements link
#	Then I am redirected to the requirements page
#	And the Requirements page title contains the total number of requirements
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (7) Verify the links of total KVs in modal
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then the total number of requirements and KVs on the page is saved in file
#	When I click on the total summary cell
#	And I click on the total KVs link
#	Then I am redirected to the requirements page
#	And the Requirements page title contains the total number of KVs
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
