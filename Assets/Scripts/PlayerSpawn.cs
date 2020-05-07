using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] GameObject prefabPlayer;
    [SerializeField] GameObject CreatePlaybookMenuUi;
    private int playerCount = 0;

    private void Start()
    {
        if (CreatePlaybookMenuUi.GetComponent<CreatePlaybookMenu>().off_def )//if Offense
        {
            this.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            for ( int i = 0; i < 5; i++)
            {
                SpawnNewPlayer(); // temporary need to adjust positions for offensive line
            }         
        }
        SpawnNewPlayer(new Vector2(5, 5));
    }

    public void SpawnNewPlayer(Vector2 Position)
    {
        if (playerCount < 11)
        {
            GameObject newPlayer = Instantiate(prefabPlayer) as GameObject;
            newPlayer.transform.SetParent(GameObject.FindGameObjectWithTag("SpawnPlayerManager").transform, false);
            newPlayer.GetComponent<RectTransform>().anchoredPosition = Position;
            playerCount++;
        }
    }

    public void SpawnNewPlayer() // Spawn at Spawn Manager location
    {
        if (playerCount < 11)
        {
            GameObject newPlayer = Instantiate(prefabPlayer) as GameObject;
            newPlayer.transform.SetParent(GameObject.FindGameObjectWithTag("SpawnPlayerManager").transform, false);

            Vector2 anchorPlacement = new Vector2(0.5f, 0.5f);
            RectTransform spawnedPlayerRT = newPlayer.GetComponent<RectTransform>();

            spawnedPlayerRT.anchorMin = anchorPlacement;
            spawnedPlayerRT.anchorMax = anchorPlacement;
            //spawnedPlayerRT.anchoredPosition += new Vector2(Random.Range(-5,5), 0); alter Position here


            playerCount++;
        }
    }

    
}
