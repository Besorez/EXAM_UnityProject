using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public int stepLength;
    public GameObject player;
	public int camSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if ( Input.GetKeyDown(KeyCode.W)) {
			player.transform.position += new Vector3(0,0,stepLength);
			Debug.Log("Произошло движение персонажа вперед");
		}
		else if ( Input.GetKeyDown(KeyCode.S)) {
			player.transform.position -= new Vector3(0,0,stepLength);
			Debug.Log("Произошло движение персонажа назад");
		}
		else if ( Input.GetKeyDown(KeyCode.A)) {
			// player.transform.position += new Vector3(stepLength,0,0);
			//player.transform.rotation = new Quaternion(0,45,0,0);
			Camera.main.transform.Rotate(0, camSpeed *Time.deltaTime, 0); //Крутим по оси Y

			Debug.Log("Произошло движение персонажа влево");
		} 
		else if ( Input.GetKeyDown(KeyCode.D)) {
			player.transform.position -= new Vector3(stepLength,0,0);
			Debug.Log("Произошло движение персонажа вправо");
		} 
    }
}
