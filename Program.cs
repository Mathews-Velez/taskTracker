using System.Threading.Tasks.Dataflow;
using System;
using System.IO;
using Figgle;
using taskTracker;
using programJobs;

//checking valid user inout
//making method loop to continously append lines to a file

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialize two test taskList objs
            TaskList ex1 = Job.makeANewTask();
             
            //app loop
            Boolean closeProgram = false;
            programJobs.Job.addEmptyLines();

            Console.WriteLine(FiggleFonts.Standard.Render("\n\n\nWelcome to your task tracker\n\n\n"));

            //fetch the current folder of tasks files and list each one
            string[] dirs = Directory.GetFiles("tasks");

            //initialize the variable telling us which file will be used
            int fileChoice;

            //ask user for their list name (if they have one)
            Console.WriteLine("Do you have a prexisting list?(y/n)\n\n");
            Char usersChoice=' ';
            try{
                usersChoice = Console.ReadLine()[0];
            } catch(Exception){
                Console.WriteLine("Error invalid input:\nPlease type 'y' for yes or 'n' for no");
            }
            programJobs.Job.addEmptyLines();

            //decision branch to know if user has a pre-existing list or a new one needs to be created
            if (usersChoice == 'y'){

                Console.WriteLine("Please select the corresponding spot for your file:\n\n\n");

                //list the current tasks files
                int spot = 0;
                foreach(string dir in dirs){
                    string fileName = Path.GetFileName(dir);
                    Console.WriteLine(spot+". "+fileName);
                    spot++;
                }
                
                //ask user to select which file is theirs
                programJobs.Job.addEmptyLines(3);
                fileChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dirs[fileChoice]+" has been selected\n\n\n");

                
            }else if(usersChoice == 'n'){
                Console.WriteLine("What would you like to name your new list?");
                //create a file for the user's tasks 

            }

            //
            
             

            //ask user for a task to add
            Task test1 = programJobs.Job.makeANewTask();
            Console.WriteLine(test1);
            
            

            //ask user for its priority rating (1-5)



            //append the user's task to the file and organize it to its appropriate spot 

        }


    }
}
