using System;

namespace ActorModel
{
	class Program
	{
		public static void Main(string[] args)
		{
			var account = new AccountActor();
	        var output = new OutputActor();
	 
	        account.Send(new Deposit {Amount = 50});
	        account.Send(new QueryBalance {Receiver = output});
	 
	        account.Completion.Wait();
	        output.Completion.Wait();
	 
	        Console.WriteLine("Done!");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}