
    public class Task
    {
        // Task fields
        private string litTask; 
        private int urgency;
        private int timeCost;

        //constructor
        public Task(string litTask, int urgency=0, int timeCost=0){
            this.litTask = litTask;
            this.urgency = urgency;
            this.timeCost = timeCost;
        }

        //get methods
        public string getLitTask(){
            return this.litTask;
        }

        public int getUrgency(){
            return this.urgency;
        }

        public int getTimeCost(){
            return this.timeCost;
        }

        //toString override
        public override string ToString(){
            return "Task: " + this.litTask + "  |" + urgency+"| |"+timeCost+"|";
    }
}