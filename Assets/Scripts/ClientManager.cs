using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientManager : MonoBehaviour
{
    public float money = 1000;

    public static ClientManager singleton;

    public List<Classes> MyInventory = new List<Classes>(); // Criando uma lista para o inventário;

    private void Awake()
    {
        NoDestroy();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventoryCounter();
        }
    }

    void NoDestroy() // Criando singleton
    {
        //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena.
        DontDestroyOnLoad(gameObject);

        if (singleton == null && singleton != this)
        {
            singleton = this;

            //Faz com que o game object que possui esta classe não seja destruído ao trocar de cena.
            DontDestroyOnLoad(gameObject);
        }
        else
        {

            Destroy(gameObject);
        }
    }

    public void InventoryCounter()
    {
        for(int x = 0; x < MyInventory.Count; x++)
        {
            MyInventory[x].Examinar();
        }
    }
}
