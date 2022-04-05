using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    ObjectPool objectPool;

    void Start()
    {
        objectPool = ObjectPool.Instance;
    }

    void Update()
    {     
        SpawnBall();
    }

    private void SpawnBall()
    {
        int ballColor = Random.Range(0, 7);

        switch (ballColor)
        {
            case 0:
                objectPool.SpawnFromPool("Blue", transform.position + new Vector3(0,1,0), Quaternion.identity);
                break;
            case 1:
                objectPool.SpawnFromPool("Green", transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                break;
            case 2:
                objectPool.SpawnFromPool("Mint", transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                break;
            case 3:
                objectPool.SpawnFromPool("Red", transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                break;
            case 4:
                objectPool.SpawnFromPool("Yellow", transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                break;
            case 5:
                objectPool.SpawnFromPool("Orange", transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                break;
            case 6:
                objectPool.SpawnFromPool("Purple", transform.position + new Vector3(0, 1, 0), Quaternion.identity);
                break;
            default:
                break;
        }
    }
}
