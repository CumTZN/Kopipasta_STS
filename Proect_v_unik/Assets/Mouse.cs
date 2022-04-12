using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour{

    public Material Red;
    public Material Blue;
    Material m_Material;

    void Start(){
        m_Material = GetComponent<Renderer> ().material;
    }

    private void OnMouseOver(){
        m_Material.color = Red.color;
    }

    private void OnMouseExit(){ 
        m_Material.color = Blue.color;
    }

}