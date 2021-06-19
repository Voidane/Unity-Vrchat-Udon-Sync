
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class ClickCounter : UdonSharpBehaviour
{

    public Text getCount;

    [UdonSynced] public int totalCount;



    public override void Interact()
    {
        if (!Networking.IsOwner(gameObject))
        {
            Networking.SetOwner(Networking.LocalPlayer, gameObject);
        }

        totalCount++;
        getCount.text = totalCount + "";

        RequestSerialization();
    }



    public override void OnDeserialization()
    {
        getCount.text = totalCount + "";
    }

}
