﻿Feature: Spotify Login

  Scenario Outline: Login to Spotify with different users
    Given I navigate to the Spotify login page
    When I enter username "<username>" and password "<password>"
    And I click the login button
    Then I should see an error message if login fails for "<Error>"

  Examples:
    | username  | password |
    | jpsuryawanshi01@gmail.com | Kites@#008         | 
     | jpsuryawanshi02@gmail.com | Kites@#         | 
    | jpsuryawahi03@gmail.com | Kites@#008         | 
  