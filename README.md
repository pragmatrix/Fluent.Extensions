# Fluent.Extensions

Fluent.Extensions is a portable class library that supports programming against [fluent interfaces](https://en.wikipedia.org/wiki/Fluent_interface). Its primary purpose is to ease the transition to a more fluent programming style as part of every [AutoFluent](https://github.com/pragmatrix/AutoFluent) package.

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

Will set x to 13.

## License & Copyright

License: BSD

Copyright © 2015 Armin Sander
