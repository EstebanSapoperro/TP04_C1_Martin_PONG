using UnityEngine;

public class GameSettingsPanel : MonoBehaviour
{
    private void Start()
    {
        GameManagerPONG.Stats.machTime = GameManagerPONG.Stats.baseMachTime;
        GameManagerPONG.Stats.machWinsCondition = GameManagerPONG.Stats.baseMachWinsCondition;
        GameManagerPONG.Stats.baseModifierRequest = GameManagerPONG.Stats.modifierRequest;
        GameManagerPONG.Stats.p1Win = false;
        GameManagerPONG.Stats.p2Win = false;
        GameManagerPONG.Stats.p1Wins = 0;
        GameManagerPONG.Stats.p2Wins = 0;

        GameManagerPONG.Stats.pONGActive = false;
        GameManagerPONG.Stats.llabActive = false;
        GameManagerPONG.Stats.voidActive = false;
        GameManagerPONG.Stats.didActive = false;
        GameManagerPONG.Stats.notActive = false;
        GameManagerPONG.Stats.bricksActive = false;
        GameManagerPONG.Stats.slamActive = false;
        RandomNumber.ReiniciarNumeros();

        Time.timeScale = 0.0f;
    }
}
