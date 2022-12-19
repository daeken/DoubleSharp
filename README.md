Overview
========

DoubleSharp provides convenience features for:

- LINQ: `ToDictionary` converting `IEnumerable`s of tuples into `Dictionary`s automatically; `Shuffle` and `Shuffled` providing in-place and copy shuffles; `Flatten` reducing the nesting of `IEnumerable`s; and much more
- Concurrency: `Locked` extension method on objects allowing locking as an expression; `Increment`/`Decrement`/`Add` providing inline atomic operations
- Functional: `Compose` allowing function composition
- Progress: `WithProgress` and `WithTimedProgress` extension methods on `IEnumerable`/`ICollection` providing parallel-friendly progress bars
- Random: `Rng` providing a static class with automatic per-CPU seeds

Our general goal is to make C# even easier to use than it is right now. If it's something we have to write in several projects, it should be here instead.

Usage
=====

Simply reference the `DoubleSharp` package on NuGet and then import the namespaces with the functionality you need.

Check out the [progress bar example](Example/Program.cs) or the [unit tests](Tests/) for use cases!