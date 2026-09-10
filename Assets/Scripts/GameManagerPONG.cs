using UnityEngine;

public class GameManagerPONG : MonoBehaviour
{
    public static class Stats 
    {

        public static int baseMachTime = 20;
        public static int baseMachWinsCondition = 3;
        public static int machTime = 20;
        public static int machWinsCondition = 3;

        public static int baseModifierRequest = 2;
        public static int modifierRequest = 2;
        public static int actualModifierRequest = 0;


        public static bool p1movingUp = false;
        public static bool p1movingDown = false;
        public static bool p1movingRight = false;
        public static bool p1movingLeft = false;

        public static bool p2movingUp = false;
        public static bool p2movingDown = false;
        public static bool p2movingRight = false;
        public static bool p2movingLeft = false;

        public static bool p1Win = false;
        public static bool p2Win = false;

        public static int p1Wins = 0;
        public static int p2Wins = 0;

        public static bool inTrasition = false;
        public static bool pONGActive = false;
        public static bool llabActive = false;
        public static bool slamActive = false;
        public static bool voidActive = false;
        public static bool bricksActive = false;
        public static bool didActive = false;
        public static bool notActive = false;

    }
}
