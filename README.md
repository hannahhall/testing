# Adding Travis CI
> How to add Travis CI to dotnet core projects

1. In the root of your project create a .travis.yml file
2. Add this code to the file: 
```YAML 
language: csharp
mono: none
dotnet: 2.1.3 # Or the version of dotnet core you're using
script:
  - dotnet build Calculator.Tests # Path to the test folder
  - dotnet test Calculator.Tests/Calculator.Tests.csproj # Path to the csproj in the test folder
```
3. Log into https://travis-ci.org/ with your github account
4. Activate the repo you'd like to start 
5. Push up some code and see the tests run
