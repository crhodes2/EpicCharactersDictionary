using System;
using System.Data.Sql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EpicCharactersDictionaryWPF.Models;

namespace EpicCharactersDictionaryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {

        public DataSet CharacterModel { get; set; }
        public DataSet StoryModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            UpdateStories();
            UpdateCharacters();

        }

        private void create_char_button(object sender, RoutedEventArgs e)
        {
            frmCharacter newCharacter = new frmCharacter();
            Hide();
            newCharacter.Show();

        }

        private void create_story_button(object sender, RoutedEventArgs e)
        {


        }

        private void go_story_button(object sender, RoutedEventArgs e)
        {

        }

        private void go_char_button(object sender, RoutedEventArgs e)
        {
            if(charactersList.Text == "-- A-Z --")
            {
                DataAccess db = new DataAccess();
            }
        }

        private void UpdateStories()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=EpicCharacterDB;Integrated Security=True"))
                {
                    con.Open();
                    SqlDataAdapter StoryAdapter = new SqlDataAdapter("SELECT * FROM dbo.StoryModel", con);
                    DataSet ds = new DataSet();
                    StoryAdapter.Fill(ds, "s");

                    storyList.ItemsSource = ds.Tables["s"].DefaultView;
                    storyList.DisplayMemberPath = "StoryTitle";
                    storyList.SelectedValuePath = "StoryTitle";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateCharacters()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=EpicCharacterDB;Integrated Security=True"))
                {
                    con.Open();
                    SqlDataAdapter ProjectTableTableAdapter = new SqlDataAdapter("SELECT * FROM dbo.CharacterModel", con);
                    DataSet ds = new DataSet();
                    string FirstName = "FirstName ";
                    string LastName = "LastName";
                    string FullName = $"{FirstName} {LastName}";
                    ProjectTableTableAdapter.Fill(ds, "t");

                    charactersList.ItemsSource = ds.Tables["t"].DefaultView;
                    charactersList.DisplayMemberPath = FirstName;
                    charactersList.SelectedValuePath = FirstName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CharactersList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            UpdateCharacters();
        }

        private void StoryList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            UpdateStories();
        }
    }
}
