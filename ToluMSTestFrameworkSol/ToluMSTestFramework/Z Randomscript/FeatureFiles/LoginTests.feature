Feature: Validate the Login feature

Background: Given I am on the login page

Scenario: Valid Login Scenario
	And I have entered a valid username
	And I have entered a valid username
	When I click the login button
	Then I should be logged in

Scenario: Invalid Login page
	Given I am on the login page
	And I have entered a valid username
	But I have entered an valid username
	When I click the login button
	Then I should't be logged in


