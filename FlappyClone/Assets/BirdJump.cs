using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()   //�� �����Ӹ��� ����
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up*3; //Vector2.up = (0,1) 2���� ��ǥ === (0,3)
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score > Score.bestscore)
        {
            Score.bestscore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene");
    }
}
