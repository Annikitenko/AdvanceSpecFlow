Feature:	As a user of the website
			I want to log into the Advance

@mytag

Scenario: (1) Login to Advance positive flow
	Given I am on Advance Login Page
	When I click login button 
	And I write email
	| email                     |
	| AUTOMATION.PP@AMDARIS.COM |
	And I press Next button on email page 
	And I write password
	| password                                     |
	| 10704-observe-MODERN-products-STRAIGHT-69112 |
	And I press Next button on password page
	And I press Next button on question page
	Then I can see header of aplication

	