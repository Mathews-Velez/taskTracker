using System;
using taskList;
using System.Collections.Generic;
using programJobs;

class stages{
    public static void start(Char usersChoice){
        //initialize list for tasklists
			List<TaskList> todoLists = new List<TaskList>();

			//create two dummy Lists to test
			//create test tasks and add them tp the first list
			TaskList test1 = new TaskList("house_chores");
			Task task11= new Task("clean dishes", 2, 15);
			test1.addtask(task11);
			Task task12= new Task("paint bathroom", 1, 70); 
			test1.addtask(task12);
			todoLists.Add(test1);
			
			TaskList test2 = new TaskList("workouts");
			Task task21= new Task("pushups", 1, 5);
			test2.addtask(task21);
			Task task22= new Task("situps", 2,5);
			test2.addtask(task22);
			todoLists.Add(test2);

        //decision branch to know if user has a pre-existing list or a new one needs to be created
			if (usersChoice == 'y'){
				Console.WriteLine("Please select the corresponding spot for your file:\n\n\n");
				// print the todoLists object in proper format for the user to see all the current lists
				int counter = 1;
				foreach (TaskList taskList in todoLists){
					Console.WriteLine($"{counter}.{taskList.Name}");
					counter++;
				}
				//print the task list chosen 
				int listChoice = Convert.ToInt32(Console.ReadLine())-1;
				Console.WriteLine(todoLists[listChoice]);

			}else if(usersChoice == 'n'){
				Console.WriteLine("What would you like to name your new list?");
				string taskListName = Console.ReadLine();
				//initialize task list for the user's tasks
				TaskList taskList = new TaskList(taskListName);
				todoLists.Add(taskList);
				//(remove later) print the current list of all the tasklist 
				Job.printTasklist(todoLists);
			}
    }
}