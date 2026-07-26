# Copilot Instructions

## Project Overview
This is a .NET / C# project. All code generation, review, and suggestions must follow the standards below.

---

## Language & Runtime
- Target **.NET 8+** and **C# 12+**
- Enable `<Nullable>enable</Nullable>` and `<ImplicitUsings>enable</ImplicitUsings>` in all projects
- Use the latest language features (primary constructors, collection expressions, pattern matching) where they improve clarity

## Naming Conventions
| Element | Convention | Example |
|---|---|---|
| Classes, methods, properties, events | `PascalCase` | `UserService`, `GetById()` |
| Local variables, parameters | `camelCase` | `userId`, `isValid` |
| Private fields | `_camelCase` | `_repository` |
| Constants | `PascalCase` | `MaxRetryCount` |
| Interfaces | `IPascalCase` | `IUserRepository` |

## Code Style
- Prefer `record` types for immutable DTOs and value objects
- Use `async`/`await` for all I/O-bound work; never block with `.Result` or `.Wait()`
- Use expression-bodied members for simple, one-liner methods and properties
- Prefer `var` when the type is obvious from the right-hand side
- Use `ArgumentNullException.ThrowIfNull()` and `ArgumentException.ThrowIfNullOrEmpty()` for boundary validation
- Throw specific exception types; never throw bare `Exception`
- Do not validate internal invariants that cannot happen — validate only at public API boundaries

## Testing
- Use **xUnit** for all unit and integration tests
- Follow the **Arrange / Act / Assert** pattern with a blank line separating each section
- Name tests: `MethodName_Scenario_ExpectedResult`
- Mock dependencies with **Moq** or **NSubstitute**
- Cover business logic thoroughly; do not test framework or infrastructure code

## Git & Workflow
- Use **Conventional Commits**: `feat:`, `fix:`, `chore:`, `docs:`, `test:`, `refactor:`
- Never push directly to `main`; all changes go through pull requests
- A PR **must have a complete plan in its description** before any implementation begins
- The plan and the implementation are kept strictly separate (different commits, different agents)

## Agents & Roles
| Agent | Responsibility | Constraint |
|---|---|---|
| **Planner** | Reads an issue, explores the codebase, creates a draft PR with a structured plan | **Must not add, edit, or delete any source files** |
| **Implementor** (GitHub Copilot coding agent) | Implements exactly what the plan describes | **Must not modify the PR description / plan** and must not open a new PR |

## PR Plan Format
Every PR description written by the Planner must contain all of the following sections (exact headings):

```
## Summary
## What Should Be Done
## Acceptance Criteria
## Files to Change
## Out of Scope
## Notes / Risks
```
