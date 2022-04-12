using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public int Dmg;
    void OnMoseDown()
    {
        Health TargetHealth =target.GetComponent<Health>();
        TargetHealth.TakeDmg(Dmg);
        Debug.Log("gay");
    }


}
