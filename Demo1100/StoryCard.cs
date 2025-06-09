using Demo1100.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1100
{
    public partial class StoryCard : UserControl
    {
        public StoryCard()
        {
            InitializeComponent();
        }

        private void StoryCard_Load(object sender, EventArgs e)
        {

        }
        public void SetData(StoryDemo story)
        {
            label1.Text = Convert.ToString(story.Date_story);
            label2.Text = Convert.ToString(story.Count_story_prod);
        }
    }
}
