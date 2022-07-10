using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private Vector3 mRotateSpeed;

    void Start()
    {
       
    }
    void Update()
    {
        transform.Rotate(mRotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            GameObject controllerObj = GameObject.FindGameObjectWithTag("GameController");
            GameController controller = controllerObj.GetComponent<GameController>();
            controller.AddScore(1);
        }
    }
}
