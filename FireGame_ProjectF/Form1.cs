using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_ProjectF
{
    public partial class Form1 : Form
    {
        workingGame workingGame = new workingGame();
        int trigger = 0;
        int trigger2 = 0;
        //this method is used to disable the button 
        public void btnoption() {
            load_fireGamebtn.Enabled = false;
            spin_fireGamebtn.Enabled = false;
            fire_fireGamebtn.Enabled = false;
            fire_away_fireGamebtn.Enabled = false;
            restart_fireGamebtn.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
            //call the method to disable the button 
            btnoption();
            pbShelf.Image = FireGame_ProjectF.Properties.Resources.start_gm;
        }

        private void Exit_fireGamebtn_Click(object sender, EventArgs e)
        {
            //this code is used to exit from the application 
            this.Close();
        }

        private void restart_fireGamebtn_Click(object sender, EventArgs e)
        {
            //this code is used to restart the app so thus we can play again
            Application.Restart();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_fireGamebtn_Click(object sender, EventArgs e)
        {
            if (workingGame.work(start_fireGamebtn)) {
                //if the conidition is true then
                load_fireGamebtn.Enabled = true;
                pbShelf.Image = FireGame_ProjectF.Properties.Resources.load_gm;
            }
        }

        private void load_fireGamebtn_Click(object sender, EventArgs e)
        {
            if (workingGame.work(load_fireGamebtn)) {
                spin_fireGamebtn.Enabled = true;
                pbShelf.Image = FireGame_ProjectF.Properties.Resources.spin_gm;
            }
        }

        private void spin_fireGamebtn_Click(object sender, EventArgs e)
        {
            if (workingGame.work(spin_fireGamebtn)) {
                fire_fireGamebtn.Enabled = true;
                fire_away_fireGamebtn.Enabled = true;
                pbShelf.Image = FireGame_ProjectF.Properties.Resources.fire_way_gm;
            }
        }

        private void fire_fireGamebtn_Click(object sender, EventArgs e)
        {
            trigger++;
            workingGame.triggerFire(trigger, fire_fireGamebtn, fire_away_fireGamebtn,4);
            restart_fireGamebtn.Enabled = true;
        }

        private void fire_away_fireGamebtn_Click(object sender, EventArgs e)
        {

            trigger2++;
            workingGame.triggerFire(trigger, fire_fireGamebtn, fire_away_fireGamebtn, 2);
            restart_fireGamebtn.Enabled = true;
        }
    }
}
