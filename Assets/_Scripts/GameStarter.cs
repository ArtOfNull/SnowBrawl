using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private void Awake()
    {
        GameStateManager.Manager.InitGame();
    }
}
