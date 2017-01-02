using UnityEngine;
using System.Collections;

public class Boardmanager : MonoBehaviour {
    
    [SerializeField] private GameObject BoardTile;
    [SerializeField] [Range(0, 2)] private int typeplayer;
    [SerializeField] [Range(0, 2)] private int typeenemy;
    
    [SerializeField] int gridX;
    [SerializeField] int gridY;
    [SerializeField] [Range(0, 6)] float offset = 5;

    //private Vector3[,] PlayerSide = new Vector3[3, 7];
    //private Vector3[,] EnemySide = new Vector3[3, 7];
    public GameObject[,] PlayerBoardSide = new GameObject[7, 7];
    public GameObject[,] EnemyBoardSide = new GameObject[7, 7];

    // Use this for initialization
    void Start () {
       

        for ( int i = 0; i < gridX; i++)
        {
            for (int o = 0; o < gridY; o++)
            {
               
                PlayerBoardSide [i,o] = Instantiate(BoardTile, new Vector3 (i,o,0), Quaternion.identity) as GameObject;
                if (gridX < gridY)
                {
                        EnemyBoardSide[i, o] = Instantiate(BoardTile, new Vector3(i + offset + gridX, o, 0), Quaternion.identity) as GameObject;
                }
                else
                {
                        EnemyBoardSide[i, o] = Instantiate(BoardTile, new Vector3(i , o + offset + gridY, 0), Quaternion.identity) as GameObject;
                }


            }

        }
        for (int i = 0; i < gridX; i++)
        {
            for (int o = 0; o < gridY; o++)
            {
                PlayerBoardSide[i, o].GetComponent<Tile>().Checkup(typeplayer);
                EnemyBoardSide[i, o].GetComponent<Tile>().Checkup(typeenemy);
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    
}
