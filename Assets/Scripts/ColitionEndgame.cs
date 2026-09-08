using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ColitionEndgame : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ball"))
        {
            Debug.Log("Un objeto de la capa correcta ha entrado al trigger.");
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
