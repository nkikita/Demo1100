using Demo1100.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class StoryForm : Form
    {
        ApplictionDbContext _context;
        public int _partId;
        public StoryForm(ApplictionDbContext context, int partId)
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            _context = context;
            _partId = partId;
        }
        public async Task<List<StoryDemo>> LoadFromDb()
        {
            return await _context.Story
                .Where(s => s.Id_part_story == _partId)
                .ToListAsync();
        }

        public async Task RefereshData()
        {
            flowLayoutPanel1.Controls.Clear();
            var data = await LoadFromDb();
            foreach (var item in data)
            {
                var card = new StoryCard();
                card.SetData(item);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private async void StoryForm_Load(object sender, EventArgs e)
        {
            await RefereshData();
        }
    }
}
