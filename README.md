[![NuGet Badge for DoubleSharp](https://img.shields.io/nuget/dt/DoubleSharp)](https://www.nuget.org/packages/DoubleSharp/) ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/daeken/DoubleSharp/publish.yml?branch=main)

Overview
========

DoubleSharp provides convenience features for:

- LINQ: `ToDictionary` converting `IEnumerable`s of tuples into `Dictionary`s automatically; `Shuffle` and `Shuffled` providing in-place and copy shuffles; `Flatten` reducing the nesting of `IEnumerable`s; and much more
- Concurrency: `Locked` extension method on objects allowing locking as an expression; `Increment`/`Decrement`/`Add`/`And`/`Or` providing inline atomic operations
- Functional: `Compose` allowing function composition
- Progress: `WithProgress` and `WithTimedProgress` extension methods on `IEnumerable`/`ICollection` providing parallel-friendly progress bars
- Random: `Rng` providing a static class with automatic per-CPU seeds
- Pretty: `ToPrettyString` extension method for all objects to convert it to a human-readable form; `Print` and `PrettyPrint` extension methods (aliases) to print that to the console, akin to Python's `pprint` module
- Buffers: `Cast` and `AsEnumerable` extensions for `Memory<T>` and `Span<T>`, `HexDump` (for Console/TextWriter output) and `ToHexDump` (for string creation) for all common unmanaged buffers
- MathPlus: Root finding, Vector2D type for double precision, swizzles for `Vector2/2D/3/4`, lerp, tuple<->Vector conversions, Vector deconstruction, `Centroid` extension method for `IEnumerable<Vector2/2D/3/4>`, `Map` for Vector to perform elementwise transformation, bit operations for unsigned integer types, `Ceil`/`Floor`/`Round` extensions for float/double, and `CeilInt`/`FloorInt`/`RoundInt` extensions for floor/double to int
- IO: Vector extensions for BinaryReader/BinaryWriter.

Our general goal is to make C# even easier to use than it is right now. If it's something we have to write in several projects, it should be here instead.

API Documentation
=================

API docs are available at [https://doublesharp.dev/](https://doublesharp.dev/)

Usage
=====

Simply reference the `DoubleSharp` package on NuGet and then import the namespaces with the functionality you need.

Check out the [progress bar example](Example/Program.cs) or the [unit tests](Tests/) for use cases!