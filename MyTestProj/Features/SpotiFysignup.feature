Feature: Spotify Signup

  Scenario: Signing up with valid credentials
    Given I navigate to the Spotify signup page
    When I enter my email as "<email>" and "<passwordnew>"
    And I Enter Details
    And I click on the sign up button
    Then I should be redirected to the Spotify welcome page and sign out 

    Examples:
    | email  | passwordnew |
    | jpsuryawanshi224@gmail.com | Kites@#008         | 
    