using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public PlayerMove character;
    [SerializeField]
    private float distance = 1f;

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }



    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.W)) SendMovement(character.transform, Vector3.forward, distance);
        if (Input.GetKeyDown(KeyCode.A)) SendMovement(character.transform, Vector3.left, distance);
        if (Input.GetKeyDown(KeyCode.S)) SendMovement(character.transform, Vector3.back, distance);
        if (Input.GetKeyDown(KeyCode.D)) SendMovement(character.transform, Vector3.right, distance);
        if (Input.GetKeyDown(KeyCode.Z)) character?.UndoCommand();
        if (Input.GetKeyDown(KeyCode.R)) character?.RedoCommand(); 
    }

    private void SendMovement(Transform objectToMove, Vector3 direction, float distance)
    {
        Icommands movement = new Move(objectToMove, direction, distance);
        character?.AddCommand(movement as Move);

    }


}
