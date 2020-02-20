using System.Collections.Generic;
using System.Linq;
using CorePool.Mining;

namespace CorePool.Blockchain.Cryptonote
{
    public class CryptonoteWorkerContext : WorkerContextBase
    {
        /// <summary>
        /// Usually a wallet address
        /// NOTE: May include paymentid (seperated by a dot .)
        /// </summary>
        public string Miner { get; set; }

        /// <summary>
        /// Arbitrary worker identififer for miners using multiple rigs
        /// </summary>
        public string Worker { get; set; }

        private List<CryptonoteWorkerJob> validJobs { get; } = new List<CryptonoteWorkerJob>();

        public void AddJob(CryptonoteWorkerJob job)
        {
            validJobs.Insert(0, job);

            while(validJobs.Count > 4)
                validJobs.RemoveAt(validJobs.Count - 1);
        }

        public CryptonoteWorkerJob FindJob(string jobId)
        {
            return validJobs.FirstOrDefault(x => x.Id == jobId);
        }
    }
}
