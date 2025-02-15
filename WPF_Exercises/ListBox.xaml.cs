﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Exercises
{
    /// <summary>
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window
    {
        public ListBox()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            //matches.Add(new Match() { Team1 = "Barcellona", Score1 = 4, Score2 = 0, Team2 = "RealMadrid", Comprition = 85 }); 
            matches.Add(new Match("Barca", 4, 0, "Real", 85));
            lbMatches.ItemsSource = matches;
        }
    }
    public class Match
    {
        public string Team1 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team2 { get; set; }
        public int Comprition { get; set; }
        public Match(string team1, int score1, int score2, string team2, int comprition)
        {
            Team1 = team1;
            Score1 = score1;
            Score2 = score2;
            Team2 = team2;
            Comprition = comprition;
        }
    }
}
