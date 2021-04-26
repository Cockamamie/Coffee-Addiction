using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    private void Update()
    {
        var position = player.transform.position;
        transform.position = new Vector3(position.x, position.y, -10f);
    }
}
