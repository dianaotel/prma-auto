Feature: HeatmapFilters
	

#Scenario Outline: (1) Verify that the total number of agency columns matches the total number of agencies in drop-down 
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
#Scenario Outline: (2) Verify the Agency filter uncheck functionality
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
#Scenario Outline: (3) Verify the Agency filter check all functionality
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
#Scenario Outline: (4) Verify the agencies displayed are the ones selected in the drop-down
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
#
#
#Scenario Outline: (5) Verify that the total number of domain rows matches the total number of domains in drop-down 
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	And I save the number of domains on the heatmap in a file 
#	When I open the heatmap Filter by Domain drop-down
#	Then I check the number of domains in the drop-down is correct
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (6) Verify the Domain filter uncheck functionality
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I see domain rows 
#	When I open the heatmap Filter by Domain drop-down
#	And I select the Uncheck all option on Domain filter
#	Then all domain rows disappear
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (7) Verify the Domain filter check all functionality
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I see domain rows
#	When I open the heatmap Filter by Domain drop-down
#	And I select the Uncheck all option on Domain filter
#	And I select the Check all option on Domain filter
#	Then I see domain rows
#
#Examples: 
#	| project_title                    |
#	| ABBV-085 in SCCHN TPP assessment |
#
#
#Scenario Outline: (8) Verify the domains displayed are the ones selected in the drop-down
#	Given I navigate to the login URL
#	And I login with valid prma admin credentials
#	When I open the project '<project_title>'
#	And I navigate to the heatmap
#	Then I see domain rows
#	When I open the heatmap Filter by Domain drop-down
#	And I select the Uncheck all option on Domain filter
#	And I select domain1 '<domain1>' and domain2 '<domain2>'
#	Then I see domain rows
#	And the domains on the heatmap are domain1 '<domain1>' and domain2 '<domain2>'
#
#Examples: 
#	| project_title        | domain1      | domain2 |
#	| Automation Project 2 | Trial design | Costs   |
