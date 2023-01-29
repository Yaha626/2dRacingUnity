using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class Shooting : MonoBehaviour
{
    private PlayerInput _playerInput;


    [SerializeField] GameObject _uiWeaponGun;

    [SerializeField] GameObject _uiWeaponRocket;


    public Transform firePoint;

    public GameObject bulletPrefab;

    public GameObject rocketPrefab;

    public float bulletForce = 40f;

    public float bulletTimeInterval = 0.20f;

    public float bulletIntervalCount = 0f;

    private GameObject _currentWeapon;

    private GameObject _currentWeaponUIinfo;

    private bool _shootButton = false;

    public AudioSource shooting;



    private void Awake()
    {

        _playerInput = new PlayerInput();

    }



    private void OnEnable()
    {
        _playerInput.Enable();
    }



    private void OnDisable()
    {
        _playerInput.Disable();
    }



    public void Start()
    {

        _playerInput.Player1.Shoot.performed += Shoot_performed;   

        _playerInput.Player1.Shoot2.performed += Shoot2_performed;

        _currentWeapon = bulletPrefab;

        _currentWeaponUIinfo = _uiWeaponGun;

        _currentWeaponUIinfo.SetActive(true);
    }



    
    private void Shoot2_performed(InputAction.CallbackContext obj)
     {

        if (bulletIntervalCount > bulletTimeInterval)
        {   
           _shootButton = true;

        }
     
     }

    private void Shoot_performed(InputAction.CallbackContext obj)
    {

        bulletIntervalCount = 0;

        _shootButton = true;

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
               
          if (_shootButton & bulletIntervalCount > bulletTimeInterval)
          {

              bulletIntervalCount = 0;

              OnShoot();

          }

        _shootButton = false;

    }



    public void OnShoot()
    {
        GameObject boolet = Instantiate(_currentWeapon, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = boolet.GetComponent<Rigidbody2D>();

        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }

}
