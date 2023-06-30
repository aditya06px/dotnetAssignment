namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {

            Employee e = new Employee();

            e.DeptNo = 1;
            e.EmpNo = 1;
            e.Name = "pavan";
            e.Basic = 7000;

                Console.WriteLine(e.GetNetSalary());   
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }


    class Employee
    {
        private String name;
        private int empNo;
        private decimal basic;
        private short deptNo;

        public Employee() { }

       public String Name
        {
            get { return name; }
            set {
                if (value != "") name = value;
                else   throw new Exception("name should not be blank");
                
            }
        }

        public int EmpNo
        {
            get { return empNo; }
            set
            {
                if (value > 0) empNo = value;
                else throw new Exception("emp no should be greater than 0");
            }
        }

        public decimal Basic
        {
             
            get { return basic; }
            set {
                if (value >= 5_000 && value <= 10_000) basic = value;
                else throw new Exception("must be in range 5,000 and 10,000");
            }
        }


        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if(value > 0) deptNo = value;   
                else throw new Exception(" DeptNo must be greater than zero ");
            }
        }

        public decimal GetNetSalary()
        {
            return basic + 1_000;
        }
    }

    //Create a Class Employee with the following specifications


    //Properties
    //----------
    //string Name -> no blank names should be allowed
    //int EmpNo -> must be greater than 0
    //decimal Basic -> must be between some range
    //short DeptNo -> must be > 0

    //Methods
    //-------
    //decimal GetNetSalary() -> returns calculated net salary (Use any formula to get net salary based on Basic salary)
}