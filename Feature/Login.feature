Feature: Login_Feature

	In order to access my account
As a user of the website
I want to log into the website

@smoke
Scenario: Perform Login for FHSNG Site
	#steps
	Given User launches Application
	And User enters the following details
	| username | password |
	| SampleuserManager | RMco820208$$$ |
	And Click on the LogIn button
	Then Neptune Client will appear

Scenario: [Successful LogOut]
	When User LogOut from the Application
	Then Login Page will appear