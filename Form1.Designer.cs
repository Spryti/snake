namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Title = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewScoreHistory = new System.Windows.Forms.DataGridView();
            this.labelScoreHistory = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(229, 48);
            this.Title.TabIndex = 0;
            this.Title.Text = "Snake Game";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(271, 9);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(67, 22);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Speed";
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(275, 34);
            this.speedBar.Maximum = 100;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(134, 45);
            this.speedBar.TabIndex = 2;
            this.speedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedBar.Value = 50;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Black;
            this.gamePanel.Location = new System.Drawing.Point(20, 85);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(570, 450);
            this.gamePanel.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(430, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 22);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(434, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 20);
            this.nameBox.TabIndex = 5;
            this.nameBox.Text = "Guest";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.dataGridViewScoreHistory);
            this.panel2.Controls.Add(this.labelScoreHistory);
            this.panel2.Controls.Add(this.scoreLabel);
            this.panel2.Controls.Add(this.labelScore);
            this.panel2.Location = new System.Drawing.Point(602, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 450);
            this.panel2.TabIndex = 6;
            // 
            // dataGridViewScoreHistory
            // 
            this.dataGridViewScoreHistory.AllowUserToAddRows = false;
            this.dataGridViewScoreHistory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewScoreHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScoreHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScoreHistory.Location = new System.Drawing.Point(15, 116);
            this.dataGridViewScoreHistory.Name = "dataGridViewScoreHistory";
            this.dataGridViewScoreHistory.RowHeadersVisible = false;
            this.dataGridViewScoreHistory.Size = new System.Drawing.Size(288, 315);
            this.dataGridViewScoreHistory.TabIndex = 3;
            // 
            // labelScoreHistory
            // 
            this.labelScoreHistory.AutoSize = true;
            this.labelScoreHistory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreHistory.Location = new System.Drawing.Point(130, 75);
            this.labelScoreHistory.Name = "labelScoreHistory";
            this.labelScoreHistory.Size = new System.Drawing.Size(124, 22);
            this.labelScoreHistory.TabIndex = 2;
            this.labelScoreHistory.Text = "Score History";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(128, 19);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(106, 36);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(25, 19);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(106, 36);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(602, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 45);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(736, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(113, 45);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop Game";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(945, 557);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.DataGridView dataGridViewScoreHistory;
        private System.Windows.Forms.Label labelScoreHistory;
        private System.Windows.Forms.Timer timer1;
    }
}

