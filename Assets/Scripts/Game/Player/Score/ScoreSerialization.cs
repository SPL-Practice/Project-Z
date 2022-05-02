using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ScoreSerialization : MonoBehaviour
{
    
    public void SaveMode()
    {

        ScoreCount scoreForSaving = new ScoreCount();

        BinaryFormatter SaveForm = new BinaryFormatter();

        FileStream sw = new FileStream("Score.dat", FileMode.OpenOrCreate);

        SaveForm.Serialize(sw,scoreForSaving);

        sw.Close();
    
    }
    
    public void LoadMode()
    {

        BinaryFormatter LoadForm = new BinaryFormatter();

        FileStream sr = new FileStream("Score.dat", FileMode.OpenOrCreate);

        ScoreCount scoreForLoad = (ScoreCount)LoadForm.Deserialize(sr);
        
        sr.Close();
    
    }
}
