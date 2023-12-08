namespace Assignment3
{

    class Classroom
    {
        // Private member variables
        private string classroomNumber;
        private int capacity;
        private bool hasProjector;
        private bool isLectureInProgress;

        // Constructor to initialize the object
        public Classroom(string classroomNumber, int capacity, bool hasProjector)
        {
            this.classroomNumber = classroomNumber;
            this.capacity = capacity;
            this.hasProjector = hasProjector;
            this.isLectureInProgress = false;
        }

        // Private method to start a lecture
        private void StartLecture()
        {
            if (!isLectureInProgress)
            {
                Console.WriteLine($"Starting a lecture in Classroom {classroomNumber}...");
                isLectureInProgress = true;
            }
            else
            {
                Console.WriteLine("A lecture is already in progress.");
            }
        }

        // Private method to end a lecture
        private void EndLecture()
        {
            if (isLectureInProgress)
            {
                Console.WriteLine($"Ending the lecture in Classroom {classroomNumber}...");
                isLectureInProgress = false;
            }
            else
            {
                Console.WriteLine("No lecture is currently in progress.");
            }
        }

        // Public method to display information about the classroom
        public void DisplayClassroomInfo()
        {
            Console.WriteLine($"Classroom Information: {classroomNumber}");
            Console.WriteLine($"Capacity: {capacity} students");
            Console.WriteLine($"Has Projector: {(hasProjector ? "Yes" : "No")}");
            Console.WriteLine($"Lecture Status: {(isLectureInProgress ? "In Progress" : "Not in Progress")}");
        }

        // Public method to simulate starting a lecture
        public void StartLectureSimulation()
        {
            StartLecture();
            DisplayClassroomInfo();
        }

        // Public method to simulate ending a lecture
        public void EndLectureSimulation()
        {
            EndLecture();
            DisplayClassroomInfo();
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the Classroom class
            Classroom myClassroom = new Classroom("101", 30, true);

            // Call methods to interact with the classroom
            myClassroom.DisplayClassroomInfo();

            // Start a lecture in the classroom
            myClassroom.StartLectureSimulation();

            // Try starting another lecture (should show a message that a lecture is already in progress)
            myClassroom.StartLectureSimulation();

            // End the ongoing lecture
            myClassroom.EndLectureSimulation();
        }
    }
}





