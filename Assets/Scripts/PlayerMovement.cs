using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Character Set Up/Character Movement")]

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    #region Variables
    public Vector3 moveDir = Vector3.zero;
    
    private CharacterController charC;
    public float jumpSpeed = 8.0f;
    public float speed = 6.0f;
    public float gravity = 20.0f;
    #endregion
    #region Start
    void Start()
    {
        charC = this.GetComponent<CharacterController>();
    }
    #endregion
    #region Update
    void Update()
    {
        if (charC.isGrounded)
        {

            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpSpeed;
            }
        }
        moveDir.y -= gravity * Time.deltaTime;
        charC.Move(moveDir * Time.deltaTime);
    }
    #endregion
}
