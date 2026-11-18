# mba-ci-sample

## API Minimal .NET avec endpoints `/health` et `/hello-world`

Prérequis : SDK .NET 10.

```bash
dotnet run --project src/MbaCiSample.Api   # GET /health -> 200 "Healthy", GET /hello-world -> {"message":"Hello World!"}
dotnet test                                # tests des endpoints
```

Le workflow GitHub Actions `.github/workflows/ci.yml` exécute restore, build et test sur chaque push et pull request vers `main`.
