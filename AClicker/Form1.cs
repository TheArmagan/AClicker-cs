using LowLevelInput.Hooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AClicker
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static bool IsWaitingForTriggerChange = false;
        public static bool ShouldClick = false;
        public static VirtualKeyCode TriggerCode = (VirtualKeyCode)13;
        public static int TargetCPS = 1;
        public static int _CPS = 1;
        public static MouseEventFlags buttonDown = MouseEventFlags.LEFTDOWN;
        public static MouseEventFlags buttonUp = MouseEventFlags.LEFTUP;
        public static Timer cpsChangeTimer = new Timer();
        public static Random rnd = new Random();
        public static InputManager inputManager = new InputManager(false);
        public static IInterruptable lastTimeout = null;
        public MainForm()
        {
            InitializeComponent();

            inputManager.OnKeyboardEvent += InputManager_OnKeyboardEvent;
            inputManager.OnMouseEvent += InputManager_OnMouseEvent;

            cpsChangeTimer.Tick += CpsChangeTimer_Tick;

          
            cpsChangeTimer.Start();
            ClickLoop();
            UpdateValues();
        }

        private void ClickLoop()
        {
            if (!ShouldClick)
            {
                lastTimeout = TimerHelper.SetTimeout(1, ClickLoop);
                return;
            }
            new Task(() =>
            {
                for (int i = 0; i < MultiplierInput.Value; i++)
                {
                    mouse_event((uint)buttonDown, 0, 0, 0, 0);
                    mouse_event((uint)buttonUp, 0, 0, 0, 0);
                }
            }).Start();

            lastTimeout = TimerHelper.SetTimeout(1000 / TargetCPS, ClickLoop);
        }

        private void CpsChangeTimer_Tick(object sender, EventArgs e)
        {
            TargetCPS = rnd.Next((int)CpsMinInput.Value, (int)CpsMaxInput.Value);
            UpdateValues();
        }

        private void InputManager_OnKeyboardEvent(VirtualKeyCode key, KeyState state)
        {
            if (IsWaitingForTriggerChange)
            {
                TriggerCode = key;
                ShouldClick = false;
                IsWaitingForTriggerChange = false;
                Invoke(new Action(() => { UpdateValues(); }));
                return;
            }

            try
            {
                Invoke(new Action(() => { Toggle(key, state); }));
            }
            catch { };
        }

        private void InputManager_OnMouseEvent(VirtualKeyCode key, KeyState state, int x, int y)
        {
            if (IsWaitingForTriggerChange)
            {
                TriggerCode = key;
                ShouldClick = false;
                IsWaitingForTriggerChange = false;
                Invoke(new Action(() => { UpdateValues(); }));
                return;
            }

            try
            {
                Invoke(new Action(() => { Toggle(key, state); }));
            } catch { };
        }

        private void Toggle(VirtualKeyCode key, KeyState state)
        {
            if (TriggerCode != key) return;
            if (state != KeyState.Up) return;

            ShouldClick = !ShouldClick;
        }

        private void UpdateValues()
        {
            CpsMaxInput.Minimum = CpsMinInput.Value;
            TriggerLink.Text = $"{Enum.GetName(typeof(VirtualKeyCode), TriggerCode)} ({(int)TriggerCode})";
            TargetCpsLabel.Text = "Hedef CPS: " + TargetCPS * (int)MultiplierInput.Value;
            cpsChangeTimer.Interval = (int)ChangeIntervalInput.Value;
        }

        private void ChangeIntervalInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void CpsMinInput_ValueChanged(object sender, EventArgs e)
        {
            lastTimeout?.Stop();
            ClickLoop();

            UpdateValues();
        }

        private void CpsMaxInput_ValueChanged(object sender, EventArgs e)
        {
            lastTimeout?.Stop();
            ClickLoop();

            UpdateValues();
        }

        private void ButtonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ButtonComboBox.Text)
            {
                case "Sol":
                    {
                        buttonDown = MouseEventFlags.LEFTDOWN;
                        buttonUp = MouseEventFlags.LEFTUP;
                        break;
                    }
                case "Sağ":
                    {
                        buttonDown = MouseEventFlags.RIGHTDOWN;
                        buttonUp = MouseEventFlags.RIGHTUP;
                        break;
                    }
                case "Orta":
                    {
                        buttonDown = MouseEventFlags.MIDDLEDOWN;
                        buttonUp = MouseEventFlags.MIDDLEUP;
                        break;
                    }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inputManager.Dispose();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            ShouldClick = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TheArmagan");
        }

        private void TriggerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShouldClick = false;
            IsWaitingForTriggerChange = true;
        }
    }

    public class TimerInterrupter : IInterruptable
    {
        private readonly System.Timers.Timer _timer;

        public TimerInterrupter(System.Timers.Timer timer)
        {
            if (timer == null) throw new ArgumentNullException(nameof(timer));
            _timer = timer;
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }

    public interface IInterruptable
    {
        void Stop();
    }

    public static class TimerHelper
    {
        public static IInterruptable SetInterval(int interval, Action function)
        {
            return StartTimer(interval, function, true);
        }

        public static IInterruptable SetTimeout(int interval, Action function)
        {
            return StartTimer(interval, function, false);
        }

        private static IInterruptable StartTimer(int interval, Action function, bool autoReset)
        {
            Action functionCopy = (Action)function.Clone();
            System.Timers.Timer timer = new System.Timers.Timer { Interval = interval, AutoReset = autoReset };
            timer.Elapsed += (sender, e) => functionCopy();
            timer.Start();

            return new TimerInterrupter(timer);
        }
    }
}
