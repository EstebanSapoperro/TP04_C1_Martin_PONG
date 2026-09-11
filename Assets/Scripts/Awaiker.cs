using UnityEngine;

public class Awaiker : MonoBehaviour
{
    [SerializeField] private GameObject llab;
    [SerializeField] private GameObject voidd;
    [SerializeField] private GameObject pong;
    [SerializeField] private GameObject did;
    [SerializeField] private GameObject didcounter;
    [SerializeField] private GameObject not;
    [SerializeField] private GameObject notcounter;
    [SerializeField] private GameObject slam;
    [SerializeField] private GameObject bricks;
    void Start()
    {
        if (GameManagerPONG.Stats.llabActive == true) 
        {
            llab.SetActive(true);
        }

        if (GameManagerPONG.Stats.pONGActive == true)
        {
            pong.SetActive(true);
        }

        if (GameManagerPONG.Stats.voidActive == true)
        {
            voidd.SetActive(true);
        }

        if (GameManagerPONG.Stats.didActive == true)
        {
            did.SetActive(true);
            didcounter.SetActive(true);
        }

        if (GameManagerPONG.Stats.notActive == true)
        {
            not.SetActive(true);
            notcounter.SetActive(true);
        }

        if (GameManagerPONG.Stats.slamActive == true)
        {
            slam.SetActive(true);
        }

        if (GameManagerPONG.Stats.bricksActive == true)
        {
            bricks.SetActive(true);
        }


    }

}
