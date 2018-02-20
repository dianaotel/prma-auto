Feature: ForgotPassword
	

Scenario Outline: (1) Verify the Forgot your password link
	Given I navigate to the login URL
	And I click on the Forgot your password link
	Then I am redirected to the Forgot Password page '<url>'

Examples: 
	| url			  |
	| forgot-password |


