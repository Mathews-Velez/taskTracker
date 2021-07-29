using System;
using System.IO;

namespace programJobs{
    class jobs{
        //check for the existence of the given file
        static Boolean fileCheck(string filename){
            filename = filename+".txt";
            if (File.Exists(filename)){
                return true;
            } else {
                return false;
            }
        }
               
    }
}