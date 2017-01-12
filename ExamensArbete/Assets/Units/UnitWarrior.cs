using UnityEngine;
using System.Collections;

public class UnitWarrior : UnitClass {
    void Awake()
    {
        unitSpeed = 10;
        unitHp = 100;
        unitPos = this.transform.position;
        unitAbility1 = "Strike";

    }

   
}
