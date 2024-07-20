
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Car1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generate", 1.5f, 1.5f);
    }

    private void generate()
    {
        int random = UnityEngine.Random.Range(0, Car1.Length);
        float positionX = UnityEngine.Random.Range(-1.60f,1.60f);
        Instantiate(Car1[random],new Vector3(positionX,transform.position.y,transform.position.z),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
