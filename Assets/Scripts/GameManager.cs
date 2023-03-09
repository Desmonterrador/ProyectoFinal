using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action onMainMenu;
    public event Action onItemsMenu;
    public event Action onARPosition;

    public static GameManager instance;
    private void Awake()
    {
        if(instance!=null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        onMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");
    }
    public void ItemsMenu()
    {
        onItemsMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }
    public void ARPosition()
    {
        onARPosition?.Invoke();
        Debug.Log("AR Position Activated");
    }
    public void CloseAPP()
    {
        Application.Quit();
    }
}
