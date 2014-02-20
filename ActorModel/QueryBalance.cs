using System;

namespace ActorModel
{
	/// <summary>
	/// Description of QueryBalance.
	/// </summary>
	public class QueryBalance : Message
	{
	    public Actor Receiver { get; set; }
	}
}
