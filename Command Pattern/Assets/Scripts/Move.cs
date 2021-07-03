using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Icommands
{
    private Vector3 direction;
    private float distance;
    private Transform objectToMove;


    public Move(Transform objectToMove, Vector3 direction, float distance)
    {
        this.objectToMove = objectToMove;
        this.direction = direction;
        this.distance = distance;
    }

    public void Execute()
    {
        objectToMove.position += direction * distance;
    }

    public void Undo()
    {
        objectToMove.position -= direction * distance;
    }


}
