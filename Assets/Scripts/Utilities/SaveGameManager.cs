using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

/// <summary>
/// Manages the save games.
/// </summary>
public static class SaveGameManager
{
    /// <summary>
    /// Saves the provided save game data.
    /// </summary>
    /// <param name="saveGame">The save game data.</param>
    /// <returns>Whether or not the save was successful.</returns>
    public static bool SaveGame(SaveGame saveGame)
    {
        if (!saveGame.IsFilled)
        {
            throw new ArgumentException("Tried to save an incomplete save game file.");
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

    /// <summary>
    /// Loads save game data from disk.
    /// </summary>
    /// <returns>The save game data.</returns>
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

    /// <summary>
    /// Deletes any existing save game data.
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// Path of the save game data.
    /// </summary>
    public static string SavePath
    {
        get
        {
            return Path.Combine(Application.persistentDataPath, "progress.save");
        }
    }

    /// <summary>
    /// Whetehr or not a save game exists.
    /// </summary>
    public static bool SaveGameExists
    {
        get
        {
            return File.Exists(SavePath);
        }
    }
}

