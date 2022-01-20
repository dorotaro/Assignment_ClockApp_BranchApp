namespace BranchApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mainBranch = new Branch();

            var branchA = mainBranch.AddBranch();
            var branchB = mainBranch.AddBranch();

            var branchA1 = branchA.AddBranch();

            var branchB1 = branchB.AddBranch();
            var branchB2 = branchB.AddBranch();
            var branchB3 = branchB.AddBranch();

            var branchB11 = branchB1.AddBranch();

            var branchB21 = branchB2.AddBranch();
            var branchB22 = branchB2.AddBranch();

            var branchB211 = branchB21.AddBranch();

            var result = mainBranch.CalculateDepth();

            Console.WriteLine(result);

            

        }
    }

    public class Branch
    {
        //ctor
        public Branch()
        {
           new List<Branch>();
        }

        public Branch AddBranch()
        {
            var newBranch = new Branch();
            return newBranch;
        }

        public static int CalculateDepth(Branch mainBranch)
        {
            for (int i = 0; i < 10; i++)
            {
                mainBranch[]
            }

            return 0;
        }
    }
}
