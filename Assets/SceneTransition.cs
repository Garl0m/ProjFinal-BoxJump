using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    [SerializeField]
    private SceneController _sceneController;

    void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }

    public void LoadScene()
    {
        _sceneController.LoadScene("InvertScene");
    }


}
