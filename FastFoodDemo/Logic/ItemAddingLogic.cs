using FastFoodDemo.Models;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Logic
{
    public class ItemAddingLogic
    {
        private StringBuilder LogMessage { get; set; }
        public string AddItems()
        {
            LogMessage = new StringBuilder();
            var folderPath = GetFolder();
            LogMessage.AppendLine($"Folder: {folderPath}");
            if (string.IsNullOrEmpty(folderPath))
            {
                return string.Empty;
            }
            var parent = new Parent();
            var collection = new SeasonalCollection()
            {
                Id = Guid.NewGuid(),
                IsHeadliner = true,
                Name = folderPath.Split('\\').Last(),
                Seasons = new System.ComponentModel.BindingList<Collection>()
            };
            parent.SeasonalCollectionId = collection.Id;
            var directories = Directory.GetDirectories(folderPath);
            if (directories.Count() > 0)
            {
                foreach (var directory in directories)
                {
                    Collection season = GetSeason(directory, parent);
                    if (season.Videos.Any())
                    {
                        collection.Seasons.Add(season);
                    }
                }
            }
            else
            {
                Collection season = GetSeason(folderPath, parent);
                if (season.Videos.Any())
                {
                    collection.Seasons.Add(season);
                }
            }

            Context.Collections.Add(collection);
            Context.Save();

            return LogMessage.ToString();
        }

        private Collection GetSeason(string directory, Parent parent)
        {
            var season = new Collection
            {
                Id = Guid.NewGuid(),
                Name = directory.Split('\\').Last(),
                Parent = parent
            };
            parent.SeasonId = season.Id;
            LogMessage.AppendLine($"     {season.Name}");
            season.Videos = new System.ComponentModel.BindingList<Video>();
            var files = Directory.GetFiles(directory);
            LogMessage.AppendLine($"        :");

            foreach (var path in files)
            {
                var properties = new FileInfo(path);
                if (AllowedExtension.Contains(properties.Extension.ToUpper()))
                {
                    season.Videos.Add(new Models.Video()
                    {
                        Id = Guid.NewGuid(),
                        Name = properties.Name,
                        Path = path,
                        TimeSkips = new List<Models.SignificantMoment>(),
                        Parent = parent
                    });
                    LogMessage.AppendLine($"            {properties.Name},");
                }
            }

            return season;
        }

        private string GetFolder()
        {
            using (var fbd = new CommonOpenFileDialog())
            {
                fbd.IsFolderPicker = true;
                CommonFileDialogResult result = fbd.ShowDialog();

                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    return fbd.FileName;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        private static List<string> AllowedExtension => new List<string>()
        {
            ".PRPROJ",
            ".AEP",
            ".PSV",
            ".SWF",
            ".MKV",
            ".SFD",
            ".MP4",
            ".META",
            ".PIV",
            ".BIK",
            ".RMVB",
            ".WEBM",
            ".VEG",
            ".AEGRAPHIC",
            ".CPVC",
            ".DMX",
            ".IZZ",
            ".JTV",
            ".KDENLIVE",
            ".M1V",
            ".NCOR",
            ".SFVIDCAP",
            ".VIV",
            ".PZ",
            ".MSWMM",
            ".MXF",
            ".WLMP",
            ".STR",
            ".SRT",
        };
    }
}
