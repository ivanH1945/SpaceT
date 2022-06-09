
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SistemaDeGuardado 
{
    public static bool dexist;

    public static void saveplayerdata(Player player) // guarda datos
    {
        datosdeljugador data = new datosdeljugador(player);
        string datapath = Application.persistentDataPath + "/player.xwing";
        FileStream fileStream = new FileStream(datapath, FileMode.Create);
        BinaryFormatter binary = new BinaryFormatter();
        binary.Serialize(fileStream, data);
    }
    public static datosdeljugador loadPlayerData() 
    {
        string datapath = Application.persistentDataPath + "/player.xwing";
        if (File.Exists(datapath))
        {
            dexist = true;
            FileStream fileStream = new FileStream(datapath, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            datosdeljugador playerdata = (datosdeljugador)binary.Deserialize(fileStream);
            fileStream.Close();
            return playerdata;

        }
        else 
        {
            dexist = false;

            return null;
        }

    }
}
