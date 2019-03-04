﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void buttonHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hg = new FrmHastaGiris();
            hg.Show();
            this.Hide();
        }

        private void buttonDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris dg = new FrmDoktorGiris();
            dg.Show();
            this.Hide();
        }

        private void buttonSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sg = new FrmSekreterGiris();
            sg.Show();
            this.Hide();
        }
    }
}
