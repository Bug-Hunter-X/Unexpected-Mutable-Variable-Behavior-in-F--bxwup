# F# Mutable Variable Bug

This repository demonstrates a common confusion surrounding mutable variables in F#.  The `bug.fs` file shows code that unexpectedly modifies a variable due to misunderstanding of mutability and how it works with function calls.

The solution in `bugSolution.fs` addresses this by showing how to correctly use mutable variables or, ideally, embracing F#'s functional paradigm and avoiding mutable variables altogether.

## How to reproduce the bug
1. Open `bug.fs` in an F# editor or compiler.
2. Run the code.  Note that the variable `x` is modified even though it seems like it shouldn't be changed within `addOne`.

## Solution
The solution highlights the better approaches: using a `let` binding instead of mutable variable or updating with new values.