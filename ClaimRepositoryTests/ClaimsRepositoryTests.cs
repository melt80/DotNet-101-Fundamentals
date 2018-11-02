using System;
using Exercise_ClaimDates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaimRepositoryTests
{
    [TestClass]
    public class ClaimsRepositoryTests
    {
        private ClaimsRepository claimList;
        private Claim claim1;
        private Claim claim2;
        [TestInitialize]
        //-- TestInit (Arrange)
        public void Arrange()
        {
            claimList = new ClaimsRepository();
            claim1 = new Claim
            {
                Amount = 5000,
                IncidentDate = Convert.ToDateTime("09/15/2018")
        };

            claim2 = new Claim
            {
                Amount = 10000,
                IncidentDate = Convert.ToDateTime("08/15/2018")
            };
        }

        [TestMethod]
        public void TestInvalidClaimIs_NotValid()
        {
            var expected = false;
            var actual = claimList.IsValid(claim2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidClaimIs_Valid()
        {
            var expected = true;
            var actual = claimList.IsValid(claim1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClaimBeingProcessedMsg_IsCorrect()
        {
            var expected = "Your claim is being processed.";
            var actual = claimList.GetMessage(claim1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestContactAgentMsg_IsCorrect()
        {
            var expected = "An agent will contact you.";
            var actual = claimList.GetMessage(claim2);

            Assert.AreEqual(expected, actual);
        }
    }
}
