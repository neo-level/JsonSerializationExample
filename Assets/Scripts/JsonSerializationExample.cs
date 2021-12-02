using System.Text;
using UnityEngine;

public class JsonSerializationExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var basicObject = new BasicObject
        {
            health = 50,
            shield = 100,
            name = "Corkus",
            position = new Vector3(1, 2, 3)
        };

        string json = JsonUtility.ToJson(basicObject);
        Debug.Log(json);
        byte[] bytes = Encoding.ASCII.GetBytes(json);
        Debug.Log($"{bytes[0]:x}{bytes[1]:x}{bytes[2]:x}{bytes[3]:x}");
        string jsonFromBytes = Encoding.ASCII.GetString(bytes);
        BasicObject playerInfo = JsonUtility.FromJson<BasicObject>(jsonFromBytes);
        Vector3 playerPosition = playerInfo.position;
        Debug.Log($"{playerInfo.name} at {playerPosition.x}, {playerPosition.y}, {playerPosition.z}");
        
    }
}