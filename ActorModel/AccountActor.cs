using System;

namespace ActorModel
{
	/// <summary>
	/// Description of AccountActor.
	/// </summary>
	public class AccountActor : Actor
	{
	    private decimal _balance;
	 
	    public void Handle(Deposit message)
	    {
	        _balance += message.Amount;
	    }
	 
	    public void Handle(QueryBalance message)
	    {
	        message.Receiver.Send(new Balance {Amount = _balance});
	    }
	}
}
