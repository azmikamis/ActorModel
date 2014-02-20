using System;

namespace ActorModel
{
	/// <summary>
	/// Description of OutputActor.
	/// </summary>
	public class OutputActor : Actor
	{
	    public void Handle(Balance message)
	    {
	        Console.WriteLine("Balance is {0}", message.Amount);
	    }
	}
}
