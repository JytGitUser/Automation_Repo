Feature: Spotify Playlist

  Scenario: Create a new playlist
    Given I have a playlist with name "My New Playlist"
    When I create the playlist
    Then  playlist should be created successfully

  Scenario: Delete an existing playlist
    Given I have an existing playlist with ID "playlist_id_to_delete"
    When I delete the playlist
    Then the playlist should be deleted successfully