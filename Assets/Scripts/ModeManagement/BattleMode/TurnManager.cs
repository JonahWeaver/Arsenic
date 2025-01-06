using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{

    private Queue<GameObject> turnQueue;
    private List<GameObject> allUnits;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginBattle(List<GameObject> units)
    {
        allUnits = units;
        InitializeQueue();
        BeginTurn();
    }

    private void InitializeQueue()
    {
        turnQueue = new Queue<GameObject>();
        foreach (GameObject unit in allUnits)
        {
            turnQueue.Enqueue(unit);
        }
    }

    private void RemoveUnits(List<GameObject> units)
    {
        Queue<GameObject> updatedQueue = new Queue<GameObject>();
        List<GameObject> updatedUnits = new List<GameObject>();

        while (turnQueue.Count > 0)
        {
            GameObject current = turnQueue.Dequeue();

            // Check if the current GameObject is not in the removal list
            if (!units.Contains(current))
            {
                updatedQueue.Enqueue(current);
                updatedUnits.Add(current);
            }
        }

        // Replace the old queue with the updated one
        turnQueue = updatedQueue;
        allUnits = 
    }

}
