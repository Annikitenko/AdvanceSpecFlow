Feature:	SpecFlowFeature2
			As a logged in user of the Advance 
			I want to be redirectedto Project Page the Advance

@mytag
Scenario: Redirection to the Project page from left bar Dashboard
	Given I am on Advance Dashboard
	When I click on Project button on left side of Dashboard page 
	Then I am on Project Page

Scenario: Redirection to the Project page from Dashboard
	Given I am on Advance Dashboard
	When I click on Project button on Dashboard menu 
	Then I am on Project Page