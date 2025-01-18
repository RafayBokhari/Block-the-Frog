using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject boxPrefab;
    [SerializeField] float spawnRate;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject tapToStart;
    [SerializeField] GameObject scoreText0;
    [SerializeField] GameObject blockFrog;
    private int score;
    private bool gameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        tapToStart.SetActive(true);
        scoreText0.SetActive(false);
        blockFrog.SetActive(true );
        
    }

    private void Update()
    {
        if(Input.GetMouseButton(0) &&  !gameStarted)

        {
            BoxSpawning();
            gameStarted = true;
            tapToStart.SetActive(false);
            scoreText0.SetActive(true);
            blockFrog.SetActive(false );
        }

    }

    void BoxSpawning()
    {
        InvokeRepeating("SpawnBox", 0.5f, spawnRate);
       
    }

    void SpawnBox()
    {
        float newPos = Random.Range(-2f, 2f);
        Instantiate(boxPrefab,new Vector2(newPos,transform.position.y), Quaternion.identity);
        score++;
        scoreText.text = score.ToString();
    }




}
