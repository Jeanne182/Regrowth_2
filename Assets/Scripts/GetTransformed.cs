using UnityEngine;
using System;

public class GetTransformed : MonoBehaviour
{
    public Animator animator;
    public Transformation parent;

    private void OnTriggerEnter2D(Collider2D collision){
      if(collision.transform.CompareTag("Player") && parent.wilt){
        Debug.LogWarning("test");
          animator.SetTrigger("Bloom");
      }
      if(collision.transform.CompareTag("Player") && !parent.wilt){

          animator.SetTrigger("Wilt");
      }
    }
}
