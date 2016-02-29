using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDataBase_prac2._2
{
    public partial class Form1 : Form
    {

        Manager movieManager;

        public Form1()
        {
            InitializeComponent();

            movieManager = new Manager();
        }

        private void Print(KeyValuePair<int, Movie> movie)
        {
            
            lb_PrintAllDisplay.Items.Add("---------------------------------------------------------------------------------------");
            lb_PrintAllDisplay.Items.Add(movie.Key.ToString());
            lb_PrintAllDisplay.Items.Add(movie.ToString());
        }

        private void Print(int year, String movieInfo)
        {
            
            lb_PrintAllDisplay.Items.Add("---------------------------------------------------------------------------------------");
            lb_PrintAllDisplay.Items.Add(Convert.ToString(year));
            lb_PrintAllDisplay.Items.Add(movieInfo);
        }

        private void FeedbackMesage(String key, String Message)
        {
            MessageBox.Show(key.ToString() + Message);
        }        

        private void btn_PrintAll_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, Movie> currentMovie in movieManager.getMovies())
            {
                Print(currentMovie);
            }
        }

        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            //get the text from the text boxes
            try
            {
                int year = Convert.ToInt32(txt_AddMovieYear.Text);
                String title = txt_AddMovieTitle.Text;
                String director = txt_AddMovieDirector.Text;

                movieManager.AddMovie(year, title, director);
                
            }
            catch (FormatException)
            {
                FeedbackMesage("", " please provide valid input for all fields");
            }            
            
        }

        private void btn_SearchMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt32(txt_SearchYear.Text);

                if (movieManager.getMovies().ContainsKey(key))
                {
                    Movie selectedMovie = movieManager.getMovie(key);
                    Print(selectedMovie.Year, selectedMovie.ToString());
                }
                else
                    FeedbackMesage(txt_SearchYear.Text, " could not be found");
            }
            catch(FormatException)
            {
                FeedbackMesage("", " please provide valid input for all fields");
            }
            
        }

        private void btn_DeleteMovie_Click(object sender, EventArgs e)
        {

            try
            {
                int key = Convert.ToInt32(txt_DeleteYear.Text);

                if (movieManager.getMovies().ContainsKey(key))
                {
                    movieManager.DeleteMovie(key);
                    FeedbackMesage(txt_DeleteYear.Text, " successfully deleted");
                }
                else
                {
                    FeedbackMesage(txt_DeleteYear.Text, " could not be found");
                }
            }
            catch
            {
                FeedbackMesage("", " please provide valid input for all fields");
            }
            
        }


    }
}
