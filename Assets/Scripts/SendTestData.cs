using UnityEngine;

public class SendTestData : MonoBehaviour
{
	public void SendData()
	{
		FirebaseData.SendData("Alex", "24");
	}

}
