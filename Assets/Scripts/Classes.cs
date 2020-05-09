using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Classes
{
    protected ClassObject tipoClassificacao;

    public UIManager uiManager;
    public Classes classScript;

    protected string name;
    public string Name // Contrutor para o nome, trocando valor protected por public.
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    protected float preco;
    public float Preco // Contrutor para o preço, trocando valor protected por public.
    {
        get
        {
            return preco;
        }
        set
        {
            preco = value;
        }
    }

    public virtual void Examinar()
    {
        Debug.Log("Seu inventário: ");

        string dados;
        dados = string.Format("{0} - Objeto da classe {1} que custou {2}", classScript.Name, tipoClassificacao, classScript.Preco);
        Debug.Log(dados);
    }

    public abstract void ChangeValue(float value);
}

public class Weapons : Classes
{
    public bool accumulative = true; //...

    public Weapons(string name, float preco)
    {
        tipoClassificacao = ClassObject.Weapons; // Weapons tem um tipo de classificação, é uma ARMA.

        this.name = name;
        this.preco = preco;
    }
    public override void ChangeValue(float value)
    {
        value = preco;
    }
}

public class Armor : Classes
{
    public Armor(string name, float preco)
    {
        tipoClassificacao = ClassObject.Armor; // Weapons tem um tipo de classificação, é uma ARMADURA.

        this.name = name;
        this.preco = preco;
    }
    public override void ChangeValue(float value)
    {
        value = preco;
    }
}

public class Equipment : Classes
{
    public Equipment(string name, float preco)
    {
        tipoClassificacao = ClassObject.Equipment; // Weapons tem um tipo de classificação, é um EQUIPAMENTO.

        this.name = name;
        this.preco = preco;
    }
    public override void ChangeValue(float value)
    {
        value = preco;
    }
}

// Ctrl RR