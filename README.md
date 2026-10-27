# Responsive Company Website (ASP.NET MVC)

A legacy ASP.NET MVC website project focused on a responsive, browser-based company/marketing site. The repository contains MVC views, stylesheets, JavaScript, images, and a Visual Studio solution.

## Technology

- C#
- ASP.NET MVC 5
- .NET Framework 4.7.2
- Razor views
- HTML, CSS, JavaScript
- Visual Studio / IIS Express

## Run locally

1. Use Windows with Visual Studio and the **ASP.NET and web development** workload.
2. Open `Responsive.sln`.
3. Restore the NuGet packages referenced by the solution.
4. Confirm the required .NET Framework 4.7.2 targeting pack is installed.
5. Set the web project as the startup project and run with IIS Express.

## Repository layout

- `Responsive/` — MVC application
- `Responsive/Views/` — Razor views
- `Responsive/wwwroot` or static asset folders — styles, scripts, and images
- `Responsive.sln` — Visual Studio solution

## Notes

This is a legacy .NET Framework application rather than ASP.NET Core. Review configuration files before publishing, replace any local-only connection settings, and do not commit passwords or environment-specific values. Build output and Visual Studio cache files should not be included in a cleaned-up source repository.
