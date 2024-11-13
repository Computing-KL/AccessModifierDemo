# AccessModifierDemo
Demonstrates how to use Access Modifiers in C# to restrict access to data. 

## Summary
| Caller's Location | `public` | `protected internal` | `protected` | `internal` | `private protected` | `private` | `file` |
| :- | :- | :- | :- | :- | :- | :- | :- |
| Within the file | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ✔️️ |
| Within the class | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ❌ |
| Derived class in the same assembly | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ✔️️ | ❌ | ❌ |
| Non-derived class in the same assembly | ✔️️ | ✔️️ | ❌ | ✔️️ | ❌ | ❌ | ❌ |
| Derived class in a different assembly | ✔️️ | ✔️️ | ✔️️ | ❌ | ❌ | ❌ | ❌ |
| Non-Derived class in a different assembly | ✔️️ | ❌ | ❌ | ❌ | ❌ | ❌ | ❌ |

Source: [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers) for more information.
