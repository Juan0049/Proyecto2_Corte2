using UnityEngine;

public class GameController : MonoBehaviour
{
    public Timer tiempoEscena;

    private void OnDestroy()
{
    if (tiempoEscena != null && GameManager.Instance != null)
    {
        GameManager.Instance.SumaTimeGlobal(tiempoEscena.TiempoActual());
    }
}
}