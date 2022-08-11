namespace AdmissionsRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentRegistry newFee = new StudentRegistry();
            newFee.RegisterStudent();
            AdmissionFee freshAdmission = new AdmissionFee();
            double idFee = freshAdmission.IDCardFee;
            double formFee = freshAdmission.FormFee;
            double accFee = freshAdmission.AcceptanceFee;
            double medFee = freshAdmission.MedicalFee;
            double regFee = freshAdmission.RegistrationFee;
            
            Console.WriteLine("Fee breakdown:\n");
            Console.WriteLine("Form Fee: " + formFee);
            Console.WriteLine("Registration Fee: " + regFee);
            Console.WriteLine("Acceptance Fee: "+accFee);
            Console.WriteLine("Id Card fee: "+ idFee);
            Console.WriteLine("Medical Fee: "+medFee);
        }
    }
}