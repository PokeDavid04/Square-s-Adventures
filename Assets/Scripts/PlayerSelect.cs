using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{

    public enum Player {Blanco, Azul, Verde, Rojo, Rosa, Amarillo};
    public Player playerSelected;

    public bool enableSelectColor;

    public Color blanco;
    public Color azul;
    public Color verde;
    public Color rojo;
    public Color rosa;
    public Color amarillo;

    public Renderer render;


    void Start()
    {

        if (!enableSelectColor)
        {
            ChangeColor();
        }
        else
        {
            switch (playerSelected)
            {
                case Player.Blanco:
                    render.material.color = blanco;
                    break;
                case Player.Azul:
                    render.material.color = azul;
                    break;
                case Player.Verde:
                    render.material.color = verde;
                    break;
                case Player.Rojo:
                    render.material.color = rojo;
                    break;
                case Player.Rosa:
                    render.material.color = rosa;
                    break;
                case Player.Amarillo:
                    render.material.color = amarillo;
                    break;
                default:
                    render.material.color = blanco;
                    break;
            }

        }
        
        


    }

    public void ChangeColor()
    {
        switch (PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Blanco":
                render = GetComponent<Renderer>();
                render.material.color = blanco;
                break;
            case "Azul":
                render = GetComponent<Renderer>();
                render.material.color = azul;
                break;
            case "Verde":
                render = GetComponent<Renderer>();
                render.material.color = verde;
                break;
            case "Rojo":
                render = GetComponent<Renderer>();
                render.material.color = rojo;
                break;
            case "Rosa":
                render = GetComponent<Renderer>();
                render.material.color = rosa;
                break;
            case "Amarillo":
                render = GetComponent<Renderer>();
                render.material.color = amarillo;
                break;
            default:
                render = GetComponent<Renderer>();
                render.material.color = blanco;
                break;
        }

    }


}