
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public PlayerMovement playermovement;
   
    void OnCollisionEnter (Collision collision_info)
    {
        
        if (collision_info.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle");
            playermovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();


        }
    }

}
