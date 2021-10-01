using System.Globalization;
using System.Collections.Generic;
using programJobs;
using System;

namespace taskList
{
    public class TaskList
    {
        //fields
        private List<Task> tasks;
        private string name;

        //constructor
        public TaskList(string name){
            this.name = name;
	    this.tasks = new List<Task>();
        }

        //get methods
	public List<Task> Tasks{
		get{return tasks;}
	}

	public string Name{
		get{return name;}
	}

	public override string ToString(){
		if (this.tasks.Count == 0){
			return $"The current list {this.Name} is empty";
			}
		else{
			string tasklist = "";
			foreach (Task task in this.tasks){
				tasklist+="\n "+task;
			}
			return tasklist;
		}
	}

	//add a task to your task list
	public void addTask(){
		Task task = Job.newTask();
		tasks.Add(task);
		Console.WriteLine("Your task has been added sucessfully");
	}

	//add a task without the prompt
	public void addtask(Task task){
		tasks.Add(task);
		Console.WriteLine($"{task} has been successfully added.");
	}
    }
}
