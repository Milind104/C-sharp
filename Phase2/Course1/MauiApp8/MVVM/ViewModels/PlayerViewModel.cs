using MauiApp8.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp8.MVVM.ViewModels
{
    public class PlayerViewModel
    {
        public ObservableCollection<Player> Players{get; set;}

        public PlayerViewModel()
        {
            Players = new ObservableCollection<Player>{
                new Player{
                    Name = "Cameron Heyward",
                    Image = "cameron_heyward.png",
                    Information= "Five-time Pro Bowler (2018, 2019, 2020, 2021, 2022)",
                    InProBowl=false
                },
                new Player{
                    Name = "George Pickens",
                    Image = "george_pickens.png",
                    Information= "A vertical receiver who dominates opponents with size and great hands",
                    InProBowl=false
                },
                new Player{
                    Name = "Kenny Pickett",
                    Image = "kenny_pickett.png",
                    Information= "Pitt's all-time leader in passing yards (12,303), pass completions (1,045), total offense (13,112), touchdown responsibility (102) and passing touchdowns (81)",
                    InProBowl=false
                },
                new Player{
                    Name = "Minkah Fitzpatrick",
                    Image = "minkah_fitzpatrick.png",
                    Information= "314 tackles (212 solo), 33 passes defensed, 13 interceptions, 5 tackles for loss, 4 fumble recoveries, four forced fumbles, 3 interception returns for TDs",
                    InProBowl=true
                },
            };
        }
        }
}
