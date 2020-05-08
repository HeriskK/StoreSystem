using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Classes
{
    protected Classificacao tipoClassificacao;

    protected string name;
    public string Nome // Contrutor para o nome, trocando valor protected por public.
    {
        get
        {
            return name;
        }
        set
        {
            name = value;

            //Debug.Log("Nome da poção: " + nome);
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

            //Debug.Log("Nome da poção: " + nome);
        }
    }

    public virtual void Examinar()
    {
        Debug.Log("Isto é um(a): " + name);
        string dados;
        dados = string.Format("{0} é um(a) {1}", name, tipoClassificacao); //______ é um(a) _______
        Debug.Log(dados);
    }

    public abstract void ChangeValue(float value);

}

public class Weapons : Classes
{
    public bool accumulative = true; //...

    public Weapons(float preco)
    {
        tipoClassificacao = Classificacao.Weapons; // Weapons tem um tipo de classificação, é uma ARMA.

        this.preco = Preco;
    }

    public override void ChangeValue(float value)
    {
        value = preco;
    }
}

public class Armor : Classes
{
    public Armor(float preco)
    {
        tipoClassificacao = Classificacao.Armor; // Weapons tem um tipo de classificação, é uma ARMADURA.

        this.preco = preco;
    }
    public override void ChangeValue(float value)
    {
        value = preco;
    }
}

public class Equipment : Classes
{
    public Equipment(float preco)
    {
        tipoClassificacao = Classificacao.Equipment; // Weapons tem um tipo de classificação, é um EQUIPAMENTO.

        this.preco = preco;
    }
    public override void ChangeValue(float value)
    {
        value = preco;
    }
}

// Ctrl RR