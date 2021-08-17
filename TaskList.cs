using System.Globalization;
using programJobs;

namespace taskTracker
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
        public static Task[] getTasks(){
            return this.tasks;
        }
        public static string getName(){
            return this.name;
        }

        //add a new task to the task list 
        public static void addTaskToList(){
            
        }
    }
}