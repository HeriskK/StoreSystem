using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorScript : MonoBehaviour
{
    public GameObject selectorBoxWeapons;       // GameObject da caixa de seleção (Weapons).
    public GameObject selectorBoxArmor;         // GameObject da caixa de seleção (Armor).
    public GameObject selectorBoxEquipments;    // GameObject da caixa de seleção (Equipments).

    //public BtnsManager btnsManager; // Referência ao script que controla os botões.

    public void SelectorBoxControllerWeapons(int param)
    {
        if (param == 0)
        {
            selectorBoxWeapons.SetActive(false); // Desativa o seletor caso for 0, ou seja, não há nada comprado.
        }
        if (param == 1)
        {
            selectorBoxWeapons.SetActive(true); // Ativa o seletor... 
            selectorBoxWeapons.transform.localPosition = new Vector2(-275, 130);    // ...na posição do weapon 1.
        }
        if (param == 2)
        {
            selectorBoxWeapons.SetActive(true); // Ativa o seletor...
            selectorBoxWeapons.transform.localPosition = new Vector2(-91, 130);     // ...na posição do weapon 2.
        }
        if (param == 3)
        {
            selectorBoxWeapons.SetActive(true); // Ativa o seletor...
            selectorBoxWeapons.transform.localPosition = new Vector2(91, 130);      // ...na posição do weapon 3.
        }
        if (param == 4)
        {
            selectorBoxWeapons.SetActive(true); // Ativa o seletor...
            selectorBoxWeapons.transform.localPosition = new Vector2(275, 130);     // ...na posição do weapon 4.
        }
    }

    public void SelectorBoxControllerArmor(int param) // Controlador do 
    {
        if (param == 0)
        {
            selectorBoxArmor.SetActive(false); // Desativa o seletor caso for 0, ou seja, não há nada comprado.
        }
        if (param == 1)
        {
            selectorBoxArmor.SetActive(true);   // Ativa o seletor... 
            selectorBoxArmor.transform.localPosition = new Vector2(-275, 130);  // ...na posição do armor 1.
        }
        if (param == 2)
        {
            selectorBoxArmor.SetActive(true);   // Ativa o seletor...
            selectorBoxArmor.transform.localPosition = new Vector2(-91, 130);   // ...na posição do armor 2.
        }
        if (param == 3)
        {
            selectorBoxArmor.SetActive(true);   // Ativa o seletor...
            selectorBoxArmor.transform.localPosition = new Vector2(91, 130);    // ...na posição do armor 3.
        }
        if (param == 4)
        {
            selectorBoxArmor.SetActive(true);   // Ativa o seletor...
            selectorBoxArmor.transform.localPosition = new Vector2(275, 130);   // ...na posição do armor 4.
        }
    }

    public void SelectorBoxControllerEquipment(int param)
    {
        if (param == 0)
        {
            selectorBoxEquipments.SetActive(false); // Desativa o seletor caso for 0, ou seja, não há nada comprado.
        }
        if (param == 1)
        {
            selectorBoxEquipments.SetActive(true);  // Ativa o seletor... 
            selectorBoxEquipments.transform.localPosition = new Vector2(-275, 130); // ...na posição do equipment 1.
        }
        if (param == 2)
        {
            selectorBoxEquipments.SetActive(true);  // Ativa o seletor...
            selectorBoxEquipments.transform.localPosition = new Vector2(-91, 130);  // ...na posição do equipment 2.
        }
        if (param == 3)
        {
            selectorBoxEquipments.SetActive(true);  // Ativa o seletor...
            selectorBoxEquipments.transform.localPosition = new Vector2(91, 130);   // ...na posição do equipment 3.
        }
        if (param == 4)
        {
            selectorBoxEquipments.SetActive(true);  // Ativa o seletor...
            selectorBoxEquipments.transform.localPosition = new Vector2(275, 130);  // ...na posição do equipment 4.
        }
    }
}
