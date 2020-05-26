# Torkoal 
// C# Code. In Zip file, Separate files.

// Boundary Script.cs 

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class BoundaryScript : MonoBehaviour {

	// Use this for initialization
	void cantExit(Collider myCollider)
    {

    }
	}

//Movement 
//Enemy Movement.cs 

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class EnemyMovement : MonoBehaviour {

    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -5)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }

    }
    
    }
    

//LevelManager.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public class LevelManager : MonoBehaviour {

	public void LoadLevel()
    {
        SceneManager.LoadScene("TurtleGame");
    }
		
	
	}

//QuitButton.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	}

//RestartButtonScript.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	}

//spawnMovement.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class spawnMovement : MonoBehaviour
	{
    Vector2 spawnPos;
    public GameObject enemyBag, enemyBottle, dolphin, gull, rings, fish;
    void Start()
    {
        spawnPos = new Vector2(4, 0);
        InvokeRepeating("ChangePosition", 0, 2);
    }

    void ChangePosition()
    {
        transform.position = spawnPos;

        int type = Random.Range(1, 7);

        spawnPos = new Vector2(4, Random.Range((float)-2.20, (float)2.20));

        if(type == 1)
        {
            Instantiate(enemyBag, spawnPos, Quaternion.identity);
        }
        if (type == 2)
        {
            Instantiate(enemyBottle, spawnPos, Quaternion.identity);
        }
        if (type == 3)
        {
            Instantiate(dolphin, spawnPos, Quaternion.identity);
        }
        if (type == 4)
        {
            Instantiate(gull, spawnPos, Quaternion.identity);
        }

        if (type == 5)
        {
            Instantiate(rings, spawnPos, Quaternion.identity);
        }
        if(type == 6)
        {
            Instantiate(fish, spawnPos, Quaternion.identity);
        }


   	}

	}

//TurtleMovement.cs

	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;
	using UnityEngine.SceneManagement;

	public class TurtleMovement : MonoBehaviour
	{

    public float speed = 1;
    public int score = 0;
    public GameObject gameOver;
    public Text userScore;

    void Start()
    {
        gameOver.SetActive(false);
        userScore.text = "Score: " + score;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 2.20)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -2.20)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            gameOver.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            score++;
            userScore.text = "Score: " + score;
        }
        }
	}

//LevelMangerScrpt.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public class LevelMangerScrpt : MonoBehaviour {

    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
	}

//Movement.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	}

//UpAndDown.cs

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class UpAndDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	}

