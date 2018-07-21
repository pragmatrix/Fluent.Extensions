# Fluent.Extensions

Fluent.Extensions is a netstandard class library that supports programming against [fluent interfaces](https://en.wikipedia.org/wiki/Fluent_interface). Its primary purpose is to ease the transition to a more fluent programming style as part of every [AutoFluent](https://github.com/pragmatrix/AutoFluent) package.

## Installation

Fluent.Extensions can be installed separately [via NuGet](https://www.nuget.org/packages/Collections.Fluent/).

## Contents

### Generic collections extension methods

Fluent.Extensions contains all extension methods defined in the [Collections.Fluent project](https://github.com/pragmatrix/Collections.Fluent) that are used to modify generic collections inside a method chain. They are available as soon the namespace System.Collections.Generic is used.

### General purpose methods

The following general purpose extension methods are defined in the global namespace, they are available as soon Fluent.Extensions is referenced by your project.

#### Do()

The `Do()` extension method can be inserted inside a method chain to call back into lambda expression or a method. The lambda expression is expected to have exactly one parameter that receives the current object of the method chain. `Do()` always returns the current object.

For example:

	var x = 10;
	1.Do(v => x += v)
	 .Do(v => x += v*2);

Sets x to 13.

#### Pipe()

The `Pipe(f)` extension calls the function *f* with the current object of the method chain and continues with the function's result.

For example:

	var x = 10.Pipe(a => a * a);

Sets x to 100.

### AutoFluent specific extension methods

These are extension methods used by [AutoFluent](https://github.com/pragmatrix/AutoFluent) generated packages.

#### DemoteSender()

The `DemoteSender()` extension method forwards a call to an `Action<>` delegate with the first parameter set to the `object` type to an `Action<>` delegate with the concrete type of a class by casting the first argument. This is used to provide an event's `sender` as a concrete instance type to client code that handles the event. Instead of code generating each forwarding lambda, AutoFluent uses `DemoteSender()` to reduce the code size of the resulting AutoFluent class library.

## License & Copyright

License: BSD

Copyright © 2016 Armin Sander
