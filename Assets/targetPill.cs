using UnityEngine;

public class targetPill : MonoBehaviour
{
    public Transform target1;
    public EnemyAI enemy;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.name == "pill1")
        {
            enemy.target = target1;
        }
    }
}
