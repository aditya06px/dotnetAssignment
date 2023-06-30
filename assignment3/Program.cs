﻿using System.Xml.Linq;

namespace assignment3
{  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Employee
    {
        private static int autoGeneratedId;
        private int empNo;
        private String name;
        private short deptNo;
        private decimal basic;

        static Employee()
        {
            autoGeneratedId = 1;
        }
        public Employee() { this.empNo = autoGeneratedId++; }

        public Employee(String name)
        {
            this.empNo = autoGeneratedId++;
            this.name = name;
        }

        public Employee(String name, int empNo)
        {
            this.empNo = autoGeneratedId++;
            this.name = name;
        }

        public Employee(String name, decimal basic, short deptNo)
        {
            this.empNo = autoGeneratedId++;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }

        public String Name
        {
            get { return name; }
            set
            {
                if (value != "") name = value;
                else throw new Exception("name should not be blank");

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
            set
            {
                if (value >= 5_000 && value <= 10_000) basic = value;
                else throw new Exception("must be in range 5,000 and 10,000");
            }
        }


        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0) deptNo = value;
                else throw new Exception(" DeptNo must be greater than zero ");
            }
        }

        public virtual decimal  GetNetSalary()
        {
            return basic + 1_000;
        }
    }
    

    class CEO: Employee
    {
        public CEO(String name, decimal basic, short deptNo): base(name, basic, deptNo)
        {

        }
    
        public sealed override decimal GetNetSalary()
        {
            return base.Basic + 10_000;
        }
    }


    class Manager : Employee
    {
        private String designation;

        public Manager(String name, decimal basic, short deptNo,String designation): base( name,  basic,  deptNo)
        {
            this.designation = designation;
        }

        public String Designation
        {
            get { return designation; }
            set {
                if (!value.Equals(""))
                    designation = value;
                else throw new Exception("designation is required");
            }
        }
    }

   class GeneralManager: Manager
    {
        private String perks;

        public GeneralManager(String name,Decimal basic,short deptNo,String designation, String perks) :base(name, basic, deptNo, designation)
        {
            this.perks = perks;
        }
        public String Perks
        {
            get { return perks; }
            set { value = perks;  }
        }
    }
}