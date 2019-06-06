using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObstacleBuilder : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {

        float x0 = 0;
        float y0 = -20;//transform.position.y;
        float R = 20f; //transform.localScale.y/2;
        
        //for (float x = -R; x < R; x+=2*R/50)
        for (int i=0;i<50;i++)
        {
            


            //y = y0 + Mathf.Sqrt(R * R - x * x);
            //obstacle.transform.position = new Vector3(x, y, 10);
            int count = Random.Range(1, 4);
            for(int j = 1; j <= count; j++)
            {
                GameObject obstacle = Instantiate(obstaclePrefab) as GameObject;
                float u = Random.Range(-45f, 45f);
                obstacle.transform.Rotate(0, 0, u);
                obstacle.transform.position = new Vector3(0, 0, 10f + 6f * i);
                /*float z = 6f * i;
                float u = Random.Range(-45f, 45f);
                float x = R * Mathf.Sin(u) + x0;
                float y = R - R * Mathf.Cos(u) + y0;
                Debug.Log("x=" + x + ",y=" + y + "z=" + z);
                obstacle.transform.position = new Vector3(x, y, 10f + z);*/
                obstacle.transform.SetParent(transform);
            }
            
            //obstacle.transform.rotation = new Quaternion(0, Random.Range(0,0.2f), 0, 1);
            //obstacle.transform.localEulerAngles = new Vector3(0, Random.Range(-0.2f, 0.2f), 0);

            
         //   
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
