using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_ProjectF
{
    //here i have inherit the another class to pass the value 
    public class workingGame:GenreateRandom
    {
        int ary = 0;
        //this code is used to disable the 
        public Boolean work(Button btn){
            btn.Enabled = false;
            ary=array();
            return true;
            
        }
        //this code is used to trigger the game 
        public void triggerFire(int trigger,Button btn,Button btn2,int chance) {
            System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_ProjectF.Properties.Resources.sound);
            obj.Play();
            if (trigger < chance)
            {
                MessageBox.Show("You are save");
            }
            else if (trigger == ary)
            {
                MessageBox.Show("You loose the game ");
                btn.Enabled = false;
                btn2.Enabled = false;
            }
            else {
                MessageBox.Show("You didn't die ");
                btn.Enabled = false;
                btn2.Enabled = false;
            }

        }
    }
}
