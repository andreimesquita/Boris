using UnityEngine;
using Character;

public class MobileInputHandler : MonoBehaviour {
    [SerializeField]
    private CharacterBehaviour character;
    private int fingersPressing = 0;

    public void MoveRight()
    {
        fingersPressing++;
        character.MoveX(1);
    }

    public void MoveLeft()
    {
        fingersPressing++;
        character.MoveX(-1);
    }

    public void StopMovingRight()
    {
        StopCharcterMovement();
    }

    public void StopMovingLeft()
    {
        StopCharcterMovement();
    }

    private void StopCharcterMovement()
    {
        fingersPressing--;

        if (fingersPressing == 0)
            character.Stop();
    }
    
}
