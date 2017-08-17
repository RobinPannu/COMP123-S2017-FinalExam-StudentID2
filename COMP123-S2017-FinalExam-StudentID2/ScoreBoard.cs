using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Robin Singh
 * Date: August 17,2017
 * StudentID: 300930741
 * Description: This is the ScoreBoard Class
 * Version:0.5 : cONVERT TimeTextBox.Text  to _time 
 */
namespace COMP123_S2017_FinalExam_StudentID2
{

    class ScoreBoard
    {
        //PRIVATE PROPERTIES (INSTANCE VARIABLES)
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;


        //PUBLIC PROPERTIES...

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
                this.ScoreTextBox.Text = Convert.ToString(this._score);
                this.FinalScoreTextBox.Text = Convert.ToString(this._score);
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = Convert.ToString(this._time);
            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }
        //CONSTRUCTOR
        /// <summary>
        /// This is the constructor class for ScoreBoard
        /// It takes scoreTextBox(TextBox), timeTextBox(TextBox), finalScoreTextBox(TextBox).
        /// </summary>
        /// <param name="ScoreTextBox"></param>
        /// <param name="TimeTextBox"></param>
        /// <param name="FinalScoreTextBox"></param>
        public ScoreBoard(TextBox ScoreTextBox, TextBox TimeTextBox, TextBox FinalScoreTextBox)
        {

        }

    }
     

}
