namespace BranchApp
{
    public class Branch
    { 
        public List<Branch> currentBranch;
        public int _maxDepth = 1;

        public Branch()
        {
            currentBranch = new List<Branch>();
        }

        public void CalculateDepth(Branch branch, int level)
        { 
            if (branch.currentBranch.Count > 0)
            {
                foreach (var singleBranch in branch.currentBranch)
                {
                    CalculateDepth(singleBranch, level + 1);
                }
            }
            else if (level > _maxDepth)
            {
                _maxDepth = level;
            }
            
        }

    }
}
