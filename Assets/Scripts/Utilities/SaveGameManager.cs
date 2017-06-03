using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveGameManager
{
    public static bool SaveGame(SaveGame saveGame)
    {
        if (!saveGame.isFilled)
        {
            throw new ArgumentException("Tried to save an empty save game file.");
        }

        var binaryFormatter = new BinaryFormatter();

        using (var stream = new FileStream(SavePath, FileMode.Create))
        {
            try
            {
                binaryFormatter.Serialize(stream, saveGame);
            }
            catch (Exception)
            {
                return false;
            }
        }
        return true;
    }

    public static SaveGame LoadGame()
    {
        if (!File.Exists(SavePath)) return null;

        var binaryFormatter = new BinaryFormatter();

        using (var stream = new FileStream(SavePath, FileMode.Open))
        {
            try
            {
                return binaryFormatter.Deserialize(stream) as SaveGame;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    public static bool DeleteSaveGame()
    {
        try
        {
            File.Delete(SavePath);
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public static string SavePath
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, "progress.save");
        }
    }
}

