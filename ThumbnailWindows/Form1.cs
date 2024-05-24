using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Automation;
using System.Windows.Forms;

namespace ThumbnailWindows
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point Cursor_Point);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        [Flags()]
        public enum SetWindowPosFlags : uint
        {
            /// <summary>If the calling thread and the thread that owns the window are attached to different input queues,
            /// the system posts the request to the thread that owns the window. This prevents the calling thread from
            /// blocking its execution while other threads process the request.</summary>
            /// <remarks>SWP_ASYNCWINDOWPOS</remarks>
            AsynchronousWindowPosition = 0x4000,
            /// <summary>Prevents generation of the WM_SYNCPAINT message.</summary>
            /// <remarks>SWP_DEFERERASE</remarks>
            DeferErase = 0x2000,
            /// <summary>Draws a frame (defined in the window's class description) around the window.</summary>
            /// <remarks>SWP_DRAWFRAME</remarks>
            DrawFrame = 0x0020,
            /// <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to
            /// the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE
            /// is sent only when the window's size is being changed.</summary>
            /// <remarks>SWP_FRAMECHANGED</remarks>
            FrameChanged = 0x0020,
            /// <summary>Hides the window.</summary>
            /// <remarks>SWP_HIDEWINDOW</remarks>
            HideWindow = 0x0080,
            /// <summary>Does not activate the window. If this flag is not set, the window is activated and moved to the
            /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter
            /// parameter).</summary>
            /// <remarks>SWP_NOACTIVATE</remarks>
            DoNotActivate = 0x0010,
            /// <summary>Discards the entire contents of the client area. If this flag is not specified, the valid
            /// contents of the client area are saved and copied back into the client area after the window is sized or
            /// repositioned.</summary>
            /// <remarks>SWP_NOCOPYBITS</remarks>
            DoNotCopyBits = 0x0100,
            /// <summary>Retains the current position (ignores X and Y parameters).</summary>
            /// <remarks>SWP_NOMOVE</remarks>
            IgnoreMove = 0x0002,
            /// <summary>Does not change the owner window's position in the Z order.</summary>
            /// <remarks>SWP_NOOWNERZORDER</remarks>
            DoNotChangeOwnerZOrder = 0x0200,
            /// <summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to
            /// the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent
            /// window uncovered as a result of the window being moved. When this flag is set, the application must
            /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
            /// <remarks>SWP_NOREDRAW</remarks>
            DoNotRedraw = 0x0008,
            /// <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
            /// <remarks>SWP_NOREPOSITION</remarks>
            DoNotReposition = 0x0200,
            /// <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
            /// <remarks>SWP_NOSENDCHANGING</remarks>
            DoNotSendChangingEvent = 0x0400,
            /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
            /// <remarks>SWP_NOSIZE</remarks>
            IgnoreResize = 0x0001,
            /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
            /// <remarks>SWP_NOZORDER</remarks>
            IgnoreZOrder = 0x0004,
            /// <summary>Displays the window.</summary>
            /// <remarks>SWP_SHOWWINDOW</remarks>
            ShowWindow = 0x0040,
        }

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        //Declare variables
        List<String> Process_Names;
        bool Refresh_Thumbnails_Enabled;
        int Form_Width;
        int Form_Height;
        Timer Timer;

        public Form1()
        {
            //Set initial values
            Process_Names = new List<string>();
            Refresh_Thumbnails_Enabled = false;
            Form_Width = this.Width;
            Form_Height = this.Height;
            Timer = new Timer();
            Timer.Interval = (1000);

            //Initialize
            InitializeComponent();

            //Loop through each process
            foreach (Process Process in Process.GetProcesses())
            {
                //Validate the process has a UI
                if (Process.MainWindowHandle != IntPtr.Zero)
                {
                    //Add name to list
                    Process_Names.Add(Process.ProcessName);
                }
            }

            //Add distinct names to dropdown list
            foreach (String Process_Name in Process_Names.Distinct())
            {
                //Add name to dropdown list
                Combo_Box_Processes.Items.Add(Process_Name);
            }
            
            //Set events
            Button_Refresh.Click += Button_Refresh_Click;
            Button_Start.Click += Button_Start_Click;
            Button_Stop.Click += Button_Stop_Click;
            Button_Set.Click += Button_Set_Click;
            Button_Kill_All_Visible.Click += Button_Kill_All_Visible_Click;
            Button_Gather_All_Windows.Click += Button_Gather_All_Windows_Click;
            Timer.Tick += new EventHandler(Refresh_Thumbnails);

            //Start timer
            Timer.Start();
        }

        public void Button_Gather_All_Windows_Click(Object sender, EventArgs e)
        {
            //Declare variable
            Point Cursor_Point;

            //Set initial value
            GetCursorPos(out Cursor_Point);

            //Loop through each thumbnail in container
            foreach (Control Picture_Box in Panel_Thumbnails.Controls)
            {
                //Set window position
                SetWindowPos(Process.GetProcessById(Convert.ToInt32(Picture_Box.Name)).MainWindowHandle, IntPtr.Zero, Cursor_Point.X, Cursor_Point.Y, 0, 0, SetWindowPosFlags.DoNotChangeOwnerZOrder | SetWindowPosFlags.IgnoreResize);
            }
        }

        public void Button_Kill_All_Visible_Click(Object sender, EventArgs e)
        {
            //Loop through each thumbnail in container
            foreach (Control Picture_Box in Panel_Thumbnails.Controls)
            {
                //Kill process with given PID
                Process.GetProcessById(Convert.ToInt32(Picture_Box.Name)).Kill();
            }
        }

        public void Tool_Strip_Menu_Item_Click(object sender, EventArgs e)
        {
            //Declare variable
            int Process_ID;

            //Extract and assign process ID from drop down menu
            Process_ID = Convert.ToInt32((sender as ToolStripMenuItem).Text.Split(new string[] { "-" }, StringSplitOptions.None)[1]);

            //Kill selected process
            Process.GetProcessById(Process_ID).Kill();
        }

        public void Button_Set_Click(Object sender, EventArgs e)
        {
            //Stop timer
            Timer.Stop();

            //Reset timer with given refresh frequency
            Timer = new Timer();
            Timer.Interval = Convert.ToInt32(Numberic_Up_Down_Refresh_Frequency.Value);
            Timer.Tick += new EventHandler(Refresh_Thumbnails);

            //Start timer
            Timer.Start();
        }

        public bool Is_Process_Running(int ID)
        {
            //Return false
            try{Process.GetProcessById(ID);}catch(ArgumentException){return false;}

            //Return true
            return true;
        }

        public async void Refresh_Thumbnails(object sender, EventArgs e)
        {
            try
            {
                //Declare variable
                List<int> On_Screen_Process_IDs;

                //Set initial value
                On_Screen_Process_IDs = new List<int>();

                //Validate the windows width and height has not changed
                if (Form_Width != this.Width || Form_Height != this.Height)
                {
                    //Remove all thumbnails
                    Panel_Thumbnails.Controls.Clear();

                    //Update new width and height
                    Form_Width = this.Width;
                    Form_Height = this.Height;
                }

                //Loop through each control in the panel
                foreach (Control Picture_Box in Panel_Thumbnails.Controls)
                {
                    //Add process ID to list if visible/Reset if one is no longer running
                    if (Is_Process_Running(Convert.ToInt32(Picture_Box.Name)) == true)
                    {
                        //Add Process ID to list
                        On_Screen_Process_IDs.Add(Convert.ToInt32(((PictureBox)Picture_Box).Name));
                    }
                    else if (Is_Process_Running(Convert.ToInt32(Picture_Box.Name)) == false)
                    {
                        //Remove all thumbnails
                        Panel_Thumbnails.Controls.Clear();
                    }
                }               

                //Validate 
                if (Refresh_Thumbnails_Enabled == true)
                {
                    //Declare variables
                    PictureBox Picture_Box;
                    ContextMenuStrip Context_Menu_Strip;
                    ToolStripMenuItem Tool_Strip_Menu_Item;
                    int Max_Height;
                    int X;
                    int Y;                    

                    //Set initial values
                    X = 40;
                    Y = 20;
                    Max_Height = -1;

                    //Loop through each process that matches the requested name
                    foreach (Process Process in Process.GetProcessesByName(Combo_Box_Processes.Text))
                    {
                        //Update thumbnail image if already visible/Add new thumbnail image if not visible
                        if (On_Screen_Process_IDs.Contains(Process.Id) == true)
                        {
                            //Update image
                            ((PictureBox)Panel_Thumbnails.Controls.Find(Process.Id.ToString(), false)[0]).Image = WindowSnap.GetWindowSnap(Process.MainWindowHandle, true).Image;
                        }
                        else if (On_Screen_Process_IDs.Contains(Process.Id) == false)
                        {
                            //Set initial values
                            Picture_Box = new PictureBox();
                            Context_Menu_Strip = new ContextMenuStrip();
                            Tool_Strip_Menu_Item = new ToolStripMenuItem();

                            //Set name
                            Picture_Box.Name = Process.Id.ToString();

                            //Set events
                            Picture_Box.MouseHover += Picture_Box_MouseHover;
                            Picture_Box.MouseLeave += Picture_Box_MouseLeave;
                            Picture_Box.Click += Picture_Box_Click;
                            Tool_Strip_Menu_Item.Click += Tool_Strip_Menu_Item_Click;

                            //Set drop down option text
                            Tool_Strip_Menu_Item.Text = "Shutdown Process-" + Process.Id;                            

                            //Assign drop down option to menu
                            Context_Menu_Strip.Items.Add(Tool_Strip_Menu_Item);

                            //Set drop down menu
                            Picture_Box.ContextMenuStrip = Context_Menu_Strip;

                            //Set location
                            Picture_Box.Location = new Point(X, Y);

                            //Set size mode
                            Picture_Box.SizeMode = PictureBoxSizeMode.StretchImage;

                            //Set dimensions
                            Picture_Box.Width = 250;
                            Picture_Box.Height = 200;

                            //Set image
                            Picture_Box.Image = WindowSnap.GetWindowSnap(Process.MainWindowHandle, false).Image;

                            //Increment/Reset X,Y,Max Height for next thumbnail
                            X += Picture_Box.Width + 10;
                            Max_Height = Math.Max(Picture_Box.Height, Max_Height);

                            if (X > this.ClientSize.Width - 100)
                            {
                                X = 40;
                                Y += Max_Height + 20;
                            }

                            //Add thumbnail to panel
                            Panel_Thumbnails.Controls.Add(Picture_Box);
                            Panel_Thumbnails.Refresh();
                        }
                    }

                    //Update total window count
                    Button_Gather_All_Windows.Text = "Gather All Windows(" + Panel_Thumbnails.Controls.Count + ")";
                }

            }
            catch (Exception)
            {

            }
                 
        }

        private void Picture_Box_Click(object sender, EventArgs e)
        {
            //Declare variable
            Point Cursor_Point;

            //Set initial value
            GetCursorPos(out Cursor_Point);

            //Set window position
            SetWindowPos(Process.GetProcessById(Convert.ToInt32(((PictureBox)sender).Name)).MainWindowHandle, IntPtr.Zero, Cursor_Point.X, Cursor_Point.Y, 0, 0, SetWindowPosFlags.DoNotChangeOwnerZOrder | SetWindowPosFlags.IgnoreResize);                     
        }

        private void Picture_Box_MouseLeave(object sender, EventArgs e)
        {
            //Unfocus thumbnail
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }

        private void Picture_Box_MouseHover(object sender, EventArgs e)
        {
            //Focus thumbnail
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        public void Button_Refresh_Click(object sender, EventArgs e)
        {
            //Set initial value
            Process_Names = new List<string>();

            //Clear dropdown list
            Combo_Box_Processes.Items.Clear();

            //Loop through each process
            foreach (Process Process in Process.GetProcesses())
            {
                //Validate the process has a UI
                if (Process.MainWindowHandle != IntPtr.Zero)
                {
                    //Add name to list
                    Process_Names.Add(Process.ProcessName);
                }
            }

            //Add distinct names to dropdown list
            foreach (String Process_Name in Process_Names.Distinct())
            {
                //Add name to dropdown list
                Combo_Box_Processes.Items.Add(Process_Name);
            }
        }

        public void Button_Start_Click(object sender, EventArgs e)
        {
            //Enable
            Refresh_Thumbnails_Enabled = true;
        }

        public void Button_Stop_Click(object sender, EventArgs e)
        {
            //Disable
            Refresh_Thumbnails_Enabled = false;

            //Clear Thumbnails
            Panel_Thumbnails.Controls.Clear();

            //Reset total windows count
            Button_Gather_All_Windows.Text = "Gather All Windows";
        }

    }

}
