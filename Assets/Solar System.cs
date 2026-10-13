using System;
using UnityEngine;
using UnityEngine.Animations;

public class SolarSystem : MonoBehaviour
{
    //declarar posicion del centro del universo
    public Vector3 CentroUniverso = new Vector3(0, 0, 0);

    //hacer transform del sol para el Satelite1
    
    public Transform Satelite1;
    public Transform Satelite2;
    public Transform camara;

    private float velocidadSol = 30f;
    private float velocidadSatelite1 = 90f;
    private float velocidadSatelite2 = 45f;

    public float velocidadEscala = 0.2f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        transform.position = new Vector3(10f, 0, 0);
        Satelite1.localPosition = new Vector3(5f, 0, 0);
        Satelite2.localPosition = new Vector3(0, 0, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
        //Sol
        transform.LookAt(CentroUniverso);
        transform.RotateAround(CentroUniverso, Vector3.up, velocidadSol * Time.deltaTime);
        

        //Satelite1
        Satelite1.RotateAround(transform.position, transform.up, velocidadSatelite1 * Time.deltaTime);

        //Satelite2
        Satelite2.LookAt(Satelite1.position);
        Satelite2.RotateAround(Satelite1.position, Satelite1.right, velocidadSatelite2 * Time.deltaTime);

        Debug.DrawLine(transform.position,CentroUniverso, Color.magenta);
        Debug.DrawLine(transform.position,Satelite1.position, Color.blue);
        Debug.DrawLine(transform.position,Satelite2.position, Color.red);
        Debug.DrawLine(Satelite1.position,Satelite2.position, Color.green);


        camara.LookAt(transform.position);

        float angulo = Vector3.Angle(Satelite2.right, Vector3.right);
        Vector3 escalaActual = Satelite2.localScale;

        if(angulo < 90)
        {
            escalaActual -= Vector3.one* velocidadEscala* Time.deltaTime;
        }
        else
        {
            escalaActual += Vector3.one * velocidadEscala * Time.deltaTime;

        }
       Satelite2.localScale = Vector3.Max(escalaActual, new Vector3(0.05f, 0.05f, 0.05f));




    }
}
