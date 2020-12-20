using UnityEngine;
using UdemyProject1.Controllers;

public class FireballManager : MonoBehaviour
{
    [SerializeField] GameObject ExitPoint;
    private Vector3 exitPoint;
    private RedDragonManager redDragon;

    private void Start()
    {
        SetExitPoint();
    }

    private void Update()
    {
        Remove();
    }

    private void SetExitPoint()
    {
        exitPoint = ExitPoint.transform.position;
    }

    private void Remove()
    {
        if(gameObject.transform.position.x>exitPoint.x)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        redDragon = collision.GetComponent<RedDragonManager>();
        RedDragonPoolManager.Instance.SetPoolObject(redDragon);
        Destroy(this.gameObject);
        GameManager.Instance.AddScore();
    }
}
