using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool haveItem;

    //公開且參數為零或一
    public void ThrowPickUp()
    {
        print("撿起物件");
    }

    public void ThrowDetach()
    {
        print("放開物件");
    }

    public void ThrowHead()
    {
        print("拿著物件");
        haveItem = true;
    }
}
