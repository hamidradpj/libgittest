using System;
using LibGit2Sharp;

namespace libgittest
{
    class Program
    {
        static void Main(string[] args)
        {

            string gitPath = Repository.Init("./");

            using (var repo = new Repository(gitPath))
            {
                Identity identity = new Identity("Hamid", "h.irannejad@parsjahd.com");
                Commit commit = repo.Commit("first commit", new Signature(identity, DateTimeOffset.Now), new Signature(identity, DateTimeOffset.Now));
                repo.CreateBranch("Hamid");
                foreach (var b in repo.Branches)
                {
                    Console.WriteLine($"{b.FriendlyName}");
                }
                var branch = repo.Branches["Hamid"];
                if (branch is not null)
                {
                    var b =Commands.Checkout(repo, branch);
                    repo.CreateBranch("Hamid2");

                }
            }
            Console.ReadLine();
        }
    }
}
