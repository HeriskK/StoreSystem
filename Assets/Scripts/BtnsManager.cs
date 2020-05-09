using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnsManager : MonoBehaviour
{
    /*  Notas:
     *  Fiz esse script e depois descobri que dava para fazer de uma forma mais simples usando apenas os botões.
     *  No entanto eu acabei precisando saberqual painel estava ativo e utilizando esse script, é possível identificar isso.
     */


    public GameObject painelWeapons; // Gameobject do painel das Armas.
    public GameObject painelArmor; // Gameobject do painel das Armaduras.
    public GameObject painelEquipment; // Gameobject do painel dos Equipamentos.

    public int contadorWeapons = 0;
    public int contadorArmor = 0;
    public int contadorEquipment = 0;

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

    public void PainelWeapons()     // ----------------------------------------------------------- FUNÇÃO ATIVADA PELO BTN 'WEAPONS'
    {
        if(contadorWeapons == 0)    // Se o contador for 0, ou seja não esta ativo...
        {
            contadorWeapons = 1;
            contadorArmor = 0;
            contadorEquipment = 0;
        }
    }
    public void PainelArmor()       // ----------------------------------------------------------- FUNÇÃO ATIVADA PELO BTN 'ARMOR'
    {
        if (contadorArmor == 0)     // Se o contador for 0, ou seja não esta ativo...
        {
            contadorWeapons = 0;
            contadorArmor = 1;
            contadorEquipment = 0;
        }
    }
    public void PainelEquipment()   // ----------------------------------------------------------- FUNÇÃO ATIVADA PELO BTN 'EQUIPMENT'
    {
        if (contadorEquipment == 0) // Se o contador for 0, ou seja não esta ativo...
        {
            contadorWeapons = 0;
            contadorArmor = 0;
            contadorEquipment = 1;
        }
    }
    
}
