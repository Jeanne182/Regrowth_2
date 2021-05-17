using UnityEngine;

public class Transformation : MonoBehaviour
{

  public Animator animator;
  public bool wilt = true;

  /*public static Transformation instance ;

  private void Awake()
  {
      if(instance != null){
        Debug.LogWarning("Il y a plus d'un Transformation");
        return ;
      }
      instance = this;
  }*/

  private void OnCollisionEnter2D(Collision2D collision)
  {
      if(collision.transform.CompareTag("Player") && wilt)
      {
        animator.SetTrigger("Bloom");
        wilt = false;
      }
      else if(collision.transform.CompareTag("Player") && !wilt){
        animator.SetTrigger("Wilt");
        wilt = true;
      }

  }
}
