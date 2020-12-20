using UdemyProject1.Controllers;

public class RedDragonPoolManager : GenericPoolManager<RedDragonManager>
{
    public static RedDragonPoolManager Instance { get; private set; }

    public override void ResetPoolObjects()
    {
        foreach (RedDragonManager child in transform.GetComponentsInChildren<RedDragonManager>())
        {
            if (!child.gameObject.activeSelf)
            {
                continue;
            }
            //Else, Do The Following
            RedDragonPoolManager.Instance.SetPoolObject(child);
        }
    }

    protected override void SingletonThisObject()
    {
        if (Instance==null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);  
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
