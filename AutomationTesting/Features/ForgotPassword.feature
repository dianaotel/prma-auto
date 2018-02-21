Feature: ForgotPassword
	

Scenario Outline: (1) Verify the Forgot your password link
	Given I navigate to the login URL
	And I click on the Forgot your password link
	Then I am redirected to the page with URL '<url>'

Examples: 
	| url			  |
	| forgot-password |


Scenario Outline: (2) Verify error message on empty email field
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I click on the send button
	Then I should see the error message '<message>' for required email

Examples: 
	| invalid_email | message  |
	| invalid_email | Required |


Scenario Outline: (3) Verify error message on invalid email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<invalid_email>'
	And I click on the send button
	Then I should see the error message '<message>' for invalid email

Examples: 
	| invalid_email | message               |
	| invalid_email | Must be a valid email |


Scenario Outline: (4) Verify error message on valid non-existing email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<nonexisting_email>'
	And I click on the send button
	Then I should see the error message '<message>' for non-existing email

Examples: 
	| nonexisting_email			 | message									 |
	| nonexisting_email@test.com | Password cannot be reset for this account |


Scenario Outline: (5) Verify redirect on valid existing email address
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I enter email address '<existing_email>'
	And I click on the send button
	Then I am redirected to the page with URL '<url>'

Examples: 
	| existing_email        | url					  |
	| diana.otel@evozon.com | forgot-password-success |


Scenario Outline: (6) Verify the Back to login link
	Given I navigate to the login URL
	And I click on the Forgot your password link
	And I click on the Back to login link
	Then I am redirected to the page with URL '<url>'

Examples: 
	| url	|
	| login |