namespace BranchApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var structure = InitializeStructure();

            structure.CalculateDepth(structure, 1);
            
            var result = structure._maxDepth;

            Console.WriteLine($"The depth of the current structure is: {result}");
        }

        public static Branch InitializeStructure()
        {
            var mainBranch = new Branch();

            var branchA = new Branch();
            var branchB = new Branch();

            var branchA1 = new Branch();

            var branchB1 = new Branch();
            var branchB2 = new Branch();
            var branchB3 = new Branch();

            var branchB11 = new Branch();

            var branchB21 = new Branch();
            var branchB22 = new Branch();

            var branchB211 = new Branch();

            mainBranch.currentBranch.Add(branchA);
            mainBranch.currentBranch.Add(branchB);

            branchA.currentBranch.Add(branchA1);

            branchB.currentBranch.Add(branchB1);
            branchB.currentBranch.Add(branchB2);
            branchB.currentBranch.Add(branchB3);

            branchB1.currentBranch.Add(branchB11);

            branchB2.currentBranch.Add(branchB21);
            branchB2.currentBranch.Add(branchB22);

            branchB21.currentBranch.Add(branchB211);

            return mainBranch;
        }
    }
}
