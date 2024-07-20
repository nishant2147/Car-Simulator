
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float Speed;
    Renderer renderer;
    

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Speed += Time.deltaTime * 0.01f;
        float yoffset = (Time.time * Speed);
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0f, yoffset));
    }
}
