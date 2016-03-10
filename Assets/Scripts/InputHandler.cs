using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    [SerializeField]
    GameActor actor;

    Command buttonX_;
    Command buttonY_;
    Command buttonA_;
    Command buttonB_;

    void Start()
    {
        buttonX_ = new FireGunCommand();
        buttonY_ = new LurchIneffectivelyCommand();
        buttonA_ = new JumpCommand();
        buttonB_ = new SwapWeaponCommand();
    }

    void Update()
    {
        var command = HandleInput();
        if (command != null)
        {
            command.Execute(actor);
        }
    }

    public Command HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            return buttonA_;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            return buttonB_;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            return buttonX_;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            return buttonY_;
        }

        return null;
    }
}