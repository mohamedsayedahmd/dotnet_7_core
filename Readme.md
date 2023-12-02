
`dotnet new web -n GameStore.api`
---
GameStore.Api.csproj
---
### One way to build and run :-

#### Build the project
GameStore.api> `dotnet build`
#### Run the project
GameStore.api> `dotnet run`
---
### Second way to build and run (.vscode) :-
ctrl + shift + B

### [localhost](http://localhost:5276/)

---
requests:
- [GET]  http://localhost:5276/games
- [GET]  http://localhost:5276/games/1
- [Post]  http://localhost:5276/games
```json
{
    "name": "Minecraft",
    "genre": "Kids and Family",
    "price": 19.99,
    "releaseDate": "2011-11-18",
    "imageUri": "https://placehold.co/100"
}
```
