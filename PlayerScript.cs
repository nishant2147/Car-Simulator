
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    
    float carSpeed = 1.5f;
    public GameObject Gameover,Player;

    //float MaxPoint = 1.60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -1.60f) 
        {
            transform.position = new Vector3(
                transform.position.x - carSpeed * Time.deltaTime,
                transform.position.y,
                transform.position.z
                );
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 1.60f)
        {
            transform.position = new Vector3(
                transform.position.x + carSpeed * Time.deltaTime,
                transform.position.y,
                transform.position.z
                );
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4.35f)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + carSpeed * Time.deltaTime,
                transform.position.z
                );
        }
        if(Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.35f)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y - carSpeed * Time.deltaTime,
                transform.position.z
                );
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "EnemysCar")
        {
            Time.timeScale = 0;
            Gameover.SetActive(true);
        }
    }
    public void Restart()
    {
        Player.SetActive(true);
        Gameover.SetActive(false);
        SceneManager.LoadScene("Car SImilar");
        Time.timeScale = 1;
    }
}
