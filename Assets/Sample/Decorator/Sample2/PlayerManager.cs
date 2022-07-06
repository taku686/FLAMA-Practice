using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IPlayerAction playerAction = new PlayerAction();
        playerAction.Attack();

        playerAction = new Poison(playerAction);
        playerAction.Attack();

        IPlayerAction playerAction2 = new PlayerAction();
        playerAction = new Water(playerAction2);
        playerAction.Attack();
        
        
    }
}
