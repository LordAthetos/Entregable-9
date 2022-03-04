using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
    private float PlayerPosX;
    private float PlayerPosY;
    private float PlayerPosZ;

    void Start()
    {
        // Recupera las coordenadas de PlayerPrefs y se las asigna al player
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerPosX"), PlayerPrefs.GetFloat("PlayerPosY"), PlayerPrefs.GetFloat("PlayerPosZ"));
    }

    
    void Update()
    {
        // guarda las coordenadas actuales del player en PlayerPrefs
        PlayerPrefs.SetFloat("PlayerPosX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", transform.position.z);
    }
}
