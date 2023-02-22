Feature: Query CEP 

As a User, I want to verify the funcionality of Correios 
Query website, checking some CEPs and a tracking code

@notCEP
Scenario: Checking a non-existent CEP
	Given that I am in Correios website
	When I input a non-existent CEP
	Then the website returns Not Found message


@realCEP
Scenario: Checking an existent CEP
	Given that I am in Correios website
	When I input an existent CEP
	Then the website returns the adress


@track
Scenario: Checking a Tracking Number
	Given that I am in a Tracking website
	#Here I used a Third Part website because Correios has a CAPTCHA
	When I input a Tracking Number
	Then the website returns the error
