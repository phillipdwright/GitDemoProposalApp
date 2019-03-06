namespace GitDemoProposalsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proposalFactory = new ProposalFactory();

            var proposal = proposalFactory.Create();
        }
    }
}
