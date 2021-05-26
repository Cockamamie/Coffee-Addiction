using UnityEngine;

public class CoffeeFinder : MonoBehaviour
{
    private GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("CoffeeCup");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.F)) // && eneryIsFull
            FindNearestCup();*/
    }

    private void DrawPath()
    {
        
    }

    private void FindShortestPath()
    {
        
    }

    /*private static bool IsValidPoint()
    {
        
    }*/
}
