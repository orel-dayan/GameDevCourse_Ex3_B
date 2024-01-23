using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSystem : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] TMP_Text scoreText;
    public static int score;

    void Start()
    {
        score = 0;
    }
   
    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<ColliderVars>() != null)
        {
            if (Input.GetKeyDown(key))
            {
                other.GetComponent<ColliderVars>().IsPassed = true;
                AddScore();
                Debug.Log("Work in trigger"); // debug
                Destroy(other.gameObject);
            }
        }
        Debug.Log("stay in trigger");
    }
   
    private void AddScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }


}