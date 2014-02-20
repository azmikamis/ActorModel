using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ActorModel
{
	/// <summary>
	/// Description of Actor.
	/// </summary>
	public abstract class Actor
	{
		private readonly ActionBlock<Message> _action;
		
		public Actor()
	    {
	        _action = new ActionBlock<Message>(message =>
	        {
	            dynamic self = this;
	            dynamic mess = message;
	            self.Handle(mess);
	        });
	    }
		
		public void Send(Message message)
	    {
	        _action.Post(message);
	    }
		
		public Task Completion
		{
		    get
		    {
		        _action.Complete();
		        return _action.Completion;
		    }
		}
	}
}
