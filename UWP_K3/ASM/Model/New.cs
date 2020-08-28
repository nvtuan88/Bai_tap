using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.WindowManagement;

namespace ASM.Model
{
    public class New
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public NewCategory Category { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }

        public New(string name, NewCategory category, string title, string des) {
            Des = des;
            Title = title;
            Category = category;
            Image = string.Format("/Assets/Images/{0}/{1}.jpg", category, name);
        }
    }

    public enum NewCategory {
        Gaming,
        Entertainment,
        Productivity,
        Deal

    }
}
