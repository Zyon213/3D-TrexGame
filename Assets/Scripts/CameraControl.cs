
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float camHeight = 1f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camMove = player.position + offset;
        camMove.y = camHeight;
       // camMove.y = 0;
        transform.position = camMove;
      
    }
}
