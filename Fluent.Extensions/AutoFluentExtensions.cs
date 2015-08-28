using System;

/**
	The following extensions are used in the AutoFluent packages to reduce the
	number of compiler generated classes that are code generated for each lambda expression.
**/

public static class AutoFluentExtensions
{
	public static Action<object> DemoteSender<T>(this Action<T> action)
	{
		return sender => action((T) sender);
	}

	public static Action<object, Arg1T> DemoteSender<T, Arg1T>(this Action<T, Arg1T> action)
	{
		return (sender, arg1) => action((T)sender, arg1);
	}

	public static Action<object, Arg1T, Arg2T> DemoteSender<T, Arg1T, Arg2T>(this Action<T, Arg1T, Arg2T> action)
	{
		return (sender, arg1, arg2) => action((T)sender, arg1, arg2);
	}

	public static Action<object, Arg1T, Arg2T, Arg3T> DemoteSender<T, Arg1T, Arg2T, Arg3T>(this Action<T, Arg1T, Arg2T, Arg3T> action)
	{
		return (sender, arg1, arg2, arg3) => action((T)sender, arg1, arg2, arg3);
	}

	public static Action<object, Arg1T, Arg2T, Arg3T, Arg4T> DemoteSender<T, Arg1T, Arg2T, Arg3T, Arg4T>(this Action<T, Arg1T, Arg2T, Arg3T, Arg4T> action)
	{
		return (sender, arg1, arg2, arg3, arg4) => action((T)sender, arg1, arg2, arg3, arg4);
	}

	public static Action<object, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T> DemoteSender<T, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T>(this Action<T, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T> action)
	{
		return (sender, arg1, arg2, arg3, arg4, arg5) => action((T)sender, arg1, arg2, arg3, arg4, arg5);
	}

	public static Action<object, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T, Arg6T> DemoteSender<T, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T, Arg6T>(this Action<T, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T, Arg6T> action)
	{
		return (sender, arg1, arg2, arg3, arg4, arg5, arg6) => action((T)sender, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	public static Action<object, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T, Arg6T, Arg7T> DemoteSender<T, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T, Arg6T, Arg7T>(this Action<T, Arg1T, Arg2T, Arg3T, Arg4T, Arg5T, Arg6T, Arg7T> action)
	{
		return (sender, arg1, arg2, arg3, arg4, arg5, arg6, arg7) => action((T)sender, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}
}
