using UnityEngine;
using System.Collections;

public class UnitClass : MonoBehaviour {

    protected string unitName;
    protected string unitAbility1 = "Ability One";
    protected string unitAbility2 = "Ability two";
    protected string unitAbility3 = "Ability three";
    protected int unitHp;
    protected int unitDef;
    protected int unitAtk;
    protected float unitSpeed=1;
    protected bool unitType;
    protected Vector3 unitPos;

    public string Ability1
    {
        get { return unitAbility1; }

    }

    public string Ability2
    {
        get { return unitAbility2; }

    }
    public string Ability3
    {
        get { return unitAbility3; }

    }





    public int Speed
    {
        get { return Mathf.FloorToInt(unitSpeed); }
        set { unitSpeed = value; }
    }



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
