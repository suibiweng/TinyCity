using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassLand : MonoBehaviour
{
    public GameObject Tree;
    public int MaxNum;
    public float TreeMaxSize;
    // Start is called before the first frame update
    void Start()
    {

        MaxNum = (int)Random.Range(1, MaxNum);
        for (int i = 0; i < MaxNum; i++) {

           GameObject t= Instantiate(Tree,transform);
            t.transform.localPosition = new Vector3(Random.Range(-0.4f,0.4f),2.45f, Random.Range(-0.4f, 0.4f));
            t.transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);

           float r= Random.Range(1, TreeMaxSize);
            t.transform.localScale = new Vector3(r,r,r);
        }
        Destroy(Tree);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
