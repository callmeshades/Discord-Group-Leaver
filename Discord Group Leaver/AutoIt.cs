using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace Discord_Group_Leaver
{
    class AutoIt
    {
        private AutoItX3 auto;

        public void CreateAutoIt()
        {
            auto = new AutoItX3();
        }

        public AutoItX3 GetAutoIt()
        {
            return auto;
        }

        public void FocusOnDiscord()
        {
            try
            {
                auto.WinActivate("[CLASS:Chrome_WidgetWin_1]", "");
                auto.WinMove("[CLASS:Chrome_WidgetWin_1]", "", 0, 0, 940, 500);
                System.Threading.Thread.Sleep(500);
                auto.MouseMove(308, 441, 1);
                auto.MouseClick("LEFT", 308, 441, 1, 1);
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("Could not find the window, please try again!");
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void LeaveChatOrGroup()
        {
            auto.MouseMove(283, 416, 1);
            System.Threading.Thread.Sleep(500);
            auto.MouseClick("LEFT", 283, 416, 1, 1);
            System.Threading.Thread.Sleep(1000);
            auto.MouseClick("LEFT", 611, 313, 1, 1);
            System.Threading.Thread.Sleep(600);
        }

    }
}
