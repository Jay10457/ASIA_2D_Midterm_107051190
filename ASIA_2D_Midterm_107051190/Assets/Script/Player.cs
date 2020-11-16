using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Dead;
    public GameObject Final;
    public GameObject UI;
    public Text TextCount;
    int Count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Spike")
        {
            Dead.SetActive(true);
            Destroy(gameObject);
        }

        if (collision.name == "Gem")
        {
            UI.SetActive(false);
            Final.SetActive(true);
            Destroy(gameObject);
        }

        if (collision.tag == "coin")
        {
            Destroy(collision.gameObject);
            Count++;
            TextCount.text = "金幣:" + Count;
        }
    }
    
}
