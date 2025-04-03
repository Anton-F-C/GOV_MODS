using System.Collections.Generic;
using UnityEngine;
using Government;

public class GovernmentJobLoader : MonoBehaviour
{
    void Start()
    {
        RegisterGovernmentJobs();
    }

    void RegisterGovernmentJobs()
    {

        GovernmentPosition Courthouseclerk = new GovernmentPosition
        {
            Role = GovernmentRole.CivilClerk,
            Title = "Courthouse clerk",
            Salary = 1.0f,
            RequiredSkillName = "None",
            RequiredSkillLevel = 0,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 0f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Courthouseclerk);

        GovernmentPosition Cus/service = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Cus/service",
            Salary = 500.0f,
            RequiredSkillName = "None",
            RequiredSkillLevel = 0,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 250f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Cus/service);

        GovernmentPosition Serviceman = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Serviceman",
            Salary = 1900.0f,
            RequiredSkillName = "None",
            RequiredSkillLevel = 0,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 950f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Serviceman);

        GovernmentPosition Paperboy/Girl = new GovernmentPosition
        {
            Role = GovernmentRole.Paperboy,
            Title = "Paperboy/Girl",
            Salary = 200.0f,
            RequiredSkillName = "None",
            RequiredSkillLevel = 0,
            IsElected = false,
            EligibleForPension = false,
            PensionAmount = 0f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Paperboy/Girl);

        GovernmentPosition Pollworker = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Poll worker",
            Salary = 200.0f,
            RequiredSkillName = "None",
            RequiredSkillLevel = 0,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 100f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Pollworker);

        GovernmentPosition Campaignassistant = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Campaign assistant",
            Salary = 800f,
            RequiredSkillName = "Theory",
            RequiredSkillLevel = 3,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 400f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Campaignassistant);

        GovernmentPosition Non-profitowner = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Non-profit owner",
            Salary = 0f,
            RequiredSkillName = "None",
            RequiredSkillLevel = 0,
            IsElected = false,
            EligibleForPension = false,
            PensionAmount = 0f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Non-profitowner);

        GovernmentPosition Governmentworker = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Government worker",
            Salary = 6000.0f,
            RequiredSkillName = "Research",
            RequiredSkillLevel = 5,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 3000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Governmentworker);

        GovernmentPosition Politician = new GovernmentPosition
        {
            Role = GovernmentRole.Politician,
            Title = "Politician",
            Salary = 0f,
            RequiredSkillName = "Communication",
            RequiredSkillLevel = 4,
            IsElected = true,
            EligibleForPension = false,
            PensionAmount = 0f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Politician);

        GovernmentPosition Policechief = new GovernmentPosition
        {
            Role = GovernmentRole.PoliceOfficer,
            Title = "Police chief",
            Salary = 5000.0f,
            RequiredSkillName = "Law",
            RequiredSkillLevel = 12,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 2500f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Policechief);

        GovernmentPosition Alderman = new GovernmentPosition
        {
            Role = GovernmentRole.Alderman,
            Title = "Alderman",
            Salary = 6000.0f,
            RequiredSkillName = "Communication",
            RequiredSkillLevel = 12,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 3000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Alderman);

        GovernmentPosition Mayor = new GovernmentPosition
        {
            Role = GovernmentRole.Mayor,
            Title = "Mayor",
            Salary = 7000.0f,
            RequiredSkillName = "Communication",
            RequiredSkillLevel = 12,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 3500f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Mayor);

        GovernmentPosition Diplomat = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Diplomat",
            Salary = 9000.0f,
            RequiredSkillName = "Science",
            RequiredSkillLevel = 1,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 4500f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Diplomat);

        GovernmentPosition Governmentofficial = new GovernmentPosition
        {
            Role = GovernmentRole.None,
            Title = "Government official",
            Salary = 8000.0f,
            RequiredSkillName = "Science",
            RequiredSkillLevel = 1,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 4000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Governmentofficial);

        GovernmentPosition Senator = new GovernmentPosition
        {
            Role = GovernmentRole.Senator,
            Title = "Senator",
            Salary = 20000.0f,
            RequiredSkillName = "Science",
            RequiredSkillLevel = 1,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 10000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Senator);

        GovernmentPosition Vicepresident = new GovernmentPosition
        {
            Role = GovernmentRole.VicePresident,
            Title = "Vice president",
            Salary = 30000.0f,
            RequiredSkillName = "Science",
            RequiredSkillLevel = 1,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 15000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(Vicepresident);

        GovernmentPosition President = new GovernmentPosition
        {
            Role = GovernmentRole.President,
            Title = "President",
            Salary = 40000.0f,
            RequiredSkillName = "Science",
            RequiredSkillLevel = 1,
            IsElected = true,
            EligibleForPension = true,
            PensionAmount = 20000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(President);

        GovernmentPosition comptroller = new GovernmentPosition
        {
            Role = GovernmentRole.Comptroller,
            Title = "comptroller",
            Salary = 18000.0f,
            RequiredSkillName = "Finance",
            RequiredSkillLevel = 1,
            IsElected = false,
            EligibleForPension = true,
            PensionAmount = 9000f,
            YearsForRetirement = 15,
            PromotesTo = GovernmentRole.None
        };
        GovernmentDatabase.RegisterPosition(comptroller);

    }
}