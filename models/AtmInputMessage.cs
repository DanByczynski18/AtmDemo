using System.Collections.Generic;

namespace AtmDemo
{
    public class AtmInputMessage
    {
        #region Constructor

        public AtmInputMessage()
        {
            CountRequests = new List<int>();
        }

        #endregion

        #region Public Properties

        public int Command { get; set; }

        public int WithdrawalAmount { get; set; }

        public List<int> CountRequests { get; set; }

        #endregion
    }
}