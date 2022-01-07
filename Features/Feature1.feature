Feature: Login_Feature

	In order to access my account
As a user of the website
I want to log into the website

@tag1
Scenario: [Successful Login with Valid Credentials]
	Given [User is at the Home Page]
	And [Navigate to the LogIn Page]
	When [User enter Username and Password]
	And [Click on the LogIn button]
	Then [Successful LogIn message should display]

Scenario: [Successful LogOut]
	When [User LogOut from the Apllication]
	Then [Successful LogOut message should display]