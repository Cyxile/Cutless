using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public GameObject selectedUnit;


    void Start()
    {

        selectedUnit.GetComponent<UnitClass>().Move(new Vector3(1, 1, 0));

    }



}
