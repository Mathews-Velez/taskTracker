using System;
using taskList;
using System.Collections.Generic;

namespace programJobs{
    class Job{
	//rename this file utils
	
        //add multiple empty lines
        public static void addEmptyLines(int amount=100){
            for (int i = 0; i < amount; i++){
                Console.WriteLine();
            }

        }

        //ask user for all of the required input for a task obj
        public static Task newTask(){
            Console.WriteLine("what is your task?\n");
            string litTask=Console.ReadLine();
            Console.WriteLine("What is the urgeny of this task?");
            int urgency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many minutes minutes will this task take?");
            int timeCost = Convert.ToInt32(Console.ReadLine());

            Task obj = new Task(litTask,urgency,timeCost);
            return obj;
        }

	public static void printTasklist(List<TaskList> objList){
		if (objList.Count == 0){
			Console.WriteLine("You have no task lists available.");
		}else{
			foreach(TaskList obj in objList){
				Console.WriteLine(obj);
			} 
		}
	  }

    public static Char inputValidator(char input){
        while (input != 'y'||input != 'n'){
                Console.WriteLine("Error, please enter a valid input");
                input = Console.ReadLine()[0];
            }
        return input;
    }
   }
}
