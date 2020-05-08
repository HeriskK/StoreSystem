using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    /*
    public UIManager uiManager;

    public float valorTemporario;

    public static float dinheiro = 10000; // static = modificavel em qualquer script (Colocar nome da clase e da variavel). 

    // Criação de Items:

    public Weapons weapon = new Weapons(0); // O valor sera mudado conforme o que esta determinado no parâmetro do botão.

    public Armor armor = new Armor(0);

    public Equipment equipment = new Equipment(0);

    // --------------------------------------------------------------------------- COMPRAR WEAPONS
    public void BuyWeapons(float value) //...Atualizar o dinheiro
    {
        if (weapon.accumulative == false)
        {
            uiManager.panelChangeItem.SetActive(true); // Ativa o painel de troca de item.

            valorTemporario = value;

            return; // 
        }
        else
        {
            // weapon.name = name; // Atualiza o nome...
            weapon.Preco = value;

            HaveHowToPay(weapon);

            weapon.accumulative = false;
        }
    }

    public void ChangeAccumulativeValue()
    {
        dinheiro -= valorTemporario;

        uiManager.panelChangeItem.SetActive(false);

        HaveHowToPay(weapon);
    }

    // --------------------------------------------------------------------------- COMPRAR ARMOR
    public void BuyArmor(float value)
    {
        //armor.name = name; // Atualiza o nome...
        armor.Preco = value;
        HaveHowToPay(armor);
    }

    // --------------------------------------------------------------------------- COMPRAR EQUIPMENT
    public void BuyEquipment(float value)
    {
        //equipment.name = name; // Atualiza o nome...
        equipment.Preco = value;
        HaveHowToPay(equipment);
    }


    private void HaveHowToPay(Classes classe) // Função que verifica se ele tem dinheiro.
    {
        if (classe.Preco < dinheiro) // Se ele tem...
        {
            dinheiro -= classe.Preco; // Desconta o valor.

            uiManager.MoneyUpdate();
        }
        else // Senão...
        {
            uiManager.AvisosUpdate(1); // Mensagem de que não há dinheiro.
        }
    }
    */

    public UIManager uiManager;

    public bool accumulative = true;

    Weapons espada = new Weapons(100);
    Weapons adaga = new Weapons(150);
    Weapons foice = new Weapons(200);
    Weapons arco = new Weapons(250);

    Armor helmet = new Armor(50);
    Armor bodyshield = new Armor(100);
    Armor pants = new Armor(150);
    Armor boots = new Armor(200);

    Equipment poison = new Equipment(50);
    Equipment ring = new Equipment(100);
    Equipment necklace = new Equipment(150);
    Equipment magicStone = new Equipment(200);

    public void ChangeAccumulativeValue()
    {
        if (accumulative == false) // Se for falso... 
        {
            uiManager.panelChangeItem.SetActive(true); // Abre o painel.
            return;
        }
    }

    public void ChangeAccumulativeValueToTrue()
    {
        accumulative = true;
    }

    public void BuySomething(int option)
    {
        // --------------------------------------------------------------- COMPRAR WEAPONS

        if (option == 1) // Espada
        {
            ChangeAccumulativeValue();

            HaveHowToPay(espada.Preco);
            ClientManager.singleton.MyInventory.Add(espada);

            accumulative = false;
        }

        if (option == 2) // Adaga
        {
            ChangeAccumulativeValue();

            HaveHowToPay(adaga.Preco);
            ClientManager.singleton.MyInventory.Add(adaga);

            accumulative = false;
        }

        if (option == 3) // Foice
        {
            ChangeAccumulativeValue();

            HaveHowToPay(foice.Preco);
            ClientManager.singleton.MyInventory.Add(foice);

            accumulative = false;
        }

        if (option == 4) // Arco
        {
            ChangeAccumulativeValue();

            HaveHowToPay(arco.Preco);
            ClientManager.singleton.MyInventory.Add(arco);

            accumulative = false;
        }

        // --------------------------------------------------------------- COMPRAR ARMOR

        if (option == 5) // Helmet
        {
            HaveHowToPay(helmet.Preco);
            ClientManager.singleton.MyInventory.Add(helmet);
        }

        if (option == 6) // Bodyshield
        {
            HaveHowToPay(bodyshield.Preco);
            ClientManager.singleton.MyInventory.Add(bodyshield);
        }

        if (option == 7) // Paints
        {
            HaveHowToPay(pants.Preco);
            ClientManager.singleton.MyInventory.Add(pants);
        }

        if (option == 8) // Boots
        {
            HaveHowToPay(boots.Preco);
            ClientManager.singleton.MyInventory.Add(boots);
        }

        // --------------------------------------------------------------- COMPRAR EQUIPMENT

        if (option == 9) // Poison
        {
            HaveHowToPay(poison.Preco);
            ClientManager.singleton.MyInventory.Add(poison);
        }

        if (option == 10) // Ring
        {
            HaveHowToPay(ring.Preco);
            ClientManager.singleton.MyInventory.Add(ring);
        }

        if (option == 11) // Necklace
        {
            HaveHowToPay(necklace.Preco);
            ClientManager.singleton.MyInventory.Add(necklace);
        }

        if (option == 12) //Magic Stone
        {
            HaveHowToPay(magicStone.Preco);
            ClientManager.singleton.MyInventory.Add(magicStone);
        }
    }

    private void HaveHowToPay(float price) // Função que verifica se ele tem dinheiro.
    {
        if (price < ClientManager.singleton.money) // Se ele tem...
        {
            ClientManager.singleton.money -= price; // Desconta o valor.

            uiManager.MoneyUpdate();
        }
        else // Senão...
        {
            uiManager.AvisosUpdate(1); // Mensagem de que não há dinheiro.
        }
    }

}
