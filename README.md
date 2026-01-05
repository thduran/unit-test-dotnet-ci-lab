CI pipeline to execute C# unit tests.
On every push or pull request to the branch main, the pipeline automatically runs `dotnet test`.
If any test fails, the pipeline fails and reports the issue.
