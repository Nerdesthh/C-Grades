namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose your strand:");
            Console.WriteLine("1. STEM\n2. HUMSS\n3. ABM\n4. ICT\n5. HE\n");

            string strand = Console.ReadLine();

            if (strand == "STEM")
            {
                Console.WriteLine("You are in STEM strand\n");
                Console.WriteLine("There are four subjects in STEM strand\n");
                Console.WriteLine("1. Physics\n2. Chemistry\n3. Biology\n4. Mathematics");

                int physics, chemistry, biology, mathematics;
                double subjectGWA;
                int subject;

                Console.WriteLine("Enter your grades in Physics: ");
                physics = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Chemestry: ");
                chemistry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Biology: ");
                biology = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Mathematics: ");
                mathematics = Convert.ToInt32(Console.ReadLine());

                subject = physics + chemistry + biology + mathematics;
                subjectGWA = subject / 4;
                Console.WriteLine("Your GWA is: " + subjectGWA);

                if (subjectGWA <= 75 && subjectGWA >= 89)
                {
                    Console.WriteLine("Remarks: PASSED");
                }

                else if (subjectGWA >= 90 && subjectGWA < 94)
                {
                    Console.WriteLine("Remarks: With Honors");
                }

                else if (subjectGWA >= 95 && subjectGWA < 97)
                {
                    Console.WriteLine("Remarks: With High Honors");
                }
                
                else if (subjectGWA >= 98 && subjectGWA < 100)
                {
                    Console.WriteLine("Remarks: With Highest Honors");
                }

                else
                {
                    Console.WriteLine("Remarks: FAILED");
                }
            }
        }
    }
}
