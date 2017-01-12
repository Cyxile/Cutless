using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    enum Gamestates
    {
        START,
        ACTIONONE,
        ACTIONTWO,
        LOSE,
        WIN,
    }
    
    private Gamestates currentState;
    public GameObject selectedUnit;
    private Vector3 targetPos = new Vector3 (1,1,0);
    [SerializeField] private GameObject[] unitsInplay = new GameObject[4];
    int frame;
    List<GameObject> allUnits = new List<GameObject>();


   
    void Start()
    {

       
        for (int i = 0; i <= unitsInplay.Length-1; i++)
        {
            Debug.Log("units in play " + unitsInplay.Length + " i is = " + i);
            allUnits.Add(unitsInplay[i]);

        }

        currentState = Gamestates.START;
        selectedUnit = unitsInplay[2];
        Gameplay();

    }
  
  
    void Gameplay()
    {
       
         

            Debug.Log("Current State is "+ currentState);
            switch (currentState)
            {
                case (Gamestates.START):
                    allUnits.Sort((IComparer<GameObject>)new sort());

                    Debug.Log("first unit speed in list: " + allUnits[0].GetComponent<UnitClass>().Speed);


                    selectedUnit = allUnits[0];
                    Debug.Log("selected units Speed is: " + selectedUnit.GetComponent<UnitClass>().Speed);
                    while (selectedUnit.GetComponent<UnitClass>().Speed >= 1)
                    {
                        foreach (GameObject unit in allUnits)
                        {
                            unit.GetComponent<UnitClass>().Speed -= 1;
                            //Debug.Log(selectedUnit.GetComponent<UnitClass>().Speed);
                        }


                    }

                    Debug.Log("end of while loop");
                    selectedUnit.GetComponent<UnitClass>().Speed += 500;
                    Debug.Log("selected units Speed is: " + selectedUnit.GetComponent<UnitClass>().Speed);
                    //currentState = Gamestates.ACTIONONE;

                    break;






                case (Gamestates.ACTIONONE):
                    
                    break;
                case (Gamestates.ACTIONTWO):
                    break;
                case (Gamestates.WIN):
                    break;
                case (Gamestates.LOSE):
                    break;

            }            
       }

   void OnGUI()
    {

        if (selectedUnit)
        {
            if (GUILayout.Button(selectedUnit.GetComponent<UnitClass>().Ability1))
                Gameplay();
            if (GUILayout.Button(selectedUnit.GetComponent<UnitClass>().Ability2))
                Gameplay();
            if (GUILayout.Button(selectedUnit.GetComponent<UnitClass>().Ability3))
                Gameplay();

        }
        else
        if (GUILayout.Button("whallo"))
            Gameplay();


    }



}




class sort : IComparer<GameObject>
{
    int IComparer<GameObject>.Compare(GameObject _objA, GameObject _objB)
    {
        int t1 = _objA.GetComponent<UnitClass>().Speed;
        int t2 = _objB.GetComponent<UnitClass>().Speed;
        return t1.CompareTo(t2);


    }
}



