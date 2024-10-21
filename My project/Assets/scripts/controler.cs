using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
  Rigidbody rb;
  [SerializeField] float speed = 5.0f;
  [SerializeField] float jumpForce = 300;
  bool canJump;
  [SerializeField] int jumpNumber = 2;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    
  }

  // Update is called once per frame
  void Update()
  {
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
    rb.velocity = new Vector3(x * speed, rb.velocity.y, z * speed);
    if (Input.GetButtonDown("Jump") && jumpNumber > 0)
    {
      rb.AddForce(0, jumpForce, 0);
      // jumpNumber = jumpNumber-1;
      // jumpNumber -=1;
      jumpNumber--;
    }

    Vector3 dir = rb.velocity;
    dir.y = 0;
    if (dir.magnitude > 0.1f)
    {
      transform.forward = dir;
    }
  }
  private void OnCollisionEnter(Collision TheThingIHit)
  {
    jumpNumber = 2;


  }
}
