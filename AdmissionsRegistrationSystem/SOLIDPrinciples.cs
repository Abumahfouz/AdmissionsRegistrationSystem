using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionsRegistrationSystem
{
    internal class FindFee : AdmissionFee //Inherits Admission Fee and uses objects of Total Tuition, which inherited Total Tuition Fee
    {
        
        public override double CalculateTotalTuition()
        {
            double depFee=0;
            
            DepartmentInfo departmentInfo = new DepartmentInfo();
            Console.WriteLine("Enter department chosen between medical/engineering/sciences: ");
            string entry = Console.ReadLine();
            entry.ToLower();
            if (entry == "medical")
            {
                depFee = 300000;
            }
            else if (entry == "engineering")
            {
                depFee = 250000;
            }
            else if (entry == "sciences")
            {
                depFee = 180000;
            }
            AdmissionFee newFees = new AdmissionFee();
            double fees = newFees.MedicalFee + newFees.FormFee + newFees.AcceptanceFee + newFees.IDCardFee + depFee;
            

            return fees;
        }
    }
    
    internal class DepartmentInfo 
    {
        public string DepartmentID { get; set; }
        public double DepartmentFee { get; set; }
        
    }
    internal class AdmissionFee : TotalTuitionFee //Admission inherits the TotalTuitionFee class and sheares the same behaviour as it (LISKOV Substitution Principle)
    {
        public double RegistrationFee { get; } = 15000;
        public double FormFee { get; } = 10000;
        public double MedicalFee { get; } = 3000;
        public double AcceptanceFee { get; } = 5000;
        public double IDCardFee { get; } = 2500;

        /// <summary>
        /// Abstraction implemented, to prevent having to modify base class, an implementation of the Open and Closed Principle
        /// </summary>
        /// <returns></returns>
        public override double CalculateTotalTuition() 
        {
       
                DepartmentInfo departmentInfo = new DepartmentInfo();
                double fee = departmentInfo.DepartmentFee;
                double totalFee = (RegistrationFee + FormFee + MedicalFee + AcceptanceFee + IDCardFee + fee);
                return totalFee;
            

            
        }
        

    }
    /// <summary>
    /// Following the Single Responsibility Principle, the student Registry handles only student registration
    /// </summary>
    internal class StudentRegistry
    {
        public string RegisterStudent()
        {

            try
            {
                int nin;
                bool myParse;
                string name;
                Console.WriteLine("Enter new Full Name: \n");
                name = Console.ReadLine();
                Console.WriteLine("Enter National ID Number : \n");
                myParse = int.TryParse(Console.ReadLine(), out nin);
                Console.WriteLine( "Congratulations " + name + "! Your ID is " + nin);
            }
            catch (Exception myError)
            {

                Console.WriteLine(myError.Message);
            }
            return "Welcome";
        }
    }
    public abstract class TotalTuitionFee
    {
        public abstract double CalculateTotalTuition(); 
    }
}

