using UnityEngine;

public class Monedas : MonoBehaviour
{
    public static int totalMonedas;

    void Start()
    {
        totalMonedas = PlayerPrefs.GetInt("monedas", 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            totalMonedas++;

            PlayerPrefs.SetInt("monedas", totalMonedas);

            PlayerPrefs.Save();

            Debug.Log("Monedas: " + totalMonedas);

            Destroy(gameObject);
        }
    }
}