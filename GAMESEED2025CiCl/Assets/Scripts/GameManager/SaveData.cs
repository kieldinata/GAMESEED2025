// using System.Collections.Generic;
// using UnityEngine;
// using System;

// [System.Serializable]
// public class SaveData
// {
//     public int level;
//     public int money;
//     public int currentExperience;
//     public int maxExperience;
// }

// [System.Serializable]
// public class SpeakerData
// {
//     public int desibelLevel;
//     public int areaLevel;
//     public int cooldownLevel;

//     // Calculate stat with formula: StartingStat = BaseStat * (1 + totalUpgrade * 0.01)
//     public float GetStat(float baseStat)
//     {
//         int totalUpgrade = desibelLevel + areaLevel + cooldownLevel;
//         return baseStat * (1f + totalUpgrade * 0.01f);
//     }
// }

// [System.Serializable]
// public class LongProgression
// {
//     public int highestScore;
//     public int totalSawerCollected;
//     public int currentSoundchip;

//     public int totalPlaytime;       // seconds
//     public int sessionCount;
//     public string currentProfileName;
//     public string lastPlayTimestamp;

//     public SpeakerData speakerData = new SpeakerData();
// }
