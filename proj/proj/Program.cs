using System;

class EWallet
{
    public decimal balance = 5000;

    public void CheckBalance()
    {
    	Console.Clear();
    	Console.WriteLine("===================");
    	Console.WriteLine("= BALANCE SECTION =");
    	Console.WriteLine("===================");
        Console.WriteLine("Your current balance: $" + balance);
    }

    public void Send()
    {
    	Console.Clear();
    	Console.WriteLine("========================");
    	Console.WriteLine("= TRANSFERRING SECTION =");
    	Console.WriteLine("========================");
    	Console.Write("Enter Recipient's Username: ");
    	string number = Console.ReadLine();
    	Console.Write("Enter Amount to Send: ");
    	decimal sendAmount = Convert.ToDecimal(Console.ReadLine());
    	if(sendAmount > 0)
    	{
    		if (sendAmount <= balance)
            {
                balance -= sendAmount;
                Console.WriteLine("SENT SUCCESSFULLY. Amount successfully sent to "+number);
            }
            else
            {
                Console.WriteLine("INSUFFICIENT FUNDS. Cannot transfer more than the current balance.");
            }
    	}
    	
    	else
    	{
    	Console.WriteLine("INVALID INPUT. Please enter a valid amount to deposit.");
    	}
    	
    	
    }


    public void Deposit()
    {
    	Console.Clear();
        Console.WriteLine("===================");
    	Console.WriteLine("= DEPOSIT SECTION =");
    	Console.WriteLine("===================");
    	Console.Write("Enter the amount to deposit: $");
       decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        if (depositAmount > 0)
        {
            balance += depositAmount;
            Console.WriteLine("DEPOSIT SUCCESSFUL. Your new balance is: $" + balance);
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid amount to deposit.");
        }
        
    }

    public void Withdraw()
    {
    	Console.Clear();
    	Console.WriteLine("======================");
    	Console.WriteLine("= WITHDRAWAL SECTION =");
    	Console.WriteLine("======================");
        Console.Write("Enter the amount to withdraw: $");
        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
        if (withdrawAmount > 0)
        {
            if (withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine("WITHDRAWAL SUCCESSFUL. Your new balance is: $" + balance);
            }
            else
            {
                Console.WriteLine("INSUFFICIENT FUNDS. Cannot withdraw more than the current balance.");
            }
        }
        else
        {
            Console.WriteLine("INVALID INPUT. Please enter a valid amount to withdraw.");
        }
    }
}

class Program
{
    static void Main()
    {
        EWallet eWallet = new EWallet();
		go:
        string usName = "naruto";
           string Otp = "1234";
			bool pin = false;
			Console.WriteLine("============================");
			Console.WriteLine("= Welcome To Your E-wallet =");
			Console.WriteLine("============================");
			Console.WriteLine(" ");
			Console.WriteLine("============================");
			Console.WriteLine("= LOGIN SECTION =");
			Console.WriteLine("============================");
			Console.WriteLine(" ");
			while(!pin){
				Console.Write("Please Enter your Username: ");
				string username = Console.ReadLine();
				Console.Write("Please Enter your 4-digit MPin: ");
				string mpin = Console.ReadLine();
				
				if(mpin == Otp){
					if(username == usName){
					pin = true;
					}
					
					else{ 
						Console.Clear();
					Console.WriteLine("============================");
			Console.WriteLine("= LOGIN SECTION =");
			Console.WriteLine("============================");
			Console.WriteLine(" ");
					Console.WriteLine("INCORRECT Username. Try Again");
					}
				
				
				}
				else{
					Console.Clear();
					Console.WriteLine("============================");
			Console.WriteLine("= LOGIN SECTION =");
			Console.WriteLine("============================");
			Console.WriteLine(" ");
					Console.WriteLine("INCORRECT Mpin. Try Again");
					
				}
					
				}
			Console.Clear();
				
		while (true)
        {
			
			
			Console.WriteLine(" ");
			Console.WriteLine("=================");
    	    Console.WriteLine("= E-Wallet Menu =:");
    	    Console.WriteLine("=================");
            Console.WriteLine(" ");
			Console.WriteLine("1. Check Balance");
		    Console.WriteLine("   -------------");
            Console.WriteLine("2. Deposit");
             Console.WriteLine("   -------");
            Console.WriteLine("3. Withdraw");
             Console.WriteLine("   --------");
            Console.WriteLine("4. Send");
             Console.WriteLine("   ----");
            Console.WriteLine("5. Exit");
             Console.WriteLine("   ----");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    eWallet.CheckBalance();
                    break;
                case "2":
                    eWallet.Deposit();
                    break;
                case "3":
                    eWallet.Withdraw();
                    break;
                   case"4":
              	    eWallet.Send();
                    break;
                 case "5":
                    Console.WriteLine("Exiting E-Wallet. Goodbye!");
                    Console.Clear();
                    goto go;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
   }

