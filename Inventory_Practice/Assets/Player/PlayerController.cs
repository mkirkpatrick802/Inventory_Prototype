using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Interactions")]
    [SerializeField][Range(.5f, 2)] private float _interactRadius;
    [SerializeField] LayerMask _interactionLayerMask;

    [Header("Basic Movement")]
    [SerializeField] private float _moveSpeed;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
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

        interactable.GetComponent<Interactable>().Interact();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _interactRadius);
    }
}
