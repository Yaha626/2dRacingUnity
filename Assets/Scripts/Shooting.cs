using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



//[RequireComponent(typeof(PlayerInput))]


public class Shooting : MonoBehaviour
{
    private PlayerInput _playerInput;

    bool _isShooting = false;


    [SerializeField] GameObject _uiWeaponGun;

    [SerializeField] GameObject _uiWeaponRocket;


    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player1.Shoot.performed += ctx => ShootButton();
    }


    private void OnEnable()
    {
        _playerInput.Enable();
    }


    private void OnDisable()
    {
        _playerInput.Disable();
    }




    public Transform firePoint;

    public GameObject bulletPrefab;

    public GameObject rocketPrefab;

    public float bulletForce = 40f;

    public float bulletTimeInterval = 0.15f;

    public float bulletIntervalCount = 0f;

    private GameObject _currentWeapon;

    private GameObject _currentWeaponUIinfo;

    public bool _shootButton = false;

    


    public AudioSource shooting;


    public void Start()
    {
        _currentWeapon = bulletPrefab;

        _currentWeaponUIinfo = _uiWeaponGun;

        _currentWeaponUIinfo.SetActive(true);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "GunDrop")
        {

            _currentWeapon = bulletPrefab;

              bulletForce = 40f;

              bulletTimeInterval = 0.15f;

            _currentWeaponUIinfo.SetActive(false);
            _currentWeaponUIinfo = _uiWeaponGun;
            _currentWeaponUIinfo.SetActive(true);



        }
        if (collision.gameObject.tag == "RocketDrop")
        {

            _currentWeapon = rocketPrefab;

            bulletForce = 20f;

            bulletTimeInterval = 0.9f;

            _currentWeaponUIinfo.SetActive(false);
            _currentWeaponUIinfo = _uiWeaponRocket;
            _currentWeaponUIinfo.SetActive(true);

        }
    }



    void FixedUpdate()
    {
        bulletIntervalCount += Time.deltaTime;
        //if (Input.GetKey(KeyCode.Space) || _shootButton)
        if(_isShooting  || _shootButton )
        {
          if(bulletIntervalCount >= bulletTimeInterval)
            {
                bulletIntervalCount = 0;
                OnShoot();
                
            }                        
        }

    }

    public void ShootButton(InputValue val)
    {
        _isShooting = val.isPressed;
    }

    
    public void MobileShootButtonDown()
    {
        _shootButton = true;
    }

    public void MobileShootButtonUp()
    {
        _shootButton = false;
    }

   
    public void OnShoot()
    {
        GameObject boolet = Instantiate(_currentWeapon, firePoint.position, firePoint.rotation);
        
        Rigidbody2D rb = boolet.GetComponent<Rigidbody2D>();
        
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
      
    }
   
}
