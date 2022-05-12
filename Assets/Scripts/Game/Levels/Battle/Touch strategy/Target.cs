using UnityEngine;

public class Target : MonoBehaviour
{
    public string enemyTag;

    public string toHit;
    public ushort power;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject weakPart = collision.gameObject;

        if (!weakPart.CompareTag(enemyTag))
            return;

        GameObject weak = weakPart.transform.parent.gameObject;

        if (weak.GetComponent(typeof(IWeak)) is IWeak target)
        {
            target.Hit(power);
            Destroy(gameObject);
        }
    }
}