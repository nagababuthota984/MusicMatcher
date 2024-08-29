using System;
using SpotifyWeb;

namespace Learn.MusicMatcher.Types;

[GraphQLDescription("A single audio file, usually a song.")]
public class Track
{
    [ID]
    [GraphQLDescription("The ID for the track.")]
    public string Id { get; set; }
    [GraphQLDescription("The name of the track.")]
    public string Name { get; set; }
    public double DurationMs { get; set; }
    [GraphQLDescription("The URI for the track, usually a Spotify link.")]
    public string Uri { get; set; }
    [GraphQLDescription("Whether or not the track has explicit lyrics (true = yes it does; false = no it does not OR unknown)")]
    public bool Explicit { get; set; }
    public Track(string id, string name, string uri)
    {
        Id = id;
        Name = name;
        Uri = uri;
    }
    public Track(PlaylistTrackItem trackItem){
        Id = trackItem.Id;
        Name = trackItem.Name;
        Uri = trackItem.Uri;
        Explicit = trackItem.Explicit;
        DurationMs = trackItem.Duration_ms;
    }
}
