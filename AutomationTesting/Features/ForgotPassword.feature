Feature: ForgotPassword
	

Scenario Outline: (1) Verify the Forgot your password link
	Given I navigate to the login URL
	And I click on the Forgot your password link
	Then I am redirected to the Forgot Password page '<url>'

Examples: 
	| url			  |
	| forgot-password |


Scenario Outline: (2) verify error message on invalid email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<invalid_email>'
	And I click on the send button
	Then I should see the error message '<message>' for invalid email

Examples: 
	| invalid_email | message               |
	| invalid_email | Must be a valid email |

