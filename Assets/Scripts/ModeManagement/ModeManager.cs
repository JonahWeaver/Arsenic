using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public XModeManager currentMode;
    public GameObject player;
    // Start is called before the first frame update
    public static ModeManager Instance { get; private set; }

    public struct GlobalInfo
    {
        private int eventID;
        private int battleID;
        private int objectiveID;

        public int EventID { get => eventID; set => eventID = value; }
        public int BattleID { get => battleID; set => battleID = value; }
        public int ObjectiveID { get => objectiveID; set => objectiveID = value; }
    }
    GlobalInfo globalInfo;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        Debug.Log(Instance);
        SetPlayerObject();

        //if(GetComponent<OverworldModeManager>)
        //this = modeObject.AddComponent<OverworldModeManager>();

        currentMode = GetComponent<OverworldModeManager>();
        currentMode.enabled = true;
        currentMode.Activate();
    }
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGlobalInfoUpdate()
    {

    }

    private void SetPlayerObject()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    public GameObject GetPlayerObject()
    {
        return player;
    }
}
