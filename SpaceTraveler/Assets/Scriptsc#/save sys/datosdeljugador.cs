[System.Serializable]

public class datosdeljugador
{


    public int health;

    public int currentlevel;

    public float[] position = new float[3];
    public float[] astronautposition = new float[3];

    public string CurrentScene;

    public int credits;

    public datosdeljugador(Player player) 
    {
        health = player.health;
        credits = player.credits;
        currentlevel = player.currentlevel;
        CurrentScene = player.CurrentScene;
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

    }
    
}
