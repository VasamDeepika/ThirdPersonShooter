using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;

    public int playerMoveSpeed;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        var horizontalMove = Input.GetAxis("Horizontal");
        var verticalMove = Input.GetAxis("Vertical");

        var playerMove = new Vector3(horizontalMove, 0, verticalMove);
        characterController.SimpleMove(playerMove * Time.deltaTime);
    }


}
