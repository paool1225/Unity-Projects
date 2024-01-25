using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class KeyPickup : MonoBehaviour
{
    private int keyCounter = 0;
    public TextMeshProUGUI KeyCounterText;
    public float pickupRadius = 1f;
    public GameObject Door;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (keyCounter >= 3)
            {
                TryOpenDoor();
            }
            else
            {
                TryPickUpKey();
            }
            
        }
    }
    void TryPickUpKey()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, pickupRadius);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Key"))
            {
                // Key found, pick it up
                PickUpKey(collider.gameObject);
                break;
            }
        }
    }
    void PickUpKey(GameObject Key)
    {
        Destroy(Key);

        keyCounter++;

        UpdateKeyCounterUI();
    }

    void TryOpenDoor()
    {
        if (Door == null)
        {
            Door.SetActive(false);
        }
        SceneManager.LoadSceneAsync("GameOver");
    }

    void UpdateKeyCounterUI()
    {
        if(KeyCounterText != null)
        {
            KeyCounterText.text = "Keys: " + keyCounter.ToString();
        }
    }
}
