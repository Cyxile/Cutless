using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    
    [SerializeField] private Material[] materials;
    private Renderer rend;
    private int intType = 0;

    //public int IntType
    //{
    //    set { IntType = value; }

    //}

    void Start()
    {
        
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        
    }

    public void Checkup(int number)
    {
        intType = number;
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        //Debug.Log(number+" Material "+ materials[number]+" intType "+intType);
        
        rend.sharedMaterial = materials[intType];
        
        //GetComponent<Renderer>().sharedMaterial = materials[number];

    }


    void OnMouseUp()
    {

        if (intType >= 2)
            intType = 0;
        else
            intType += 1;

        
        rend.sharedMaterial = materials[intType];




    }

}
