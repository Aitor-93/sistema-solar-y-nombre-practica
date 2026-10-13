using UnityEngine;

public class Nombre : MonoBehaviour
{
    //a
    Vector3 punto1 = new Vector3(3, 5, 0);
    Vector3 punto2 = new Vector3(2.5f, 6, 0);

    Vector3 punto3 = new Vector3(2, 5, 0);
    Vector3 punto4 = new Vector3(2.5f, 6, 0);

    Vector3 punto5 = new Vector3(2.25f, 5.5f, 0);
    Vector3 punto6 = new Vector3(2.75f, 5.5f, 0);
    //i
    Vector3 punto7 = new Vector3(1.5f, 5, 0);
    Vector3 punto8 = new Vector3(1.5f, 6, 0);
    //t
    Vector3 punto9 = new Vector3(0, 6, 0);
    Vector3 punto10 = new Vector3(1, 6, 0);
    
    Vector3 punto11 = new Vector3(0.5f, 5, 0);
    Vector3 punto12 = new Vector3(0.5f, 6, 0);
    //o
    Vector3 punto13 = new Vector3(-0.4f, 5, 0);
    Vector3 punto14 = new Vector3(-0.4f, 6, 0);
    
    Vector3 punto15 = new Vector3(-1, 5, 0);
    Vector3 punto16 = new Vector3(-1, 6, 0);

    Vector3 punto17 = new Vector3(-0.4f, 6, 0);
    Vector3 punto18 = new Vector3(-1, 6, 0);

    Vector3 punto19 = new Vector3(-0.4f, 5, 0);
    Vector3 punto20 = new Vector3(-1, 5, 0);
    //r
    Vector3 punto21 = new Vector3(-1.5f, 5, 0);
    Vector3 punto22 = new Vector3(-1.5f, 6, 0);

    Vector3 punto23 = new Vector3(-1.5f, 6, 0);
    Vector3 punto24 = new Vector3(-2, 6, 0);

    Vector3 punto25 = new Vector3(-2, 5.5f, 0);
    Vector3 punto26 = new Vector3(-2, 6, 0);

    Vector3 punto27 = new Vector3(-2, 5.5f, 0);
    Vector3 punto28 = new Vector3(-1.5f, 5.5f, 0);

    Vector3 punto29 = new Vector3(-2, 5, 0);
    Vector3 punto30 = new Vector3(-1.5f, 5.5f, 0);



    //Antes de saber que es era una practica entregable, hice esta junto con la del sistema solar en un solo proyecto asi que lo entrego asi :)





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //a
        Debug.DrawLine(punto1, punto2, Color.red);
        Debug.DrawLine(punto3, punto4, Color.red);
        Debug.DrawLine(punto5, punto6, Color.red);
        //i
        Debug.DrawLine(punto7, punto8, Color.red);
        //t
        Debug.DrawLine(punto9, punto10, Color.red);
        Debug.DrawLine(punto11, punto12, Color.red);
        //o
        Debug.DrawLine(punto13, punto14, Color.red);
        Debug.DrawLine(punto15, punto16, Color.red);
        Debug.DrawLine(punto17, punto18, Color.red);
        Debug.DrawLine(punto19, punto20, Color.red);
        //r
        Debug.DrawLine(punto21, punto22, Color.red);
        Debug.DrawLine(punto23, punto24, Color.red);
        Debug.DrawLine(punto25, punto26, Color.red);
        Debug.DrawLine(punto27, punto28, Color.red);
        Debug.DrawLine(punto29, punto30, Color.red);
        


    }
}
