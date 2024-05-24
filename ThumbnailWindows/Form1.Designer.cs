
namespace ThumbnailWindows
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Options_Left = new System.Windows.Forms.Panel();
            this.Button_Set = new System.Windows.Forms.Button();
            this.Label_Refresh_Frequency = new System.Windows.Forms.Label();
            this.Numberic_Up_Down_Refresh_Frequency = new System.Windows.Forms.NumericUpDown();
            this.Label_Process_Name = new System.Windows.Forms.Label();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.Combo_Box_Processes = new System.Windows.Forms.ComboBox();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Panel_Thumbnails = new System.Windows.Forms.Panel();
            this.Panel_Options_Right = new System.Windows.Forms.Panel();
            this.Button_Kill_All_Visible = new System.Windows.Forms.Button();
            this.Button_Gather_All_Windows = new System.Windows.Forms.Button();
            this.Label_Border_Bottom = new System.Windows.Forms.Label();
            this.Label_Border_Top = new System.Windows.Forms.Label();
            this.Panel_Options_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numberic_Up_Down_Refresh_Frequency)).BeginInit();
            this.Panel_Options_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Options_Left
            // 
            this.Panel_Options_Left.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Options_Left.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Options_Left.Controls.Add(this.Button_Set);
            this.Panel_Options_Left.Controls.Add(this.Label_Refresh_Frequency);
            this.Panel_Options_Left.Controls.Add(this.Numberic_Up_Down_Refresh_Frequency);
            this.Panel_Options_Left.Controls.Add(this.Label_Process_Name);
            this.Panel_Options_Left.Controls.Add(this.Button_Refresh);
            this.Panel_Options_Left.Controls.Add(this.Combo_Box_Processes);
            this.Panel_Options_Left.Location = new System.Drawing.Point(12, 18);
            this.Panel_Options_Left.Name = "Panel_Options_Left";
            this.Panel_Options_Left.Size = new System.Drawing.Size(312, 126);
            this.Panel_Options_Left.TabIndex = 0;
            // 
            // Button_Set
            // 
            this.Button_Set.BackColor = System.Drawing.Color.LawnGreen;
            this.Button_Set.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Set.Location = new System.Drawing.Point(137, 92);
            this.Button_Set.Name = "Button_Set";
            this.Button_Set.Size = new System.Drawing.Size(84, 34);
            this.Button_Set.TabIndex = 8;
            this.Button_Set.Text = "Set";
            this.Button_Set.UseVisualStyleBackColor = false;
            // 
            // Label_Refresh_Frequency
            // 
            this.Label_Refresh_Frequency.AutoSize = true;
            this.Label_Refresh_Frequency.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Refresh_Frequency.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Refresh_Frequency.Location = new System.Drawing.Point(3, 71);
            this.Label_Refresh_Frequency.Name = "Label_Refresh_Frequency";
            this.Label_Refresh_Frequency.Size = new System.Drawing.Size(266, 18);
            this.Label_Refresh_Frequency.TabIndex = 7;
            this.Label_Refresh_Frequency.Text = "Refresh Frequency(1000 = 1/s)";
            // 
            // Numberic_Up_Down_Refresh_Frequency
            // 
            this.Numberic_Up_Down_Refresh_Frequency.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberic_Up_Down_Refresh_Frequency.Location = new System.Drawing.Point(5, 98);
            this.Numberic_Up_Down_Refresh_Frequency.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Numberic_Up_Down_Refresh_Frequency.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Numberic_Up_Down_Refresh_Frequency.Name = "Numberic_Up_Down_Refresh_Frequency";
            this.Numberic_Up_Down_Refresh_Frequency.Size = new System.Drawing.Size(126, 25);
            this.Numberic_Up_Down_Refresh_Frequency.TabIndex = 3;
            this.Numberic_Up_Down_Refresh_Frequency.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Label_Process_Name
            // 
            this.Label_Process_Name.AutoSize = true;
            this.Label_Process_Name.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Process_Name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Process_Name.Location = new System.Drawing.Point(3, 2);
            this.Label_Process_Name.Name = "Label_Process_Name";
            this.Label_Process_Name.Size = new System.Drawing.Size(129, 18);
            this.Label_Process_Name.TabIndex = 6;
            this.Label_Process_Name.Text = "Process Name";
            // 
            // Button_Refresh
            // 
            this.Button_Refresh.BackColor = System.Drawing.Color.Orange;
            this.Button_Refresh.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Refresh.Location = new System.Drawing.Point(215, 18);
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.Size = new System.Drawing.Size(84, 34);
            this.Button_Refresh.TabIndex = 4;
            this.Button_Refresh.Text = "Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = false;
            // 
            // Combo_Box_Processes
            // 
            this.Combo_Box_Processes.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Box_Processes.FormattingEnabled = true;
            this.Combo_Box_Processes.Location = new System.Drawing.Point(3, 23);
            this.Combo_Box_Processes.Name = "Combo_Box_Processes";
            this.Combo_Box_Processes.Size = new System.Drawing.Size(206, 26);
            this.Combo_Box_Processes.TabIndex = 3;
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.LawnGreen;
            this.Button_Start.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start.ForeColor = System.Drawing.Color.Black;
            this.Button_Start.Location = new System.Drawing.Point(100, 89);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(84, 34);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            // 
            // Button_Stop
            // 
            this.Button_Stop.BackColor = System.Drawing.Color.Red;
            this.Button_Stop.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Stop.Location = new System.Drawing.Point(190, 89);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(84, 34);
            this.Button_Stop.TabIndex = 2;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = false;
            // 
            // Panel_Thumbnails
            // 
            this.Panel_Thumbnails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Thumbnails.AutoScroll = true;
            this.Panel_Thumbnails.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Thumbnails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Thumbnails.Location = new System.Drawing.Point(12, 194);
            this.Panel_Thumbnails.Name = "Panel_Thumbnails";
            this.Panel_Thumbnails.Size = new System.Drawing.Size(587, 170);
            this.Panel_Thumbnails.TabIndex = 1;
            // 
            // Panel_Options_Right
            // 
            this.Panel_Options_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Options_Right.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Options_Right.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Options_Right.Controls.Add(this.Button_Kill_All_Visible);
            this.Panel_Options_Right.Controls.Add(this.Button_Stop);
            this.Panel_Options_Right.Controls.Add(this.Button_Start);
            this.Panel_Options_Right.Location = new System.Drawing.Point(322, 18);
            this.Panel_Options_Right.Name = "Panel_Options_Right";
            this.Panel_Options_Right.Size = new System.Drawing.Size(277, 126);
            this.Panel_Options_Right.TabIndex = 5;
            // 
            // Button_Kill_All_Visible
            // 
            this.Button_Kill_All_Visible.BackColor = System.Drawing.Color.Orange;
            this.Button_Kill_All_Visible.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Kill_All_Visible.Location = new System.Drawing.Point(100, 18);
            this.Button_Kill_All_Visible.Name = "Button_Kill_All_Visible";
            this.Button_Kill_All_Visible.Size = new System.Drawing.Size(174, 34);
            this.Button_Kill_All_Visible.TabIndex = 3;
            this.Button_Kill_All_Visible.Text = "Kill All Visible";
            this.Button_Kill_All_Visible.UseVisualStyleBackColor = false;
            // 
            // Button_Gather_All_Windows
            // 
            this.Button_Gather_All_Windows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Gather_All_Windows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Gather_All_Windows.BackColor = System.Drawing.Color.Orange;
            this.Button_Gather_All_Windows.Font = new System.Drawing.Font("Orbitron", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Gather_All_Windows.Location = new System.Drawing.Point(185, 154);
            this.Button_Gather_All_Windows.Name = "Button_Gather_All_Windows";
            this.Button_Gather_All_Windows.Size = new System.Drawing.Size(241, 34);
            this.Button_Gather_All_Windows.TabIndex = 4;
            this.Button_Gather_All_Windows.Text = "Gather All Windows";
            this.Button_Gather_All_Windows.UseVisualStyleBackColor = false;
            // 
            // Label_Border_Bottom
            // 
            this.Label_Border_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Border_Bottom.BackColor = System.Drawing.Color.DarkGray;
            this.Label_Border_Bottom.Location = new System.Drawing.Point(12, 147);
            this.Label_Border_Bottom.Name = "Label_Border_Bottom";
            this.Label_Border_Bottom.Size = new System.Drawing.Size(587, 1);
            this.Label_Border_Bottom.TabIndex = 6;
            // 
            // Label_Border_Top
            // 
            this.Label_Border_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Border_Top.BackColor = System.Drawing.Color.DarkGray;
            this.Label_Border_Top.Location = new System.Drawing.Point(12, 16);
            this.Label_Border_Top.Name = "Label_Border_Top";
            this.Label_Border_Top.Size = new System.Drawing.Size(587, 1);
            this.Label_Border_Top.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 376);
            this.Controls.Add(this.Label_Border_Top);
            this.Controls.Add(this.Label_Border_Bottom);
            this.Controls.Add(this.Button_Gather_All_Windows);
            this.Controls.Add(this.Panel_Options_Right);
            this.Controls.Add(this.Panel_Thumbnails);
            this.Controls.Add(this.Panel_Options_Left);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(627, 415);
            this.Name = "Form1";
            this.Text = "ThumnailWindows";
            this.Panel_Options_Left.ResumeLayout(false);
            this.Panel_Options_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numberic_Up_Down_Refresh_Frequency)).EndInit();
            this.Panel_Options_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Options_Left;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.ComboBox Combo_Box_Processes;
        private System.Windows.Forms.Panel Panel_Thumbnails;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Panel Panel_Options_Right;
        private System.Windows.Forms.Label Label_Process_Name;
        private System.Windows.Forms.Label Label_Refresh_Frequency;
        private System.Windows.Forms.NumericUpDown Numberic_Up_Down_Refresh_Frequency;
        private System.Windows.Forms.Button Button_Set;
        private System.Windows.Forms.Button Button_Kill_All_Visible;
        private System.Windows.Forms.Button Button_Gather_All_Windows;
        private System.Windows.Forms.Label Label_Border_Bottom;
        private System.Windows.Forms.Label Label_Border_Top;
    }
}

