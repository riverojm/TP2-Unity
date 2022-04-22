using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject Cartelmsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseniacorrecta = "a1b2c3";
        Cartelmsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrasenia()
    {
        contraseniausuario = ingresousuario.text;
        if (contraseniausuario == contraseniacorrecta)
        {
            Cartelmsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            Cartelmsj.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
