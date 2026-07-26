

using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    [SerializeField] float lifeDuration;

    void Start()
    {
        Destroy(gameObject, lifeDuration);
    }
}
