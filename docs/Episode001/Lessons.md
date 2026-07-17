# Lessons Learned

## Episode 001

Working code is not the same as production-ready code.

Key takeaways:

- Never store passwords in plain text.
- Validate user input.
- Prevent duplicate email registration.
- Return DTOs instead of domain entities.
- Add tests before approving a Pull Request


## Lesson 2

Compiler errors are often simple.

"The type or namespace name 'User' could not be found"

did NOT mean the User class was wrong.

It simply meant the Application project wasn't importing the namespace.

Always check:

- using statements
- project references
- namespaces

before assuming the code itself is wrong.