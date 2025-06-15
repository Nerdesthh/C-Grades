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

                if (subjectGWA >= 75 && subjectGWA <= 89)
                {
                    Console.WriteLine("Remarks: PASSED");
                }

                else if (subjectGWA >= 90 && subjectGWA <= 94)
                {
                    Console.WriteLine("Remarks: With Honors");
                }

                else if (subjectGWA >= 95 && subjectGWA <= 97)
                {
                    Console.WriteLine("Remarks: With High Honors");
                }

                else if (subjectGWA >= 98 && subjectGWA <= 100)
                {
                    Console.WriteLine("Remarks: With Highest Honors");
                }

                else
                {
                    Console.WriteLine("Remarks: FAILED");
                }
            }


            if (strand == "HUMMS")
            {
                Console.WriteLine("You are in HUMMS strand\n");
                Console.WriteLine("There are four subjects in HUMMS strand\n");
                Console.WriteLine("1. Filipino\n 2. Philisophy \n3. English\n4. Mathematics");

                int Filipino, Philisophy, English, Mathematics;
                double subjectGWA;
                int subject;

                Console.WriteLine("Enter your grades in Filipino: ");
                Filipino = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Philisophy: ");
                Philisophy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in English: ");
                English = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Mathematics: ");
                Mathematics = Convert.ToInt32(Console.ReadLine());

                subject = Filipino + Philisophy + English + Mathematics;
                subjectGWA = subject / 4;
                Console.WriteLine("Your GWA is: " + subjectGWA);

                if (subjectGWA >= 75 && subjectGWA <= 89)
                {
                    Console.WriteLine("Remarks: PASSED");
                }

                else if (subjectGWA >= 90 && subjectGWA <= 94)
                {
                    Console.WriteLine("Remarks: With Honors");
                }

                else if (subjectGWA >= 95 && subjectGWA <= 97)
                {
                    Console.WriteLine("Remarks: With High Honors");
                }

                else if (subjectGWA >= 98 && subjectGWA <= 100)
                {
                    Console.WriteLine("Remarks: With Highest Honors");
                }

                else
                {
                    Console.WriteLine("Remarks: FAILED");
                }
            }

            if (strand == "ABM")
            {
                Console.WriteLine("You are in ABM strand\n");
                Console.WriteLine("There are four subjects in ABM strand\n");
                Console.WriteLine("1. Accountancy\n2. Business Management\n3. Economics\n4. Mathematics");

                int Accountancy, BusinessManagement, Economics, Mathematics;
                double subjectGWA;
                int subject;

                Console.WriteLine("Enter your grades in Accountancy: ");
                Accountancy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Business Management: ");
                BusinessManagement = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Economics: ");
                Economics = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Mathematics: ");
                Mathematics = Convert.ToInt32(Console.ReadLine());

                subject = Accountancy + BusinessManagement + Economics + Mathematics;
                subjectGWA = subject / 4;
                Console.WriteLine("Your GWA is: " + subjectGWA);

                if (subjectGWA >= 75 && subjectGWA <= 89)
                {
                    Console.WriteLine("Remarks: PASSED");
                }

                else if (subjectGWA >= 90 && subjectGWA <= 94)
                {
                    Console.WriteLine("Remarks: With Honors");
                }

                else if (subjectGWA >= 95 && subjectGWA <= 97)
                {
                    Console.WriteLine("Remarks: With High Honors");
                }

                else if (subjectGWA >= 98 && subjectGWA <= 100)
                {
                    Console.WriteLine("Remarks: With Highest Honors");
                }

                else
                {
                    Console.WriteLine("Remarks: FAILED");
                }
            }

            if (strand == "ICT")
            {
                Console.WriteLine("You are in ICT strand\n");
                Console.WriteLine("There are four subjects in ICT strand\n");
                Console.WriteLine("1. Computer Programming\n2. Computer Hardware\n3. Computer Networking\n4. Mathematics");

                int ComputerProgramming, ComputerHardware, ComputerNetworking, Mathematics;
                double subjectGWA;
                int subject;

                Console.WriteLine("Enter your grades in Computer Programming: ");
                ComputerProgramming = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Computer Hardware: ");
                ComputerHardware = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Computer Networking: ");
                ComputerNetworking = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Mathematics: ");
                Mathematics = Convert.ToInt32(Console.ReadLine());

                subject = ComputerProgramming + ComputerHardware + ComputerNetworking + Mathematics;
                subjectGWA = subject / 4;
                Console.WriteLine("Your GWA is: " + subjectGWA);

                if (subjectGWA >= 75 && subjectGWA <= 89)
                {
                    Console.WriteLine("Remarks: PASSED");
                }

                else if (subjectGWA >= 90 && subjectGWA <= 94)
                {
                    Console.WriteLine("Remarks: With Honors");
                }

                else if (subjectGWA >= 95 && subjectGWA <= 97)
                {
                    Console.WriteLine("Remarks: With High Honors");
                }

                else if (subjectGWA >= 98 && subjectGWA <= 100)
                {
                    Console.WriteLine("Remarks: With Highest Honors");
                }

                else
                {
                    Console.WriteLine("Remarks: FAILED");
                }
            }

            if (strand == "HE")
            {
                Console.WriteLine("You are in HE strand\n");
                Console.WriteLine("There are four subjects in HE strand\n");
                Console.WriteLine("1. Baking and Pastry\n2. Cooking and Baking\n3. Culinary Arts\n4. Mathematics");

                int BakingPastry, CookingBaking, CulinaryArts, Mathematics;
                double subjectGWA;
                int subject;

                Console.WriteLine("Enter your grades in Baking & Pastry: ");
                BakingPastry = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Cooking & Baking: ");
                CookingBaking = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Culinary Arts: ");
                CulinaryArts = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your grades in Mathematics: ");
                Mathematics = Convert.ToInt32(Console.ReadLine());

                subject = BakingPastry + CookingBaking + CulinaryArts + Mathematics;
                subjectGWA = subject / 4;
                Console.WriteLine("Your GWA is: " + subjectGWA);

                if (subjectGWA >= 75 && subjectGWA <= 89)
                {
                    Console.WriteLine("Remarks: PASSED");
                }

                else if (subjectGWA >= 90 && subjectGWA <= 94)
                {
                    Console.WriteLine("Remarks: With Honors");
                }

                else if (subjectGWA >= 95 && subjectGWA <= 97)
                {
                    Console.WriteLine("Remarks: With High Honors");
                }

                else if (subjectGWA >= 98 && subjectGWA <= 100)
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
