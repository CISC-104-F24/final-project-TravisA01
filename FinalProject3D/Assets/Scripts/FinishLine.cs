using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] GameObject player; 
    [SerializeField] List<GameObject> finishPoint;
    [SerializeField] Vector3 vectorPoint;


    private void OnTriggerEnter(Collider finish)
    {
        vectorPoint = player.transform.position;
        SceneManager.LoadSceneAsync(0);
    }
}
