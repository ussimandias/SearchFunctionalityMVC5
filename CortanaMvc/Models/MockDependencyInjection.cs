using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CortanaMvc.Models;
using System.Security.Claims;

namespace CortanaMvc.Models
{
    public class MockDependencyInjection
    {

        public static class DependencyFactory
        {
            public static ISearchResultsService NewResultsService()
            {
                return new MockSearchResultsService();
            }
        }

        public interface ISearchResultsService
        {
            List<Claim> FindClaims(string firstName, string lastName, string ClaimNumber, string CertificateNumber, string CompanyName, DateTimeOffset EffectiveDate, int Account, string Creditor,int LoanNumber);
        }

        public class MockSearchResultsService : ISearchResultsService
        {
            public List<Claim> FindClaims(string firstName, string lastName, string ClaimNumber, string CertificateNumber, string CompanyName, DateTimeOffset EffectiveDate, int Account, string Creditor, int LoanNumber)
            {
                return new List<Claim>(new[] { new Claim {
                    
                    FirstName = "Bill", 
                    LastName = "Ryan", 
                    ClaimNumber= "asdfg2", 
                    CertificateNumber="qwerty45", 
                    CompanyName="Fortegra", 
                    EffectiveDate =DateTimeOffset.Now, 
                    Account= 232, 
                    Creditor="Wells Fargo", 
                    LoanNumber = 123456 }
                                                 
                //throw new NotImplementedException();
            });
            }
        }

        public class Claim
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ClaimNumber { get; set; }
            public string CertificateNumber { get; set; }
            public string CompanyName { get; set; }
            public DateTimeOffset EffectiveDate { get; set; }
            public int Account { get; set; }
            public string Creditor { get; set; }
            public int LoanNumber { get; set; }

        }
    }
}