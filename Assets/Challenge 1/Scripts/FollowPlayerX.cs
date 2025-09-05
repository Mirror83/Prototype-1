using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    private Vector3 offset = new(20f, 1.2f, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
