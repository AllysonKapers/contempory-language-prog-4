using System.Runtime.CompilerServices;

namespace IslandGame
{
    partial class IslandGame
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
        private void InitalizeComponent()
        {
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ControlBox = new System.Windows.Forms.GroupBox();
            this.GameMap = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.RowTxtBox = new System.Windows.Forms.TextBox();
            this.ColumnTxtBox = new System.Windows.Forms.TextBox();
            this.GamePlayBox = new System.Windows.Forms.GroupBox();
            this.WinLabel = new System.Windows.Forms.Label();
            this.MapBox = new System.Windows.Forms.GroupBox();

            //InstructionsLabel
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Courier New", 10);
            this.InstructionsLabel.Location = new System.Drawing.Point(0, 0);
            this.InstructionsLabel.Size = new System.Drawing.Size(880, 459);
            this.InstructionsLabel.TabIndex = 2;
            this.InstructionsLabel.Text = "Welcome to the Island Game!\r\n" +
                                          "To Play:\r\n" +
                                          "-Enter two numbers representing a row and column on the map\r\n" +
                                          " to guess where the island is\r\n" +
                                          "-Press the Guess button and the map will update with \r\n" +
                                          " feedback about your guess\r\n" +
                                          "-The map will display the following characters:\r\n" +
                                          "   -'S', 'N'. 'E', and 'W' will appear on the map telling you \r\n" +
                                          "    which cardinal direction the island is from your guess\r\n" +
                                          "   -'R' and 'C' will appear on the map if you've guessed the \r\n" +
                                          "    correct Row or Column the island is in\r\n" +
                                          "   -'I' will appear on the map when you've guessed the \r\n" +
                                          "    islands location correctly\r\n" +
                                          "-The size of the map is 20x20, but you can change this! To do \r\n" +
                                          " so, press the settings button and enter new map dimensions.\r\n" +
                                          " (Tip: the maximum map size is 20x20)\r\n";

            //StartButton
            this.StartButton.Name = "StartButton";
            this.StartButton.Text = "Start";
            this.StartButton.Font = new System.Drawing.Font("Courier New", 10);
            this.StartButton.Location = new System.Drawing.Point(740, 608);
            this.StartButton.Size = new System.Drawing.Size(126, 38);
            this.StartButton.TabIndex = 0;

            //SettingsButton
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Font = new System.Drawing.Font("Courier New", 10);
            this.SettingsButton.Location = new System.Drawing.Point(740, 653);
            this.SettingsButton.Size = new System.Drawing.Size(126, 38);
            this.SettingsButton.TabIndex = 1;

            //CloseButton
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Text = "Close";
            this.CloseButton.Font = new System.Drawing.Font("Courier New", 10);
            this.CloseButton.Location = new System.Drawing.Point(740, 700);
            this.CloseButton.Size = new System.Drawing.Size(126, 38);
            this.CloseButton.TabIndex = 3;

            //ControlBox
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Text = "Menu:";
            this.ControlBox.Font = new System.Drawing.Font("Courier New", 10);
            this.ControlBox.Location = new System.Drawing.Point(740, 571);
            this.ControlBox.Size = new System.Drawing.Size(126, 161);
            this.ControlBox.TabIndex = 5;
            this.ControlBox.Controls.Add(this.SettingsButton);
            this.ControlBox.Controls.Add(this.StartButton);
            this.ControlBox.Controls.Add(this.CloseButton);

            //RowLabel
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Font = new System.Drawing.Font("Courier New", 10);
            this.RowLabel.Location = new System.Drawing.Point(111, 256);
            this.RowLabel.Size = new System.Drawing.Size(130, 22);
            this.RowLabel.TabIndex = 6;
            this.RowLabel.Text = "Row Guess:";

            //ColumnLabel
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Font = new System.Drawing.Font("Courier New", 10);
            this.ColumnLabel.Location = new System.Drawing.Point(111, 298);
            this.ColumnLabel.Size = new System.Drawing.Size(166, 22);
            this.ColumnLabel.TabIndex = 7;
            this.ColumnLabel.Text = "Column Guess:";

            //RowTxtBox
            this.RowTxtBox.Name = "RowTxtBox";
            this.RowTxtBox.Location = new System.Drawing.Point(275, 256);
            this.RowTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RowTxtBox.TabIndex = 8;

            //ColumnTxtBox
            this.RowTxtBox.Name = "RowTxtBox";
            this.RowTxtBox.Location = new System.Drawing.Point(275, 256);
            this.RowTxtBox.Size = new System.Drawing.Size(100, 20);
            this.RowTxtBox.TabIndex = 9;

            //GamePlayBox
            this.GamePlayBox.Name = "GamePlayBox";
            this.GamePlayBox.Text = "Controls:";
            this.GamePlayBox.Font = new System.Drawing.Font("Courier New", 12);
            this.GamePlayBox.Location = new System.Drawing.Point(100, 220);
            this.GamePlayBox.Size = new System.Drawing.Size(293, 187);
            this.GamePlayBox.TabIndex = 5;
            this.GamePlayBox.Controls.Add(this.RowLabel);
            this.GamePlayBox.Controls.Add(this.RowTxtBox);
            this.GamePlayBox.Controls.Add(this.ColumnLabel);
            this.GamePlayBox.Controls.Add(this.ColumnTxtBox);

            //GuessButton
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Text = "Guess";
            this.GuessButton.Font = new System.Drawing.Font("Courier New", 10);
            this.GuessButton.Location = new System.Drawing.Point(64,123);
            this.GuessButton.Size = new System.Drawing.Size(152,40);
            this.GuessButton.TabIndex = 0;

            //WinLabel
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Font = new System.Drawing.Font("Courier New", 26);
            this.WinLabel.Location = new System.Drawing.Point(106, 459);
            this.WinLabel.Size = new System.Drawing.Size(686, 168);
            this.WinLabel.TabIndex = 11;
            this.WinLabel.Text = "Congrats! You found the island!";

            //GameMap
            this.GameMap.Name = "WinLabel";
            this.GameMap.Font = new System.Drawing.Font("Courier New", 8);
            this.GameMap.Location = new System.Drawing.Point(106, 459);
            this.GameMap.Size = new System.Drawing.Size(400, 400);
            this.GameMap.TabIndex = 4;
            this.GameMap.Text = "";

            //MapBox
            this.MapBox.Name = "MapBox";
            this.MapBox.Text = "Map:";
            this.MapBox.Font = new System.Drawing.Font("Courier New", 12);
            this.MapBox.Location = new System.Drawing.Point(397,107);
            this.MapBox.Size = new System.Drawing.Size(435, 456);
            this.MapBox.TabIndex = 12;
            this.MapBox.Controls.Add(this.GameMap);

            //IslandGame
            this.Name = "IslandGame";
            this.Text = "Island Game";
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.GamePlayBox);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.InstructionsLabel);
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            this.GamePlayBox.ResumeLayout(false);
            this.GamePlayBox.PerformLayout();
            this.GameMap.ResumeLayout(false);
            this.GameMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label GameMap;
        private System.Windows.Forms.GroupBox ControlBox;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.TextBox RowTxtBox;
        private System.Windows.Forms.TextBox ColumnTxtBox;
        private System.Windows.Forms.GroupBox GamePlayBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.GroupBox MapBox;
    }   
   
}
