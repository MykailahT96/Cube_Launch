using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    
    public Text playerName;

    public void WriteName()
    {
        System.IO.File.WriteAllText(@"\Projects\Unity\Cube_Launch\Assets\TextFiles\PlayerName.txt", playerName.text.ToString());
        Debug.Log(playerName.text.ToString());
    }

}
