using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL_Score_App.Models;

namespace NHL_Score_App.ViewModels
{
    public class GameViewModel
    {
        public ObservableCollection<GameModel> Games { get; set; }

        private List<GameModel> _allGames = new List<GameModel>();

        private GameModel _selectedGame;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _filter;

        // Game Object fields

        public GameViewModel ()
        {
            Games = new ObservableCollection<GameModel>();

            // PerformFiltering();
        }
    }
}
