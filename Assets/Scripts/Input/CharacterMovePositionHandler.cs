using UnityEngine;

public class CharacterMovePositionHandler : MonoBehaviour {

    [SerializeField]
    private MobileInputHandler mobileInputHandler;
    [SerializeField]
    private Position position;

    public enum Position { LEFT, RIGHT }

    private void OnMouseDown()
    {
        if (position == Position.LEFT)
        {
            mobileInputHandler.MoveLeft();
        } else
        {
            mobileInputHandler.MoveRight();
        }
    }

    private void OnMouseUp()
    {
        if (position == Position.LEFT)
        {
            mobileInputHandler.StopMovingLeft();
        }
        else
        {
            mobileInputHandler.StopMovingRight();
        }
    }

}
