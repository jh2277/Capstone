using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody rigid;

    //����
    private bool isJump;
    public float jumpPower;
    //���� �Ŵ���
    //public GameManager gameManager;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
            isJump = true;
        }
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v) * speed, ForceMode.Impulse);
        //transform.Translate(new Vector3(h,0,v) * speed); �긦 ���� x�� y���� ������. rigid.addforce�� �Ἥ ���� ������ �̴� �������� ����.
    }
   
    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Floor")
    //    {
    //        isJump = false;
    //    }

    //    if (other.gameObject.layer == LayerMask.NameToLayer("Item"))
    //    {
    //        gameManager.EatItem(other.gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        //if (gameObject.layer == LayerMask.NameToLayer("Item"))
        //{
        //    gameManager.itemCount++;
        //    gameManager.GetItem(gameManager.itemCount); //UI�� ��Ÿ���� ����.
        //    Destroy(other.gameObject);
        //}

        if (other.gameObject.tag == "Finish")
        {
            //gameManager.NextStage(); //UI�� ��Ÿ���� ����.
        }

        if (other.gameObject.tag == "Fall")
        {
            //SceneManager.LoadScene(gameManager.stage);
        }
    }
}



