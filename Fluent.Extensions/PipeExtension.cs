using System;

public static class PipeExtension
{
	public static ResultT Pipe<SelfT, ResultT>(this SelfT self, Func<SelfT, ResultT> transform)
	{
		return transform(self);
	}
}
