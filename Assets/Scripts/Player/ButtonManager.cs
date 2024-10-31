using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager :         MonoBehaviour
{
    [SerializeField] private Button dashButton; // Button được gán từ Inspector
    [SerializeField] private Button shootButton; // Button được gán từ Inspector
    [SerializeField] private Button switchWeapon; // Button được gán từ Inspector

    private PlayerMovement playerMovement;
    private PlayerWeapon playerWeapon;


    private void Start()
    {
        // Gắn sự kiện OnClick cho Button bằng code
        dashButton.onClick.AddListener(OnDashButtonClicked);
        
        switchWeapon.onClick.AddListener(OnSwitchWeaponClicked);  
        
    }
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    // void FixedUpdate()
    // {
    //     shootButton.onClick.AddListener(OnShootButtonClicked);
    // }
    private void Update()
    {
        // if (SceneManager.GetActiveScene().name == "Dungeon")
        // {
        //     AssignButtonsInScene2(); // Gán button trong Scene 2
        // }
        // Nếu không tìm thấy PlayerMovement thì tìm lại
        // if (playerMovement == null)
        // {
        //     playerMovement = FindObjectOfType<PlayerMovement>();
        // }
        
        if (LevelManager.Instance.SelectedPlayer != null)
        {
            if (playerMovement == null)
            {
                playerMovement = LevelManager.Instance.SelectedPlayer.GetComponent<PlayerMovement>();
            }
            
        }
        
        if (LevelManager.Instance.SelectedPlayer != null)
        {
            if (playerWeapon == null)
            {
                playerWeapon = LevelManager.Instance.SelectedPlayer.GetComponent<PlayerWeapon>();
            }
        }
        
    }
    

    private void OnDashButtonClicked()
    {
        // Gọi hàm Dash của PlayerMovement khi button được nhấn
        playerMovement.Dash();
    }
    public void OnShootButtonClicked()
    {
        // Gọi hàm ShootWeapon của PlayerWeapon khi button được nhấn
        playerWeapon.ShootWeapon();
    }
    private void OnSwitchWeaponClicked()
    {
        // Gọi hàm ChangeWeapon của PlayerWeapon khi button được nhấn
        playerWeapon.ChangeWeapon();
    }
}
