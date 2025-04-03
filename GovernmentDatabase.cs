using System.Collections.Generic;

namespace Government
{
    public static class GovernmentDatabase
    {
        public static Dictionary<GovernmentRole, GovernmentPosition> AllPositions = new();

        public static void RegisterPosition(GovernmentPosition position)
        {
            if (!AllPositions.ContainsKey(position.Role))
                AllPositions[position.Role] = position;
        }

        public static GovernmentPosition GetPosition(GovernmentRole role)
        {
            return AllPositions.ContainsKey(role) ? AllPositions[role] : null;
        }
    }
}
