using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Model
{
    class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds) {
            var allSounds = getSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        
        }

        private static List<Sound> getSounds() 
        { 
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundsCategory.Animals));
            sounds.Add(new Sound("Cat", SoundsCategory.Animals));

            sounds.Add(new Sound("Gun", SoundsCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundsCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundsCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundsCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundsCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundsCategory.Warnings));

            return sounds;
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundsCategory soundsCategory) {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soundsCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }
    }
}
