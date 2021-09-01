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
                // Add Master Branch
                Identity identity = new Identity("Hamid", "h.irannejad@parsjahd.com");

                repo.CreateBranch("Hamid",repo.Commit("Master branch created",new Signature(identity,DateTimeOffset.Now), new Signature(identity, DateTimeOffset.Now)));
                foreach (var b in repo.Branches)
                {
                    Console.WriteLine($"{b.FriendlyName}");
                }
            }
            Console.ReadLine();
        }
    }
}
