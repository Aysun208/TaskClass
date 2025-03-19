namespace AysunProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Group group1 = new Group("BB208", "Gunorta");
            Student student1 = new Student("Aysun" , "Mahmudlu" , "Qadin" , 20 , "0505505050", 2 ,"BB208" );
            Console.WriteLine();

           

            group1.AddStudent(student1);

             
            
  
        }
    }
}
