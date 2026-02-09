using UnityEngine;

public class DropTarget : MonoBehaviour
{
    [SerializeField] private float _resetDelay = 2f;
    [SerializeField] private Color _hitColor = Color.red;
    
    private Color _originalColor;
    private SpriteRenderer _spriteRenderer;

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _originalColor = _spriteRenderer.color;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
    //showing it was hit by changing the color
        _spriteRenderer.color = _hitColor;
        
    //hide the target 
        gameObject.SetActive(false);
        
    //turns it back on after delay
        Invoke("ResetTarget", _resetDelay);
    }

    void ResetTarget()
    {
        gameObject.SetActive(true);
        _spriteRenderer.color = _originalColor;
    }
}