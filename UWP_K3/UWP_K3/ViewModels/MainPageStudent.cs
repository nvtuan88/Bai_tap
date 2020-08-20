using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using UWP_K3.Models;

namespace UWP_K3.ViewModels
{
    public class MainPageStudent
    {
        public MainPageStudent() {
            for (int i = 0; i < 10; i++)
            {
                var item = new Models.StudenItem()
                {
                    id = string.Format("Task Title {0}", i),
                    name = string.Format("Student {0}", i),
                    gpa = string.Format("gpa {0}", i)
                };
                this.Items.Add(item);
            }
        }
        public ObservableCollection<Models.StudenItem> Items { get; private set; } = new ObservableCollection<Models.StudenItem>();
    }
}
