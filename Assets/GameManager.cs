using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   

    public int score=0;
    [SerializeField]
    private GameObject player;


    public TMP_Text score_text;
    public TMP_Text highscore_text;
    
    void Start()
    {
       player_movement player_MV=Instantiate(player).GetComponent<player_movement>();
        player_MV.gm = this;
        score_text.text = "score= " + score;
        highscore_text.text = "highscore= " + PlayerPrefs.GetInt("highscore");
    }

    
}
