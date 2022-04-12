using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_Ray : MonoBehaviour

{
    public Material Red;
    public Material Blue;
    // public Camera Cam;
    Material m_Material;
    Collider Coll;
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        Coll = GetComponent<Collider>();
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Coll.Raycast(ray, out hit,Mathf.Infinity)) 
        {
        
           m_Material.color = Red.color;
            
        }
        else m_Material.color = Blue.color;
    }
}
