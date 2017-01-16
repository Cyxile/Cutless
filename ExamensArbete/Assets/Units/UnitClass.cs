using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UnitClass : MonoBehaviour {

    protected string unitName;
    protected string unitAbility1 = "Ability One";
    protected string unitAbility2 = "Ability two";
    protected string unitAbility3 = "Ability three";
    [SerializeField]protected GameObject managerUnit;
    protected int unitHp;
    protected int unitDef;
    protected int unitAtk;
    protected float unitSpeed=1;
    protected bool unitType;
    protected Vector3 unitPos;
    GameObject[,] Playerside;


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
        Playerside = managerUnit.GetComponent<Boardmanager>().getArray;
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

    public void AbilityMethod1()
    {

        Debug.Log("Ability one Activated");
        StartCoroutine(AbilityCourutine1());
        

    }

    IEnumerator AbilityCourutine1()
    {
        List<Vector3> position = new List<Vector3>();
        position.Add(unitPos);
        

        for (int i = 0; i < 3; i++)
        {
            for (int o = 0; o < 7; o++)
            {
                Playerside[i, o].GetComponent<Tile>().Checkup(1);
                
            }

        }

        Debug.Log(position);



        yield return 0; 
    }



}
