namespace GitDemoProposalsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proposalFactory = new ProposalFactory();
            var proposalPublisher = new Publisher();

            var proposal = proposalFactory.Create();

            proposalPublisher.Publish(proposal);
        }
    }
}
