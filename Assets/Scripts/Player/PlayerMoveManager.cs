using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveManager : MonoBehaviour
{

    [Header("Elements")]
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawn;

    [Header("Ayarlar")]
    [SerializeField] private float playerMoveSpeed= 5f;
    [SerializeField] private float rangeX = 4f;
    [SerializeField] private float rangeY = 8f;


    private Vector2 moveInput;



    private void Update()
    {

        PlayerMove();
        ClampArea();
        
       
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void PlayerMove()
    {
        Vector3 hareket = new Vector3(moveInput.x, moveInput.y, 0);
        hareket = hareket.normalized;
        transform.Translate(hareket * playerMoveSpeed * Time.deltaTime);
    }

    void ClampArea()
    {
        Vector3 clampPos  = transform.position;

        clampPos.x=Mathf.Clamp(clampPos.x, -rangeX, rangeX);
        clampPos.y=Mathf.Clamp(clampPos.y, -rangeY, rangeY);
        transform.position = clampPos;
    }

    void BulletAttack()
    {
        
        Instantiate(bulletPrefab, bulletSpawn.position,Quaternion.identity);
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            BulletAttack();
        }
    }






}








/*
   public class PlayerHareketManager : MonoBehaviour
   {
       [SerializeField] float moveSpeed = 5f;

       private void Update()
       {
           float h = Input.GetAxis("Horizontal");
           float v = Input.GetAxis("Vertical");

           Vector3 hareketVectoru = new Vector3(h, v, 0);

           transform.Translate(hareketVectoru * moveSpeed * Time.deltaTime);
       }
   }
   */








/*
   Vector3 yatayHareket = new Vector3(1,0,0);
   Vector3 dikeyHareket = new Vector3(0,1,0);
   if (Keyboard.current.aKey.isPressed)
   {
       transform.Translate(-yatayHareket*playerMoveSpeed*Time.deltaTime);
   }
   if (Keyboard.current.dKey.isPressed)
   {
       transform.Translate(yatayHareket * playerMoveSpeed * Time.deltaTime);
   }
   if (Keyboard.current.wKey.isPressed)
   {
       transform.Translate(-dikeyHareket * playerMoveSpeed * Time.deltaTime);
   }
   if (Keyboard.current.sKey.isPressed)
   {
       transform.Translate(dikeyHareket * playerMoveSpeed * Time.deltaTime);
   }*/
