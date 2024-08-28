using System;
using SpotifyWeb;

namespace Learn.MusicMatcher.Types;

public class Query
{
    [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
    public async Task<List<Playlist>> FeaturedPlaylistsAsync(SpotifyService spotifyService)
    {
        var response = await spotifyService.GetFeaturedPlaylistsAsync();
        ICollection<PlaylistSimplified> items = response.Playlists.Items;
        IEnumerable<Playlist> playlists = items.Select(item => new Playlist(item));
        return playlists.ToList();
    }

    [GraphQLDescription("Retrieves a specific playlist.")]
    public async Task<Playlist?> GetPlaylist([ID] string id, SpotifyService spotifyService)
    {
        var response = await spotifyService.GetPlaylistAsync(id);
        return new Playlist(response);
    }
}

