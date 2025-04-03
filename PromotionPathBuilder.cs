using System.Collections.Generic;

namespace Government
{
    public static class PromotionPathBuilder
    {
        public static void AssignPromotionPaths()
        {
            var db = GovernmentDatabase.AllPositions;

            if (db.ContainsKey(GovernmentRole.Alderman))
                db[GovernmentRole.Alderman].PromotionPath.Add(GovernmentRole.Mayor);

            if (db.ContainsKey(GovernmentRole.Mayor))
                db[GovernmentRole.Mayor].PromotionPath.Add(GovernmentRole.CongressOfficial); // Government Official

            if (db.ContainsKey(GovernmentRole.CongressOfficial)) // Government Official
                db[GovernmentRole.CongressOfficial].PromotionPath.Add(GovernmentRole.Politician); // Diplomat

            if (db.ContainsKey(GovernmentRole.Politician)) // Diplomat
                db[GovernmentRole.Politician].PromotionPath.Add(GovernmentRole.Senator);

            if (db.ContainsKey(GovernmentRole.Senator))
                db[GovernmentRole.Senator].PromotionPath.Add(GovernmentRole.VicePresident);

            if (db.ContainsKey(GovernmentRole.VicePresident))
                db[GovernmentRole.VicePresident].PromotionPath.Add(GovernmentRole.President);

            // Keep prior non-political paths
            if (db.ContainsKey(GovernmentRole.CivilClerk))
                db[GovernmentRole.CivilClerk].PromotionPath.Add(GovernmentRole.Judge);

            if (db.ContainsKey(GovernmentRole.Judge))
                db[GovernmentRole.Judge].PromotionPath.Add(GovernmentRole.Mayor);

            if (db.ContainsKey(GovernmentRole.PoliceOfficer))
                db[GovernmentRole.PoliceOfficer].PromotionPath.Add(GovernmentRole.PoliceChief);

            if (db.ContainsKey(GovernmentRole.MilitarySoldier))
                db[GovernmentRole.MilitarySoldier].PromotionPath.Add(GovernmentRole.MilitaryGeneral);

            if (db.ContainsKey(GovernmentRole.OfficeSecretary))
                db[GovernmentRole.OfficeSecretary].PromotionPath.Add(GovernmentRole.MayorAssistant);

            if (db.ContainsKey(GovernmentRole.MayorAssistant))
                db[GovernmentRole.MayorAssistant].PromotionPath.Add(GovernmentRole.Mayor);

            if (db.ContainsKey(GovernmentRole.NonProfitLeader))
                db[GovernmentRole.NonProfitLeader].PromotionPath.Add(GovernmentRole.Politician);
        }
    }
}
