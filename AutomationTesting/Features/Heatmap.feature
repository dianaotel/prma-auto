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
#
#Scenario Outline: (6) Verify the total summary modal X button
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then the modal appears
#	When I click on the View requirements button
#	Then I am redirected to the requirements page
#	
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |


#Scenario Outline: (7) Verify the View requirements button in modal
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	When I click on the total summary cell
#	Then the number of all requirements and KVs is correct 
#	| total_req | total_kv | not_met_req | not_met_kv | partial_req | partial_kv | met_req | met_kv |
#	| 356       | 154      | 56          | 56         | 219         | 98         | 78      | 0      |
#	
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (8) Verify the total number of requirements and KVs in page and modal
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
#Scenario Outline: (9) Verify the links of total requirements in modal
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
#Scenario Outline: (10) Verify the links of total KVs in modal
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
#
#
#Scenario Outline: (11) Verify that the total number of agency columns matches the total number of agencies in drop-down 
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	And I save the number of agencies on the heatmap in a file 
#	When I open the heatmap Filter by Agency drop-down
#	Then I check the number of agencies in the drop-down is correct
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (12) Verify the Agency filter uncheck functionality
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I see agency columns 
#	When I open the heatmap Filter by Agency drop-down
#	And I select the Uncheck all option on Agency filter
#	Then all agency columns disappear
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (13) Verify the Agency filter check all functionality
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I see agency columns 
#	When I open the heatmap Filter by Agency drop-down
#	And I select the Uncheck all option on Agency filter
#	And I select the Check all option on Agency filter
#	Then I see agency columns
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (14) Verify the agencies displayed are the ones selected in the drop-down
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I see agency columns 
#	When I open the heatmap Filter by Agency drop-down
#	And I select the Uncheck all option on Agency filter
#	And I select agency1 '<agency1>' and agency2 '<agency2>'
#	Then I see agency columns
#	And the agencies on the heatmap are agency1 '<agency1>' and agency2 '<agency2>'
#
#Examples: 
#	| project_title        | agency1             | agency2             |
#	| Automation Project 2 | Infarmed (Portugal) | NICE_2015 (England) |


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

