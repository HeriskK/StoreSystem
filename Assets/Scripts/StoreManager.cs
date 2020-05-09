using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{

    public UIManager uiManager;
    public SelectorScript selectorScript;
    public BtnsManager btnsManager;         // Referência ao script que controla os botões.

    public int selectedObject = 0;

    public int contadorWeapons;

    Weapons sword = new Weapons("Sword", 150);
    Weapons dagger = new Weapons("Dagger", 60);
    Weapons ace = new Weapons("Ace", 80);
    Weapons bow = new Weapons("Bow", 110);

    Armor helmet = new Armor("Helmet", 60);
    Armor bodyshield = new Armor("Bodyshield", 140);
    Armor pants = new Armor("Pants", 60);
    Armor boots = new Armor("Boots", 40);

    Equipment poison = new Equipment("Poison", 40);
    Equipment ring = new Equipment("Ring", 120);
    Equipment necklace = new Equipment("Necklace", 80);
    Equipment magicStone = new Equipment("MagicStone", 450);

    private void Start()
    {
        uiManager.AlertUpdate(0); // Zera o valor do texto, como descrito na função no UIManager.
    }

    private void Update()
    {
        //SelectorBoxControllerWeapons(selectedObjectTemporary); // Função que ativa o seletor de objeto (Weapons).

        contadorWeapons = btnsManager.contadorWeapons;

        Debug.Log("Valor: " + selectedObject);
    }

    public void ExchangePurchasedObject(float price) // ------------------------------------------------------- Função para trocar objeto comprado.
    {
        if (selectedObject == 0) // Se for 0... Ou seja, nada foi comprado.
        {
            HaveHowToPay(price);
        }

        if (selectedObject != 0) // Se for DIFERENTE DE 0... 
        {
            uiManager.panelChangeItem.SetActive(true); // Ativa o painel de troca de item.
        }
    }

    public void ChangeSelectedObjectValue() // ---------------------------------------------------------------- Função ativada pelo botão de 'Confirm'.
    {
        selectedObject = 0; // Retorna o valor de 0, ou seja, não há nada comprado.

        uiManager.panelChangeItem.SetActive(false); // Desativa o painel.
    }

    public void CancelChanceObject() // ----------------------------------------------------------------------- Função ativada pelo botão de 'Cancel'.
    {
        uiManager.panelChangeItem.SetActive(false); // Desativa o painel.
    }

    public void BuySomething(int option) // ------------------------------------------------------------------- Função chamada pelo botão de 'BUY'.
    {

        // --------------------------------------------------------------- COMPRAR WEAPONS

        if (contadorWeapons == 0) // Se o contador estiver 0, ou seja, não está selecionado, então...
        {
            selectorScript.SelectorBoxControllerWeapons(0); // O seletor "desaparece".
        }

        if (option == 1) // Espada 
        {
            ExchangePurchasedObject(sword.Preco);

            //ClientManager.singleton.MyInventory.Add(sword);

            selectedObject = 1;
            selectorScript.SelectorBoxControllerWeapons(1); // Chama a função que seleciona a caixa ...
        }

        if (option == 2) // Adaga
        {
            ExchangePurchasedObject(dagger.Preco);

            //ClientManager.singleton.MyInventory.Add(dagger);

            selectedObject = 2;
            selectorScript.SelectorBoxControllerWeapons(2);
        }

        if (option == 3) // Foice
        {
            ExchangePurchasedObject(ace.Preco);

            //ClientManager.singleton.MyInventory.Add(ace);

            selectedObject = 3;
            selectorScript.SelectorBoxControllerWeapons(3);
        }

        if (option == 4) // Arco
        {
            ExchangePurchasedObject(bow.Preco);

            //ClientManager.singleton.MyInventory.Add(bow);

            selectedObject = 4;
            selectorScript.SelectorBoxControllerWeapons(4);
        }

        // --------------------------------------------------------------- COMPRAR ARMOR

        if (option == 5) // Helmet
        {
            HaveHowToPay(helmet.Preco);
            selectorScript.SelectorBoxControllerArmor(1);

            //ClientManager.singleton.MyInventory.Add(helmet);
        }

        if (option == 6) // Bodyshield
        {
            HaveHowToPay(bodyshield.Preco);
            selectorScript.SelectorBoxControllerArmor(2);

            //ClientManager.singleton.MyInventory.Add(bodyshield);
        }

        if (option == 7) // Paints
        {
            HaveHowToPay(pants.Preco);
            selectorScript.SelectorBoxControllerArmor(3);

            //ClientManager.singleton.MyInventory.Add(pants);
        }

        if (option == 8) // Boots
        {
            HaveHowToPay(boots.Preco);
            selectorScript.SelectorBoxControllerArmor(4);

            //ClientManager.singleton.MyInventory.Add(boots);
        }

        // --------------------------------------------------------------- COMPRAR EQUIPMENT

        if (option == 9) // Poison
        {
            HaveHowToPay(poison.Preco);
            selectorScript.SelectorBoxControllerEquipment(1);

            //ClientManager.singleton.MyInventory.Add(poison);
        }

        if (option == 10) // Ring
        {
            HaveHowToPay(ring.Preco);
            selectorScript.SelectorBoxControllerEquipment(2);

            //ClientManager.singleton.MyInventory.Add(ring);
        }

        if (option == 11) // Necklace
        {
            HaveHowToPay(necklace.Preco);
            selectorScript.SelectorBoxControllerEquipment(3);

            //ClientManager.singleton.MyInventory.Add(necklace);
        }

        if (option == 12) //Magic Stone
        {
            HaveHowToPay(magicStone.Preco);
            selectorScript.SelectorBoxControllerEquipment(4);

            //ClientManager.singleton.MyInventory.Add(magicStone);
        }
    }

    private void HaveHowToPay(float price) // ----------------------------------------------------- Função que verifica se ele tem dinheiro.
    {
        if (price < ClientManager.singleton.money) // Se ele tem...
        {
            ClientManager.singleton.money -= price; // Desconta o valor.

            uiManager.MoneyUpdate();
        }
        else // Senão...
        {
            uiManager.AlertUpdate(1); // Mensagem de que não há dinheiro.
        }
    }

}
