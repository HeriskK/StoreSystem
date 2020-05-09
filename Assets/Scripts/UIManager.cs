using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text dinheiroText;
    public Text avisosText;

    public GameObject panelChangeItem;

    private void Start()
    {
        MoneyUpdate();
    }

    public void AlertUpdate(int parametro)
    {
        if (parametro == 0) // Se for 0... (Texto setado em "", para começar com a caixa de texto em branco).
        {
            avisosText.text = "";
        }

        if (parametro == 1) // Se for 1... (Não tem dinheiro).
        {
            avisosText.text = "Você não tem dinheiro!";
        }
    }

    public void PurchaseAlert()
    {

    }

    public void MoneyUpdate()
    {
        dinheiroText.text = ClientManager.singleton.money.ToString() + " Ⴔ";
    }
}
