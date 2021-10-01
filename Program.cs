using System;
using taskList;
using System.Collections.Generic;
using programJobs;
//checking valid user inout
//making method loop to continously append lines to a file

namespace main
{
	class Program
	{
		static void Main(string[] args)
		{
			programJobs.Job.addEmptyLines(20);

			Console.WriteLine("\n\n\nWelcome to your task tracker\n\n\n");

			//ask user for their list name (if they have one)
			Console.WriteLine("Do you have a prexisting list or do you want to make a new one?(y/n)\n\n");

			Char usersChoice= Console.ReadLine()[0];
			if (usersChoice != 'y'){
				Console.WriteLine("Error, please enter a valid input (y or n)");
				usersChoice = Console.ReadLine()[0];
			}else if(usersChoice != 'n'){
				Console.WriteLine("Error, please enter a valid input (y or n)");
				usersChoice = Console.ReadLine()[0];
			}
			//validate userChoice
			
			Console.WriteLine("potaotoe");
			//programJobs.Job.addEmptyLines();

			
			

		}
	}
}
