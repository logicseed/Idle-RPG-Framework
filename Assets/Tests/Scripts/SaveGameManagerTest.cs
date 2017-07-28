using System;
using System.Collections.Generic;
using UnityEngine;
using Debug = ConditionalDebug;

// Tests the save game functionality.
public class SaveGameManagerTest : MonoBehaviour
{
    public bool loadIfExists;
    public bool deleteIfExists;
    public bool saveOnDestroy;

    public SaveGame testSaveGame;

	void Start ()
    {
        if (loadIfExists)
        {
            // Load test
            if (SaveGameManager.SaveGameExists())
            {
                Debug.Log("Save exists, loading.");
                testSaveGame = SaveGameManager.LoadGame();
            }
            else
            {
                Debug.Log("Save file does not exist.");
                SaveGameManager.SaveGame(testSaveGame);
            }
        }

        if (deleteIfExists)
        {
            // Delete test
            SaveGameManager.DeleteSaveGame();
            if (SaveGameManager.SaveGameExists())
            {
                Debug.Log("Save still exists, deleting failed.");
            }
            else
            {
                Debug.Log("Save deleted.");
            }
        }
    }

    private void OnDestroy()
    {
        if (saveOnDestroy)
        {
            Debug.Log("Saving.");
            testSaveGame.isFilled = true;
            SaveGameManager.SaveGame(testSaveGame);
        }
    }

}
