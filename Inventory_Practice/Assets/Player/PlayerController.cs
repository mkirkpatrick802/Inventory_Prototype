using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Interactions")]
    [SerializeField][Range(.5f, 2)] private float _interactRadius;
    [SerializeField] LayerMask _interactionLayerMask;

    [Header("Basic Movement")]
    [SerializeField] private float _moveSpeed;

    [Header("Inventory Settings")]
    [SerializeField] private int _inventorySize;

    private Rigidbody2D _rb;
    private Inventory _inventory;
    private GameObject _pauseMenu;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _inventory = new Inventory(_inventorySize);
    }

    private void Start()
    {
        //Spawn UI Elements
        _pauseMenu = Instantiate(ReferenceManager.instance.pauseMenu).gameObject;
        _pauseMenu.GetComponentInChildren<InventoryUI>().SetInventoryUI(_inventory);
        _pauseMenu.gameObject.SetActive(false);
    }

    public void Movement(Vector2 movementAxis)
    {
        Vector2 _currentVelocity = _rb.velocity;
        Vector2 _targetVelocity = Vector2.ClampMagnitude(movementAxis * _moveSpeed, _moveSpeed * Time.deltaTime);
        Vector2 _velocityChange = _targetVelocity - _currentVelocity;
        _rb.AddForce(_velocityChange, ForceMode2D.Impulse);
    }

    public void Interact()
    {
        Collider2D interactable = Physics2D.OverlapCircle(transform.position, _interactRadius, _interactionLayerMask);

        if (interactable == null) return;
        Item pickedUpItem = interactable.GetComponent<Interactable>().Interact(); // If Interactable is an item it will return the item else it will return null

        if (pickedUpItem == null) return;
        _inventory.AddItem(pickedUpItem);
    }

    public void Escape()
    {
        if (_pauseMenu.activeSelf)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
        _pauseMenu.SetActive(!_pauseMenu.activeSelf);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _interactRadius);
    }
}
