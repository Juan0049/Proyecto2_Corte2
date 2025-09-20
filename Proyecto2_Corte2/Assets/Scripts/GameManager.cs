using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private float globalTime = 0f;  

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);  
    }

    
    public void SumaTimeGlobal(float timeScene)
    {
        globalTime += timeScene;
        Debug.Log(" Tiempo global acumulado: " + globalTime);
    }

    
    public float GlobalTime1
    {
        get => globalTime;
        set => globalTime = value;
    }
}