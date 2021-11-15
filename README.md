# Snack React
A snack review app with React and DotNet

## Migrations
To run migrations ensure that `$PROJECT_ROOT/src/Web/appsettings.json` has `"UseInMemoryDatabase": false`. Then run the following:

```
dotnet ef migrations add "{NAME}" --project src/Infrastructure --startup-project src/Web --output-dir Persistence/Migrations
```
