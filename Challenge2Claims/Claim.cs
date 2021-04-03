using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    class Claim
    {
        public int claimID { get; set; }
        public string claimType;
        public string claimDescription;
        public double claimAmount;
        public double ClaimAmount
        {
            get
            {
                return claimAmount;
            }
            set
            {
                if (value < 0)
                {
                    claimAmount = 0;
                }
                else
                {
                    claimAmount = value;
                }
            }
        }
        public DateTime dateOfAccident; 
        public DateTime dateOfClaim;
        public bool isValid;
        
        public Claim(int claimID, string claimType, string claimDescription, double claimAmount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid)
        {
            this.claimID = claimID;
            this.claimType = claimType;
            this.claimDescription = claimDescription;
            this.claimAmount = claimAmount;
            this.dateOfAccident = dateOfAccident;
            this.dateOfClaim = dateOfClaim;
            this.isValid = isValid;
        }


    }
}
