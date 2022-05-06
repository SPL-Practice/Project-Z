using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ScoreSerialization : MonoBehaviour
{
    public string levelName;

    public void SaveMode(ulong score)
    {
        BinaryFormatter saveForm = new BinaryFormatter();
        FileStream scoreFile = new FileStream(levelName + ".dat", FileMode.OpenOrCreate);

        saveForm.Serialize(scoreFile, score);
        scoreFile.Close();
    }
    
    public ulong LoadMode()
    {
        BinaryFormatter loadForm = new BinaryFormatter();
        FileStream scoreFile = new FileStream(levelName + ".dat", FileMode.OpenOrCreate);
        
        ulong score = (scoreFile.Length <= 0) ? 0 :
            (ulong)loadForm.Deserialize(scoreFile);
        scoreFile.Close();
        return score;
    }
}
