
Feature: UserAccountCreation Tests
User should be able to create an account when all mandatory fields are completed
	
	Background: 
		Given I am on the account creation page

Scenario: Create an account with valid option
	And I have entered my Firstname
	And I have entered my Lastname
	And I have entered my email address
	And I have entered my telephone number
	When I select the continue button
	Then My account should be created
	And I should be logged into my homepage
	
Scenario: Unsuccesful account creation with missing mandatory fields (Email)
	And I have entered my Firstname
	And I have entered my Lastname
	But I have not entered my email address
	And I have entered my telephone number
	When I select the continue button
	Then My account should not be created
	And I should be logged into my homepage
	
Scenario: Unsuccesful account creation with missing mandatory fields (Telephone)
	And I have entered my Firstname
	And I have entered my Lastname
	And I have entered my email address
	But I have not entered my telephone number
	When I select the continue button
	Then My account should not be created
	And I should be logged into my homepage

Scenario Outline: Don't create an account if any of the mandatory fields are missing
	And I have entered my "<FirstName>"
	And I have entered my "<Lastname>"
	And I have entered my "<emailaddress>"
	And I have entered my "<telephonenumber>"
	When I select the continue button
	Then My account should not be created
	And I should be logged into my homepage

	Examples:
	| FirstName | Lastname | emailaddress | telephonenumber | PASSWORD | ConfirmPassword |
	|           | LARRY    | Tolu@HD.com  | 0123456789      | dog      | dog             |
	| OL        |          | Tolu@Sbc.com | 1232324456      | cat      | cat             |
	| Phil      | PHILL    |              | 9494847555      | love     | love            |
	| JOHN      | JAMES    | ToAu@abc.com |                 | hate     | hate            |
	| Dave      | Terry    | ht@hy.com    | 0983636         |          | juice           |
	| ali       | Bongo    | jj@jj.cf     | 0989899         | priest   |                 |
	|           |          |              |                 |          |                 | 


