Feature: Heatmap

@prma @heatmap @ddt
Scenario Outline: Verify total summary modal title
	Given I navigate to the login URL
	And I enter valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the heatmap
	When I click on the total summary cell
	Then a modal with title '<modal_title>' appears

Examples:
	| project_title                    | modal_title			   |
	| ABBV-085 in SCCHN TPP assessment | All domains, all agencies |
	#| Automation Project 1             | All domains, all agencies |
	#| ABT-165 in mCRC TPP assessment   | All domains, all agencies |


Scenario: Verify the colouring of the summary cell
	Given I navigate to the login URL
	And I enter valid prma admin credentials
	When I open the project '<project_title>'
	And I navigate to the heatmap
	When I click on the total summary cell
	Then I check the number of each requirement 

