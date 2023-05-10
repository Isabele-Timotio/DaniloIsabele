using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mira : MonoBehaviour
{
    public bool travarMouse = true; //Controla se o cursor do mouse � exibido
    public float sensibilidade = 2.0f; //Controla a sensibilidade do mouse

    public float mouseX = 0.0f, mouseY = 0.0f; //Vari�veis que controla a rota��o do mouse

    // Start is called before the first frame update
    void Start()
    {
        {
            if (!travarMouse)
            {
                return;
            }
            Cursor.visible = false; //Oculta o cursor do mouse
            Cursor.lockState = CursorLockMode.Locked; //Trava o cursor do centro
        }

    }


    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * sensibilidade; // Incrementa o valor do eixo X e multiplica pela sensibilidade
        mouseY += Input.GetAxis("Mouse Y") * sensibilidade; // Incrementa o valor do eixo Y e multiplica pela sensibilidade. (Obs. usamos o - para inverter os valores)

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0); //Executa a rota��o da c�mera de acordo com os eixos
    }
}
