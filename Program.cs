using Learn.MusicMatcher.Types;
using SpotifyWeb;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options=>{
    options.AddDefaultPolicy(builder=>{
        builder.WithOrigins("https://studio.apollographql.com", "https://localhost:5059")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});


builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .RegisterService<SpotifyService>();

builder.Services.AddHttpClient<SpotifyService>();

var app = builder.Build();

app.UseCors();
app.MapGraphQL();


app.Run();
