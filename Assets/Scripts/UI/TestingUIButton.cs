using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
public class TestingUIButton : MonoBehaviour
{
    [SerializeField] Button host;
    [SerializeField] Button client;
    private void Awake()
    {
        host.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
            Debug.Log("Started as host");
            Hide();
        });
        client.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
            Debug.Log("Started as client");
            Hide();
        });
    }
    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
