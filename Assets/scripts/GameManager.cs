using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject hazardPrefab;

    public int maxHazardsToSpawn = 8;
    private int score;
    private float timer;
    private static bool acabou;
   // public TMpro.TextMeshPro scoreText;
    public Text scoreText;

    void Start()
    {
       StartCoroutine(SpawnHazards());
    }

    private void Update()
    {
        if(acabou){
            return;
        }
        timer += Time.deltaTime;
        if(timer >= 1f)
        {
        score ++;
        scoreText.text = score.ToString();
        timer=0;
        }
    }

    private IEnumerator SpawnHazards()
    {
     var hazardToSpawn = Random.Range(1,maxHazardsToSpawn); 
     for(int i=0; i < hazardToSpawn; i++)
    {
       var x = Random.Range(-8, 8);
       var drag = Random.Range(0f, 1f);

       var Hazard = Instantiate(hazardPrefab, new Vector3(x, 11, 0), Quaternion.identity);
       Hazard.GetComponent<Rigidbody>().drag = drag;
    }
         var timeToWait = Random.Range(0.5f, 1.5F);
    
       yield return new WaitForSeconds(timeToWait);
       yield return SpawnHazards();
    }
   
   public static void Acabou()
   {
     acabou = true;
   }
}
