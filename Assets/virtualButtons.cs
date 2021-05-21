using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButtons : MonoBehaviour
{
    VirtualButtonBehaviour[] vbbs;
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        vbbs = this.GetComponentsInChildren<VirtualButtonBehaviour>();

        Debug.Log("Botôes:" + vbbs.Length);

        for (int i = 0; i < vbbs.Length; i++)
        {
            vbbs[i].RegisterOnButtonPressed(AoPressionarBotao);
            vbbs[i].RegisterOnButtonReleased(AoSoltarBotao);
        }
    }

    public void AoPressionarBotao(VirtualButtonBehaviour vbb)
    {
        Debug.Log("botao pressionado");

        if (vbb.name == "VirtualButton1")
        {
            cubo.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (vbb.name == "VirtualButton2")
        {
            cubo.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void AoSoltarBotao(VirtualButtonBehaviour vbb)
    {
        Debug.Log("botao solto");
    }

}
