/*
 * Created by SharpDevelop.
 * User: 102542177
 * Date: 2/05/2019
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace psr
{
	class Program
	{
		
		
		public static string computer(Random num){
			string[] items = {"rock","paper","scissors"};
			
			return items[num.Next(0,3)];
		}
		
		public static void printWinner(string userChoice, string computerChoice, int currentRound, ref int computerScore, ref int PlayerScore){
			Console.WriteLine("Computer picked " + computerChoice);
			userChoice = userChoice.ToLower();
			computerChoice = computerChoice.ToLower();
			if(userChoice == "paper" && computerChoice == "rock" || userChoice == "rock" && computerChoice == "scissors" || userChoice == "scissors" && computerChoice == "paper") {
				Console.WriteLine("Player wins round " + currentRound);
				PlayerScore++;
			} else if (userChoice == computerChoice){
				Console.WriteLine("Round " + currentRound + " was a draw.");
			
			} else {
				Console.WriteLine("Computer wins round " + currentRound);
				computerScore++;
			}
		}
		
		
		public static void Main(string[] args)
		{
			
			
			Random num = new Random(); 
			
			string userChoice; 
			int computerScore = 0;
			int PlayerScore = 0;
			int i = 0;
			
			while(i < 3){
		
			Console.WriteLine("Enter in Paper, Scissors or Rock");
			
			userChoice = Console.ReadLine();
			Console.WriteLine("User picked " + userChoice);
			printWinner(userChoice,computer(num), i+1, ref computerScore, ref PlayerScore);
			i++;
			}
			Console.Write("\n\n\n");
			Console.WriteLine("Score : Computer - " + computerScore + "\t Player - " + PlayerScore);
			Console.Write("\n\n\n");
			if(PlayerScore > computerScore){
				Console.WriteLine("Players wins the game.");
			} else{
				Console.WriteLine("Computer wins the game");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}