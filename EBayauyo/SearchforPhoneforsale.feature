Feature: SearchforPhoneforsale
	In order to buy iphone7
	As an ebay customer
	I want to ve able to search for a phone of my choice


Scenario: To search for iphone7
	Given I navigate to ebay homepage
	And I hover over search for anything
	When I type in iphone 7
	And I clikc on the search button
	Then the list of iphone7 phones for sale will be displayed
