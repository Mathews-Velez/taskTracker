using System;
 
namespace programJobs{
    class Job{
        //add multiple empty lines
        public static void addEmptyLines(int amount=100){
            for (int i = 0; i < amount; i++){
                Console.WriteLine();
            }

        }

        //ask user for all of the required input for a task obj
        public static Task makeANewTask(){
            Console.WriteLine("what is your task?\n");
            string litTask=Console.ReadLine();
            Console.WriteLine("What is the urgeny of this task?");
            int urgency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many minutes minutes will this task take?");
            int timeCost = Convert.ToInt32(Console.ReadLine());

            Task obj = new Task(litTask,urgency,timeCost);
            return obj;
        }
        
               
    }
}