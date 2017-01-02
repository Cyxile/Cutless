using UnityEngine;
using System.Collections;

public class UnitClass : MonoBehaviour {

    protected string unitName;
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
    public void Move(Vector3 targetPos)
    {
        if (targetPos != unitPos)
        {
            this.transform.position = targetPos;
            unitPos = targetPos;
            
        }

    }

}
