using System;
using System.IO;
using System.Collections;


namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            //app loop
            Boolean closeProgram = false;
            Console.WriteLine("/n/n/nWelcome to your task tracker/n/n/n");

            //ask user for their list name (if they have one)
            Console.WriteLine("Do you have a prexisting list?");
            char usersChoice = Console.ReadLine()[0];
             
            if (usersChoice == 'y'){
                Console.WriteLine("Please select from the following lists");
                //fetch the current list of task lists in inside of tasks folder and place inside of dir
                string[] dirs = Directory.GetFiles("tasks");
                
                int spot = 0;
                foreach(string dir in dirs){
                    Console.WriteLine(spot+". "+dir);
                    spot++;
                }
            }else if(usersChoice == 'n'){
                Console.WriteLine("What would you like to name your new list?");

            }
            //create a file for the user's tasks
             

            //ask user for a task to add
            Console.WriteLine("What task would you like to add to your todo list");

            //append the user's task to a 

        }


    }
}
