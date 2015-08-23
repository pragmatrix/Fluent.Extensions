using System;

public static class DoExtensions
{
	public static SelfT Do<SelfT>(this SelfT self, Action<SelfT> action)
	{
		action(self);
		return self;
	}
}
