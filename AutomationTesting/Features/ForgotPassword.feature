Feature: ForgotPassword
	

Scenario Outline: (1) Verify the Forgot your password link
	Given I navigate to the login URL
	And I click on the Forgot your password link
	Then I am redirected to the page with URL '<url>'

Examples: 
	| url			  |
	| forgot-password |


Scenario Outline: (2) Verify error message on invalid email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<invalid_email>'
	And I click on the send button
	Then I should see the error message '<message>' for invalid email

Examples: 
	| invalid_email | message               |
	| invalid_email | Must be a valid email |


Scenario Outline: (3) Verify error message on valid non-existing email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<nonexisting_email>'
	And I click on the send button
	Then I should see the error message '<message>' for non-existing email

Examples: 
	| nonexisting_email			 | message									 |
	| nonexisting_email@test.com | Password cannot be reset for this account |


Scenario Outline: (4) Verify redirect on valid existing email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<existing_email>'
	And I click on the send button
	Then I am redirected to the page with URL '<url>'

Examples: 
	| existing_email        | url					  |
	| diana.otel@evozon.com | forgot-password-success |
