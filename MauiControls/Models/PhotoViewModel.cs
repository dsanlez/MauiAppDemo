using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class PhotoViewModel
    {
        public ObservableCollection<Photo> photos { get; private set; }
        public ObservableCollection<Photo> Photos
        {
            get { return photos; }
            set { photos = value; }
        }
        public PhotoViewModel()
        {
            Photos = new ObservableCollection<Photo>()
            {
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpg"},
                new Photo() {Name = "Milky Way", ImageUrl = "milkyway.jpg"},
                new Photo() {Name = "Galaxyy", ImageUrl = "galaxy.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy2.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy3.jpg"},
                new Photo() {Name = "Milky Way", ImageUrl = "milkyway.jpg"},
                new Photo() {Name = "Galaxyy", ImageUrl = "galaxy4.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy2.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpg"},
                new Photo() {Name = "Milky Way", ImageUrl = "milkyway.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy3.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy2.jpg"},
            };
        }
    }
}
