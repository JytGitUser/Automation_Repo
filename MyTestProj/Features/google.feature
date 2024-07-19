Feature: Google Search
  Scenario: Open Google Homepage
    Given I have opened the browser
    When I navigate to Google
    Then the Google homepage should be displayed
    Then Enter a value
    