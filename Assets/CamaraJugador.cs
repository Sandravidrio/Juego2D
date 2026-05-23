using UnityEngine;

public class CamaraJugador : MonoBehaviour
{
    public Transform jugador;

    void Update()
    {
        transform.position = new Vector3(
            jugador.position.x,
            jugador.position.y,
            -10
        );
    }
}