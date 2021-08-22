using System.Globalization;
using programJobs;

namespace taskList
{
    public class TaskList
    {
        //fields
        private Task[] tasks;
        private string name;

        //constructor
        public TaskList(string name){
            this.name = name;
        }

        //get methods 
        public Task[] getTasks(){
            return this.tasks;
        }
        public string getName(){
            return this.name;
        }

        /*add a new task to the task list 
        public void addTaskToList(){
            Task task =Job.makeANewTask();
            this.tasks.Add(task);

        }*/
    }
}