using FastFoodDemo.Interfaces;
using FastFoodDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Logic
{
    public static class Context
    {
        public static List<SeasonalCollection> Collections { get; set; }

        internal static void Save()
        {
            var result = JsonConvert.SerializeObject(Collections);
            File.WriteAllText(FullSavePath, result);
        }

        public static ViewSwitcher ViewSwitcher { get; internal set; }

        internal static void ReadSavedConfig()
        {
            if (!File.Exists(FullSavePath))
            {
                File.Create(FullSavePath);
            }
            if (File.Exists(FullSavePath))
            {
                var text = File.ReadAllText(FullSavePath);
                var result = JsonConvert.DeserializeObject<List<SeasonalCollection>>(text);
                Collections = result ?? new List<SeasonalCollection>();
            }
            else
            {
                Collections = new List<SeasonalCollection>();
            }
        }

        static string SaveFolder => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string SaveFileName => "BocBocConfig.json";
        static string FullSavePath => Path.Combine(SaveFolder, SaveFileName);

        internal static List<SeasonalCollection> GetHeadliners()
        {
            return Collections.Where(i => i.IsHeadliner).ToList();
        }

        internal static Video GetNextVideo(Video video)
        {
            var collection = Collections.FirstOrDefault(x => x.Id == video.Parent.SeasonalCollectionId);
            var season = collection.Seasons.FirstOrDefault(x => x.Id == video.Parent.SeasonId);
            var currentVideo = season.Videos.FirstOrDefault(x => x.Id == video.Id);

            var currentIndex = season.Videos.IndexOf(currentVideo);
            if (season.Videos.Count > currentIndex)
            {
                return season.Videos[currentIndex + 1];
            }
            else
            {
                var seasonIndex = collection.Seasons.IndexOf(season);
                if (collection.Seasons.Count < seasonIndex)
                {
                    return collection.Seasons[seasonIndex + 1].Videos[0];
                }
            }
            return null;
        }
    }
}
