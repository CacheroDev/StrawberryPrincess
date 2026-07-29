

using UnityEngine;

public class ToTheLeft : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
