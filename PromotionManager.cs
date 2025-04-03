using System.Collections.Generic;
using Government;

namespace Government
{
    public static class PromotionManager
    {
        public static List<GovernmentPosition> GetEligiblePromotions(Character character, int currentYear)
        {
            var eligible = new List<GovernmentPosition>();

            foreach (var position in GovernmentDatabase.AllPositions.Values)
            {
                if (!position.IsElected)
                    continue;

                bool skillMatch = character.HasSkill(position.RequiredSkillName, position.RequiredSkillLevel);
                bool correctTerm = currentYear % position.YearsForRetirement == 0;

                if (skillMatch && correctTerm)
                {
                    eligible.Add(position);
                }
            }

            return eligible;
        }
    }

    // Stub Character class for testing/demo
    public class Character
    {
        public Dictionary<string, int> Skills = new();

        public bool HasSkill(string skill, int level)
        {
            return Skills.ContainsKey(skill) && Skills[skill] >= level;
        }
    }
}
