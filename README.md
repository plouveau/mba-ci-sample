# mba-ci-sample
## API Minimal .NET avec endpoint `/health`

Prérequis : SDK .NET 8.

```bash
dotnet run --project src/MbaCiSample.Api   # puis GET /health -> 200 "Healthy"
dotnet test                                # test unitaire de /health
```

Le workflow GitHub Actions `.github/workflows/ci.yml` exécute restore, build et test sur chaque push et pull request vers `main`.
