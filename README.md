# SwagLabsLoginTests

This BDD automated test executes two login tests against a test website.  It is written in SpecFlow, Selenium Webdriver, and C# .NET.

## User Story
As a Swag Labs customer who is not locked out, I need to be able to log in so that I can purchase Sauce Labs merch.

## Acceptance Criteria

### Scenario: 1 Successful Login
**Given** I am on the Sauce Demo Login Page  
**When** I fill the account information for account StandardUser into the Username field and the Password field  
    **And** I click the Login Button  
**Then** I am redirected to the Sauce Demo Main Page  
    **And** I verify the App Logo exists  
  
### Scenario: 2 Failed Login
**Given** I am on the Sauce Demo Login Page  
**When** I fill the account information for account LockedOutUser into the Username field and the Password field  
    **And** I click the Login Button  
**Then** I verify the Error Message contains the text "Sorry, this user has been banned."  

## Test URL
https://www.saucedemo.com/

## Logins
**User 1:**  
Username: standard_user  
Password: secret_sauce  

**User 2:**  
Username: locked_out_user  
Password: secret_sauce  


