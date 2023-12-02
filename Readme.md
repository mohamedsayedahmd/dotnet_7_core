
`dotnet new web -n GameStore.api`
---
GameStore.Api.csproj
---
#### One way to build and run :-

#### Build the project
GameStore.api> `dotnet build`
#### Run the project
GameStore.api> `dotnet run`
---
#### Second way to build and run (.vscode) :-
ctrl + shift + B

#### [localhost](http://localhost:5276/)

---
#### Get All Games
[GET]  http://localhost:5276/games
___
#### Get Game By Id
[GET]  http://localhost:5276/games/1
___
#### Create New Game
[POST] : http://localhost:5276/games :
```json
{
    "name": "Minecraft",
    "genre": "Kids and Family",
    "price": 19.99,
    "releaseDate": "2011-11-18",
    "imageUri": "https://placehold.co/100"
}
```
#### Update Game By Id
[PUT] : http://localhost:5276/games/1
```json
{
    "name": "Street Fighter II Turbo",
    "genre": "Fighting",
    "price": 9.99,
    "releaseDate": "1991-02-01",
    "imageUri": "https://placehold.co/100"
}
```
#### Delete Game By Id
[DELETE] : http://localhost:5276/games/2
___

