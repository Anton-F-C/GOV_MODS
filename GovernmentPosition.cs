using System.Collections.Generic;

namespace Government
{
    public class GovernmentPosition
    {
        public GovernmentRole Role;
        public string Title;
        public float Salary;
        public int RequiredSkillLevel;
        public string RequiredSkillName;
        public bool IsElected;
        public bool EligibleForPension;
        public float PensionAmount;
        public int YearsForRetirement;

        public List<GovernmentRole> PromotionPath =new(); 
    }
}
