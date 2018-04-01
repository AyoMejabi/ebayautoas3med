Feature: Searchforcarforsale
	In order to buy a bmw420D
	As an ebay customer
	I want to be able to search for a black 2018 BMW420D of my choice

@mytag
Scenario: To search for car for sale
	Given I navigate to ebay homepage
	And I hover over search for anything
	When I type in bmw420D, black, 2018
	And I click on the search button
	Then the list of bmw420d cars for sale will be displayed
