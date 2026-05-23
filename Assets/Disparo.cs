using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float velocidadBala = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject bala = Instantiate(
            balaPrefab,
            puntoDisparo.position,
            Quaternion.identity
        );

        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();

        if (transform.localScale.x > 0)
        {
            rb.linearVelocity = Vector2.right * velocidadBala;
        }
        else
        {
            rb.linearVelocity = Vector2.left * velocidadBala;
        }
    }
}