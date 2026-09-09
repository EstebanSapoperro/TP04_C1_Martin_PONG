using UnityEngine;

public class PONGMechanic : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
