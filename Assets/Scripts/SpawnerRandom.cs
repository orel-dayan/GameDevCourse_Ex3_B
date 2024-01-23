using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerRandom : MonoBehaviour
{

    [SerializeField] GameObject gameObj;
    [SerializeField] Material[] mat;
    [SerializeField] Transform[] transforms;
    [SerializeField] float Timer;
    [SerializeField] float rand;

    void Start()
    {
        Timer = 0f;
    }
    void Update()
    {
        Timer += Time.deltaTime; 
        if(Timer > rand)
        {
            int range = Random.Range(0, 3);
            Debug.Log(range); // debug
            GameObject getGameObj = Instantiate(gameObj, transforms[range].transform.position, Quaternion.identity);
            getGameObj.GetComponent<Renderer>().material = mat[range];
            Timer = 0f;
        }
    }


}
