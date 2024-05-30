using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        OcultarVehiculos();
        vehiculos[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            MostrarVehiculos();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            OcultarVehiculos();
            int f = Random.Range(0, vehiculos.Length);
            vehiculos[f].SetActive(true);
        }
    }

    void OcultarVehiculos()
    {
        for(int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }

    void MostrarVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(true);
        }
    }
}
