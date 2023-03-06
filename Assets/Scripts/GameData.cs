using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{

    public Ray crossRay;

    public static GameData instance;

    public static GameData GetInstance() { 
        
        if (instance == null)
        {
            GameObject obj = new GameObject("SingletonGameData");
            DontDestroyOnLoad(obj);

            instance = obj.AddComponent<GameData>();  
        }
        
        
        return instance; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
