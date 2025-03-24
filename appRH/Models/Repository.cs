namespace appRH.Models

{

    public class Repository

    {

        private static List<Employee> ListeEmployees = new List<Employee>();
        public static IEnumerable<Employee> GetEmployees()
        {
            return ListeEmployees;
        }
        public static void AddEmployee(Employee emp)

        {
            ListeEmployees.Add(emp);

        } 
    } 

}