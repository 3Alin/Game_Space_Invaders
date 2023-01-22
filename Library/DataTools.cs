using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Space_Invaders.Library
{
    struct playerData
    {
        public string name;
        public int score;
    }

    internal static class DataTools
    {
        public static string path = "..\\..\\Data\\score_data.txt";
        public static List<playerData> getScoreData()
        {
            List<playerData> result = new List<playerData>();
            try
            {
                string tmp = File.ReadAllText(path);
                string[] rawData = tmp.Split('\n');

                for (int i = 0; i < rawData.Length; i++)
                {
                    playerData data = new playerData
                    {
                        name = rawData[i].Split('\t')[0],
                        score = int.Parse(rawData[i].Split('\t')[1])
                    };
                    result.Add(data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Save file might be corrupted\n" + e.Message);
                return null;
            }

            return result;
        }

        public static bool dataAdd(string name, int score)
        {
            try
            {
                List<playerData> data = getScoreData();
                List<playerData> playerData = data.Where(d => d.name == name).ToList();

                if (playerData.Count == 0)
                {
                    playerData newPlayer = new playerData
                    {
                        name = name,
                        score = score
                    };
                    data.Add(newPlayer);
                    File.WriteAllText(path, dataToString(data));
                    Console.WriteLine("OK");
                    return true;
                }

                foreach (var player in playerData)
                {
                    if (player.score >= score)
                        return false;

                    var tmp = data.Find(i => i.name == player.name);
                    tmp.score = score;
                    data[data.FindIndex(i => i.name == player.name)] = tmp;
                }

                File.WriteAllText(path, dataToString(data));
            }
            catch(Exception e) 
            {
                return false; 
            }
            return true;
        }

        public static string dataToString(List<playerData> data)
        {
            string result = "";
            bool firstLine = true;

            foreach (var player in data)
            {
                if (firstLine)
                {
                    result = result + player.name + '\t' + player.score;
                    firstLine = false;
                }
                else
                    result = result + '\n' + player.name + '\t' + player.score;
            }

            return result;
        }

        public static List<playerData> getSortedScoreData()
        {
            return getScoreData().OrderByDescending(i => i.score).ToList();
        }

        public static playerData getHighscore()
        {
            return getSortedScoreData().First();
        }
    }
}
