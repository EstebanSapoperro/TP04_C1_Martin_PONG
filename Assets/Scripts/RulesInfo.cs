using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class RulesInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text rules;
    [SerializeField] private Sprite[] faces;
    [SerializeField] private Image visualSprite;
    private Sprite actualSprite;
    public void asingEnemy(int enemy) 
    {
        actualSprite = faces[enemy -1];
        visualSprite.sprite = actualSprite;

        if (enemy == 1) 
        {
            title.text = "Aparecio LLAB";
            rules.text = "Hay una segunda bola en el ring, no dejes que toque tu laser, esta bola no cuenta para el desempate";
        }

        if (enemy == 2)
        {
            title.text = "Aparecio Slam";
            rules.text = "Aparecera una segunda bola detras de tu lado del ring, no dejes que toque tu laser";
        }

        if (enemy == 3)
        {
            title.text = "Aparecio Void";
            rules.text = "el suelo va a parpadear 3 veces, cuando llegue a la tercera, tu color interior debera de ser negro, chocaque con las paredes para cambiar a color negro";
        }

        if (enemy == 4)
        {
            title.text = "Aparecio Did";
            rules.text = "Una televicion estara arriba a la izquierda, cuando su contador llegue a cero, deberas de avanzar hacia la direccion que se muestra en su pantalla";
        }

        if (enemy == 5)
        {
            title.text = "Aparecio Not";
            rules.text = "Una televicion estara arriba a la derecha, cuando su contador llegue a cero, NO deberas de avanzar hacia la direccion que se muestra en su pantalla";
        }

        if (enemy == 6)
        {
            title.text = "Aparecio PONG";
            rules.text = "NO LO TOQUES... no pasa nada si choca con tu laser";
        }

        if (enemy == 7)
        {
            title.text = "Aparecio Bricks";
            rules.text = "saldran ladrillos en el medio que van a estorbar";
        }

    }



}
