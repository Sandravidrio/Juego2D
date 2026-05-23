using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;
    private bool estaEnSuelo = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(
            movimiento * velocidad,
            rb.linearVelocity.y
        );

        if (movimiento > 0)
        {
            transform.localScale = new Vector3(0.8f, 1.5f, 1);
        }
        else if (movimiento < 0)
        {
            transform.localScale = new Vector3(-0.8f, 1.5f, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && estaEnSuelo)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                fuerzaSalto
            );
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnSuelo = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnSuelo = false;
        }
    }
}