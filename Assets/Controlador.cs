using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Controlador : MonoBehaviour
{

    public static int moedas;

    public Text moedasTxt;
    public Text mortesTxt;
    public static Controlador controlador;
    public static int mortes = 0;
    public GameObject win;
    public Text moedasWin;
    public Text mortesWin;
    public bool canRotate = true;

    private void Awake() {
        controlador = this;
    }

    private void Start() {
        moedas = 0;
        moedasTxt.text = moedas.ToString();
        mortesTxt.text = mortes.ToString();
    }

    public void AddCoin(int value)
    {
        moedas += value;
        moedasTxt.text = moedas.ToString();
    }

    public void AddMortes(int value)
    {
        mortes += value;
        mortesTxt.text = mortes.ToString();
    }

    public void Exit()
    {
        win.SetActive(true);
        moedasWin.text = moedas.ToString();
        mortesWin.text = mortes.ToString();
        canRotate = false;
    }

    public void Reiniciar()
    {
        mortes = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
