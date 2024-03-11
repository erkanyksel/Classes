using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        //Söz Dizimi
        // class Sınıf Adı
        // {
        // [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
        // [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
        // {
        //     Method Komutları
        // }
        // }

        // Erişim Belirleyiciler
        //  * Public
        //  * Private
        //  * internal sadece proje içerisinden erişilebilir
        //  * Protected  bulunduğu sınıf ya da kaltım alınan sınıflardan kullanılabilir.
        Employee employee = new Employee();
        employee.name = "Erkan";
        employee.surname = "Yüksel";
        employee.empNo = 2;
        employee.deparment = "IT";

        employee.EmployeeInformation();
        Console.WriteLine("***************");

        Employee employee2 = new Employee();
        employee2.name = "Deniz";
        employee2.surname = "Arda";
        employee2.empNo = 3;
        employee2.deparment = "HR";

        employee2.EmployeeInformation();

    }

    class Employee
    {
        public string name;
        public string surname;
        public int empNo;
        public string deparment;

        public void EmployeeInformation()
        {
            Console.WriteLine("Emloyee Name : {0}", name);
            Console.WriteLine("Emloyee SurName : {0}", surname);
            Console.WriteLine("Emloyee no : {0}", empNo);
            Console.WriteLine("Emloyee Deparment : {0}", deparment);
        }
    }
}