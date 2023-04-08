using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject[] rooms;
    [SerializeField] GameObject[] objects;
    float roomSize = 14.4f;
    [SerializeField]float farthestX = 0;
    [SerializeField] float farObj = 20;
    [SerializeField] float minDist = 4, maxDist = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (farObj - transform.position.x < roomSize)
        {
            int objIndex = Random.Range(0, objects.Length);

            farObj += Random.Range(minDist, maxDist);
            float newy = Random.Range(-2, 2);
            Vector3 newObjPos = new Vector3(farObj, newy, 0);

            GameObject obj = Instantiate(objects[objIndex], newObjPos, Quaternion.identity);
            obj.transform.Rotate(0, 0, Random.Range(0, 180));
        }
        if (farthestX - transform.position.x < roomSize)
        {
            int roomIndex = Random.Range(0, rooms.Length);

            farthestX = farthestX + roomSize;
            Vector3 newRoomPos = new Vector3(farthestX, 0, 0);
            GameObject newRoom = Instantiate(rooms[roomIndex], newRoomPos, Quaternion.identity);
            //Destroy(newRoom, 15);
        }


    }
    
}
