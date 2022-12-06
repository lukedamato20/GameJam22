using UnityEngine;

public class targetPage : MonoBehaviour
{
    public Transform target1;
    public EnemyAI enemy;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.name == "Page")
        {
            enemy.target = target1;
        }
    }
}