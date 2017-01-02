using UnityEngine;
using System.Collections;

public class UnitClass : MonoBehaviour {

    
    protected int unitHp;
    protected int unitDef;
    protected int unitAtk;
    protected float unitSpeed;
    protected bool unitType;
    protected Vector3 unitPos;






	// Use this for initialization
	protected virtual void Start ()
        {
            ShowHp();    
	    }
	
	protected virtual void ShowHp ()
        {

        Debug.Log("unit's Hp is " + unitHp);

        }
}
