using UnityEngine;

public class Target : MonoBehaviour
{
    public string enemyTag;

    public string toHit;
    public ushort power;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;

        if (!other.CompareTag(enemyTag))
            return;

        if (other.GetComponent(toHit) is IWeak target)
        {
            target.Hit(power);
        }
    }
}