using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{ 
    //�������� NPS
      public int heath = 5;

    //������� NPS
    public int level = 1;

    //�������� NPS
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        heath += level;
        print(heath);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
