# Contributing

Thank you for your interest in contributing to Celerik.NetCore.Util!

The document covers the process for contributing to the code that is hosted on the [Celerik.NetCore.Util site](https://github.com/celerik/celerik-netcore-util). Contributions may be as simple as typo corrections or as complex as new utility functions.

- [DOs and DON'Ts](#dos-and-donts)
- [Process for contributing](#process-for-contributing)

This repository provides some custom utilities for .NET Core projects, including: attributes, azure, datetime, files, json, resources, convertions, crypto, enums, queries, stack trace, strings, testing, validations among others.

Issues and tasks for this repository are tracked in [celerik-netcore-util/projects](https://github.com/celerik/celerik-netcore-util/projects).

## DOs and DON'Ts

The following list shows some guiding rules that you should keep in mind when you're contributing to the Celerik.NetCore.Util:

- **DON'T** surprise us with large pull requests. Instead, file an issue and start a discussion so we can agree on a direction before you invest a large amount of time. For bulk changes, break the work into smaller PRs (up to 100 files). This guideline is strongly recommended if your PR doesn't follow the following guidelines.
- **DO** look at the current [labels](https://github.com/celerik/celerik-netcore-util/labels) issues for suggestions on tasks.
- **DO** create one PR for each task. PRs that include multiple unrelated changes are much harder to review. That delays reviews and merging PRs. This guideline applies to reviews as well: we try not to suggest unrelated changes in reviews; we ask that community reviews adhere to this guideline.
- **DO** provide a clear description of the work in your PR. Tell us what changed and why. The default description of "update article.md" isn't helpful for reviewers.
- **DO** read the [style guide](https://docs.microsoft.com/en-us/dotnet/core/) guidelines. New additions should follow these guidelines.
- **DO** follow the [GitHub Flow workflow](https://guides.github.com/introduction/flow/).
- **DO** blog and tweet (or whatever) about your contributions, frequently!

These guidelines help us respect everyone's time. Many people contribute to these repositories. Following these guidelines make it easier for us to review and merge your PR in a timely fashion. These practices minimize conflicts with PRs from other community members and our team. Because PRs that don't follow these guidelines often cause extra work for us and community members, those PRs may be rejected. If you want an exception, start by creating an issue.

## Process for contributing

You need a basic understanding of [Git and GitHub.com](https://guides.github.com/activities/hello-world/).

**Step 1:** Skip this step for small changes (for example, if you're correcting a typo or immediately opening a pull request to address an issue that you find). If you're interested in coding new utilities or in thoroughly revising existing utilities, open an [issue](https://github.com/celerik/celerik-netcore-util/issues) describing what you want to do.

**Step 2:** Fork the `celerik-netcore-util` repo as needed and create a branch for your changes.

For small changes, you can use GitHub's web interface. Simply click the **Edit the file in your fork of this project** on the file you'd like to change. GitHub creates the new branch for you when you submit the changes.

**Step 3:** Make the changes on this new branch.

Add your utility to the right folder or create a new one.

### Project structure

```
Celerik.NetCore.Util
  /Attributes
  /Azure
  /DateTime
  /Files
  /Newtonsoft
  /Resources
  /Utilities
Celerik.NetCore.Util.Test
  /Azure
  /DateTime
  /Files
  /Newtonsoft
  /Resources
  /Utilities
```

Be sure to add unit testing for new functions you are creating, and that all unit tests PASS.

**Step 4:** Submit a Pull Request (PR) from your branch to `celerik-netcore-util/master`.

Each PR should usually address one issue at a time. The PR can modify one or multiple files. If you're addressing multiple fixes on different files, separate PRs are preferred.

If your PR is addressing an existing issue, add the `Fixes #Issue_Number` keyword to the commit message or PR description. That way, the issue is automatically closed when the PR is merged. For more information, see [Closing issues via commit messages](https://help.github.com/articles/closing-issues-via-commit-messages/).

The Celerik team will review your PR and let you know if there are any other updates/changes necessary in order to approve it.

**Step 5:** Make any necessary updates to your branch as discussed with the team.

The maintainers will merge your PR into the master branch once feedback has been applied and your change is approved.

Note: `master` is the default branch accepting Pull Requests. It releases a package everytime the `head_commit.message` contains the word `[release]`.
