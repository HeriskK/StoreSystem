using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnsManager : MonoBehaviour
{

    public GameObject painelWeapons; // Gameobject do painel das Armas.
    public GameObject painelArmor; // Gameobject do painel das Armaduras.
    public GameObject painelEquipment; // Gameobject do painel dos Equipamentos.

    private int contadorWeapons = 0;
    private int contadorArmor = 0;
    private int contadorEquipment = 0;

    void Start()
    {
        contadorWeapons = 1; // Ativa o painel de Weapons, de modo a não deixar em branco o espaço onde ficam os paineis.
    }

    void Update()
    {
        GeralManager();
    }


    void GeralManager()
    {
        if (contadorWeapons == 0) // Se o contadorWeapons for 0...
        {
            painelWeapons.SetActive(false); // Desativa o painel.
        }
        else // Se for 1...
        {
            painelWeapons.SetActive(true); // Ativa o painel.
        }

        if (contadorArmor == 0) // Se o contadorArmor for 0...
        {
            painelArmor.SetActive(false); // Desativa o painel.
        }
        else // Se for 1...
        {
            painelArmor.SetActive(true); // Ativa o painel.
        }

        if (contadorEquipment == 0) // Se o contadorEquipment for 0...
        {
            painelEquipment.SetActive(false); // Desativa o painel.
        }
        else // Se for 1...
        {
            painelEquipment.SetActive(true); // Ativa o painel.
        }
    }

    public void PainelWeapons()
    {
        if(contadorWeapons == 0) // Se o contador for 0, ou seja não esta ativo...
        {
            contadorWeapons = 1;
            contadorArmor = 0;
            contadorEquipment = 0;
        }
    }
    public void PainelArmor()
    {
        if (contadorArmor == 0) // Se o contador for 0, ou seja não esta ativo...
        {
            contadorWeapons = 0;
            contadorArmor = 1;
            contadorEquipment = 0;
        }
    }
    public void PainelEquipment()
    {
        if (contadorEquipment == 0) // Se o contador for 0, ou seja não esta ativo...
        {
            contadorWeapons = 0;
            contadorArmor = 0;
            contadorEquipment = 1;
        }
    }
    
}
