# EmployeeDirectory

EmployeeDirectory is a .NET application for managing and browsing employee information through a structured directory.

## Project layout

- `EmployeeDirectory.slnx` — solution file
- `EmployeeDirectory/EmployeeDirectory.csproj` — application project
- `EmployeeDirectory/Program.cs` — application entry point
- `EmployeeDirectory/appsettings.json` — shared application configuration
- `EmployeeDirectory/appsettings.Development.json` — development configuration

## Requirements

- .NET SDK compatible with the target framework in `EmployeeDirectory/EmployeeDirectory.csproj`

Check the installed SDK with:

```bash
dotnet --version
```

## Run locally

```bash
git clone https://github.com/haseeb-ahmed29/EmployeeDirectory.git
cd EmployeeDirectory
dotnet restore
dotnet run --project EmployeeDirectory/EmployeeDirectory.csproj
```

The command output will show the local URL for the running application.

## Validate changes

Before opening a pull request, run:

```bash
dotnet build EmployeeDirectory.slnx
```

Keep environment-specific secrets out of committed configuration files. Use local environment variables or the standard .NET user-secrets workflow for development-only values.

## Contributing

Describe the user-facing behavior in the pull request, keep changes focused, and verify the build before requesting review.

## License

No license file is currently included. Add an explicit license before redistributing the project.
