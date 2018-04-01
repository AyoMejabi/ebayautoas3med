Feature: Searchfor Mens jumper
	In order to buy a male jumper
	As an ebay customer
	I want to ve able to search for a jumper of my choice


Scenario: To search for jumper
	Given I navigate to ebay homepage
	And I hover over search for anything
	When I type in brown jumper
	And i type in size Large
	And I click on the search button
	Then the list of brown jumpers for sale will be displayed
