using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL_Score_App.Models;
using NHL_Score_App.ContentDialogs;
using Windows.UI.Xaml.Controls;

namespace NHL_Score_App.ViewModels
{
    public class GameViewModel
    {
        public ObservableCollection<GameModel> Games { get; set; }

        public DataModel _allGames;

        private GameModel _selectedGame;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _filter;

        public int AwayScore { get; set; }   
        public int HomeScore { get; set; }
        public string Status { get; set; }


        // Game Object fields
        public async void getGames()
        {
            _allGames =  await Repositories.GamesRepository.getGamesAsync();

            foreach(GameModel game in _allGames.Games)
            {
                Debug.WriteLine(game.Status.State);
                Debug.WriteLine(game.GoalsHomeTeam);
                Debug.WriteLine(game.GoalsAwayTeam);
                foreach (var goal in game.Goals)
                {
                    Debug.WriteLine(goal.GoalAsString);
                    Debug.WriteLine(goal.Team);
                }
                Games.Add(game);
            }
            /*var games = Repositories.GamesRepository.getGamesFromAPI().GetAwaiter().GetResult();

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }*/
        }
        public GameViewModel ()
        {
            Games = new ObservableCollection<GameModel>();

            try
            {
                getGames();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            // PerformFiltering();
        }

        public GameModel SelectedGame
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
                    Status = value.Status.State;
                    AwayScore = value.GoalsAwayTeam;
                    HomeScore = value.GoalsHomeTeam;

                    MainPage.VisitorScoreTextBlock.Text = AwayScore.ToString();
                    MainPage.StatusTextBlock.Text = Status;
                    MainPage.HomeScoreTextBlock.Text = HomeScore.ToString();
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Status"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AwayScore"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HomeScore"));
                
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
            var resultAway = _allGames.Games.Where(n => n.Teams.Home.Abbreviation.ToLowerInvariant()
                .Contains(lowerCaseFilter)).ToList();
            var resultHome = _allGames.Games.Where(n => n.Teams.Away.Abbreviation.ToLowerInvariant()
                .Contains(lowerCaseFilter)).ToList();


            //Get rid of the items that need to be filtered out
            var toRemoveAway = Games.Except(resultAway).ToList();

            foreach (var x in toRemoveAway)
            {
                Games.Remove(x);
            }

            //Get rid of the items that need to be filtered out
            var toRemoveHome = Games.Except(resultHome).ToList();

            foreach (var x in toRemoveHome)
            {
                Games.Remove(x);
            }

            //Add the new results in the correct order
            var resultCountAway = resultAway.Count;
            for (int i = 0; i < resultCountAway; i++)
            {
                var resultItem = resultAway[i];
                if (i + 1 > Games.Count || !Games[i].Equals(resultItem))
                {
                    Games.Insert(i, resultItem);
                }
            }

            //Add the new results in the correct order
            var resultCountHome = resultHome.Count;
            for (int i = 0; i < resultCountHome; i++)
            {
                var resultItem = resultHome[i];
                if (i + 1 > Games.Count || !Games[i].Equals(resultItem))
                {
                    Games.Insert(i, resultItem);
                }
            }
        }

        public async void DisplayVisitorStats()
        {
            VisitorStatsContentDialog visitorStats = new VisitorStatsContentDialog();
            ContentDialogResult result = await visitorStats.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                Debug.WriteLine("Clicked the visitor button");
            }
        }

        public async void DisplayHomeStats()
        {
            HomeStatsContentDialog homeStats = new HomeStatsContentDialog();
            ContentDialogResult result = await homeStats.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                Debug.WriteLine("Clicked the home button");
            }
        }
    }
}
