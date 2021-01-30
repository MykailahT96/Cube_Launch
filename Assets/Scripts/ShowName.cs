using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    
    public Text nameText;

    public void Update()
    {
        nameText.text = System.IO.File.ReadAllText(@"\Projects\Unity\Cube_Launch\Assets\TextFiles\PlayerName.txt");
       
    }
}
