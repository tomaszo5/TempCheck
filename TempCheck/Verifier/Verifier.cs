using System;
using AmplituderChecker.Entities;
using AmplituderChecker.Repositories;
 
namespace AmplituderChecker
{
    public class Verifier
    {
        static void WorkVerifier()
        {
            WorkVerifier workVerifier = new WorkVerifier();
            workVerifier.VerifyWork();
        }
    }
}