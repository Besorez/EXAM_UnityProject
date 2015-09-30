using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public int stepLength;
    public GameObject player;
	public int camSpeed;
	public Vector3 Direction;

	private int Rotation;

    // Use this for initialization
    void Start()
    {
		Direction = new Vector3 (0, 0, stepLength);
    }

	void ChangeDirection(bool direction)
	{
		if (direction == true) {
			if (Direction.z == stepLength) {
				Direction = new Vector3 (stepLength, 0, 0);
				return;
			}

			if (Direction.x == stepLength) {
				Direction = new Vector3 (0, 0, -stepLength);
				return;
			}

			if (Direction.z == -stepLength) {
				Direction = new Vector3 (-stepLength, 0, 0);
				return;
			}

			if (Direction.x == -stepLength) {
				Direction = new Vector3 (0, 0, stepLength);
				return;
			}
		}

		if (direction == false) {
			if (Direction.z == stepLength) {
				Direction = new Vector3 (-stepLength, 0, 0);
				return;
			}

			if (Direction.x == stepLength) {
				Direction = new Vector3 (0, 0, stepLength);
				return;
			}

			if (Direction.z == -stepLength) {
				Direction = new Vector3 (stepLength, 0, 0);
				return;
			}

			if (Direction.x == -stepLength) {
				Direction = new Vector3 (0, 0, -stepLength);
				return;
			}
		}
	}

    // Update is called once per frame
    void Update()
    {
		if ( Input.GetKeyDown(KeyCode.W)) {
			player.transform.position += Direction;
			Debug.Log("Произошло движение персонажа вперед");
		}
		else if ( Input.GetKeyDown(KeyCode.S)) {
			player.transform.position -= Direction;
			Debug.Log("Произошло движение персонажа назад");
		}
		else if ( Input.GetKeyDown(KeyCode.D)) {
			Rotation += 90;
			if (Rotation == 360)
			{
				Rotation = 0;
			}
			player.transform.rotation = Quaternion.Euler(0,Rotation,0);
			ChangeDirection(true);
			Debug.Log("Произошел поворот персонажа вправо");
		} 
		else if ( Input.GetKeyDown(KeyCode.A)) {
			if (Rotation == 0) {
				Rotation = 360;
			}
			Rotation -= 90;

			player.transform.rotation = Quaternion.Euler(0,Rotation,0);
			ChangeDirection(false);
			Debug.Log("Произошло поворот персонажа влево");
		} 
    }
}
