using System;

namespace Learn.MusicMatcher.Types;

public class Artist
{
    [ID]
    public string Id { get; }
    public string Name { get; set; }
    public int? Followers { get; set; }
    public float? Popularity { get; set; }

    public Artist(string id, string name)
    {
        Id = id;
        Name = name;
    }
}
