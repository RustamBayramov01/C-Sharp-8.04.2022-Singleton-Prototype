using System;

namespace ConsoleApp1
{

    public class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Employee(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
    

    public interface ISharedFolder { void PerformRWOperations(); }


    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations() { Console.WriteLine("Paylasilan Qovluqda Oxu Yazma emeliyyatinin yerine yetirilmesi"); }
    }


    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;
        public SharedFolderProxy(Employee emp) { employee = emp; }
        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "ADMIN")
            {
                folder = new SharedFolder();
                Console.WriteLine("Paylasilan Qovluq Proksi RealFolder PreformRWOperations metoduna muraciyet edir");
                folder.PerformRWOperations();
            }
            else { Console.WriteLine("Paylasilan Qovluq proksisi Bu Qovluga daxil olmaq ucun icazeniz yoxdur"); }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Musteri Rol Tertibatci ile iscini qovluga proksiye oturur");
            Employee emp1 = new Employee("Lufit", "Lufit123", "Lufit12345");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
        }
    }
}
