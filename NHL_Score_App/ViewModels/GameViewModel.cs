﻿using System;
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

        public GameModel SelectedNote
        {
            get { return _selectedGame; }
            set
            {
                _selectedGame = value;

                if (value == null)
                {
                    
                }
                else
                {
                   
                }

            }
        }

        public string Filter
        {
            get { return _filter; }
            set
            {
                if (value == _filter) { return; }

                _filter = value;
                PerformFiltering();

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Filter)));
            }
        }

        private void PerformFiltering()
        {
            if (_filter == null)
            {
                _filter = "";
            }

            // Search only values that are lowecase and trimmed
            var lowerCaseFilter = Filter.ToLowerInvariant().Trim();

            // Query all game titles that match filter text, as a list
            //var result = _allGames.Where(n => n.Title.ToLowerInvariant()
            //    .Contains(lowerCaseFilter))
            //    .ToList();

            // Get rid of the items that need to be filtered out
            // var toRemove = Games.Except(result).ToList();

            //foreach (var x in toRemove)
            //{
            //    Games.Remove(x);
            //}

            // Add the new results in the correct order
            //var resultCount = result.Count;
            //for (int i = 0; i < resultCount; i++)
            //{
            //    var resultItem = result[i];
            //    if (i + 1 > Games.Count || !Games[i].Equals(resultItem))
            //    {
            //        Games.Insert(i, resultItem);
            //    }
            //}
        }
    }
}
