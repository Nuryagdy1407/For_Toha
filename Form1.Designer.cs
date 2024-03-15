namespace Brain_Ring
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Team_1Label = new System.Windows.Forms.Label();
            this.team1_Points = new System.Windows.Forms.Label();
            this.team_1UP = new System.Windows.Forms.PictureBox();
            this.team_1DOWN = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Team2_Points = new System.Windows.Forms.Label();
            this.team_2UP = new System.Windows.Forms.PictureBox();
            this.Team_2Label = new System.Windows.Forms.Label();
            this.team_2DOWN = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team_1UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team_1DOWN)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team_2UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team_2DOWN)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 362);
            this.panel3.TabIndex = 0;
            // 
            // Team_1Label
            // 
            this.Team_1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Team_1Label.Font = new System.Drawing.Font("Times New Roman", 42F, System.Drawing.FontStyle.Bold);
            this.Team_1Label.Location = new System.Drawing.Point(0, 0);
            this.Team_1Label.Margin = new System.Windows.Forms.Padding(0);
            this.Team_1Label.Name = "Team_1Label";
            this.Team_1Label.Size = new System.Drawing.Size(322, 362);
            this.Team_1Label.TabIndex = 0;
            this.Team_1Label.Text = "Team 1";
            this.Team_1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_Points
            // 
            this.team1_Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team1_Points.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.team1_Points.Location = new System.Drawing.Point(0, 120);
            this.team1_Points.Margin = new System.Windows.Forms.Padding(0);
            this.team1_Points.Name = "team1_Points";
            this.team1_Points.Size = new System.Drawing.Size(323, 120);
            this.team1_Points.TabIndex = 0;
            this.team1_Points.Text = "10";
            this.team1_Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team_1UP
            // 
            this.team_1UP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team_1UP.Image = global::Brain_Ring.Properties.Resources.new_Up;
            this.team_1UP.Location = new System.Drawing.Point(0, 0);
            this.team_1UP.Margin = new System.Windows.Forms.Padding(0);
            this.team_1UP.Name = "team_1UP";
            this.team_1UP.Size = new System.Drawing.Size(323, 120);
            this.team_1UP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.team_1UP.TabIndex = 1;
            this.team_1UP.TabStop = false;
            // 
            // team_1DOWN
            // 
            this.team_1DOWN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team_1DOWN.Image = global::Brain_Ring.Properties.Resources.new_Down;
            this.team_1DOWN.Location = new System.Drawing.Point(0, 240);
            this.team_1DOWN.Margin = new System.Windows.Forms.Padding(0);
            this.team_1DOWN.Name = "team_1DOWN";
            this.team_1DOWN.Size = new System.Drawing.Size(323, 122);
            this.team_1DOWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.team_1DOWN.TabIndex = 1;
            this.team_1DOWN.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.tableLayoutPanel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(645, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(645, 362);
            this.panel4.TabIndex = 1;
            // 
            // Team2_Points
            // 
            this.Team2_Points.Cursor = System.Windows.Forms.Cursors.Default;
            this.Team2_Points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Team2_Points.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold);
            this.Team2_Points.Location = new System.Drawing.Point(0, 118);
            this.Team2_Points.Margin = new System.Windows.Forms.Padding(0);
            this.Team2_Points.Name = "Team2_Points";
            this.Team2_Points.Size = new System.Drawing.Size(317, 118);
            this.Team2_Points.TabIndex = 2;
            this.Team2_Points.Text = "10";
            this.Team2_Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team_2UP
            // 
            this.team_2UP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team_2UP.Image = global::Brain_Ring.Properties.Resources.new_Up;
            this.team_2UP.Location = new System.Drawing.Point(0, 0);
            this.team_2UP.Margin = new System.Windows.Forms.Padding(0);
            this.team_2UP.Name = "team_2UP";
            this.team_2UP.Size = new System.Drawing.Size(317, 118);
            this.team_2UP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.team_2UP.TabIndex = 1;
            this.team_2UP.TabStop = false;
            // 
            // Team_2Label
            // 
            this.Team_2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Team_2Label.Font = new System.Drawing.Font("Times New Roman", 42F, System.Drawing.FontStyle.Bold);
            this.Team_2Label.Location = new System.Drawing.Point(0, 0);
            this.Team_2Label.Margin = new System.Windows.Forms.Padding(0);
            this.Team_2Label.Name = "Team_2Label";
            this.Team_2Label.Size = new System.Drawing.Size(322, 362);
            this.Team_2Label.TabIndex = 3;
            this.Team_2Label.Text = "Team 2";
            this.Team_2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team_2DOWN
            // 
            this.team_2DOWN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.team_2DOWN.Image = global::Brain_Ring.Properties.Resources.new_Down;
            this.team_2DOWN.Location = new System.Drawing.Point(0, 236);
            this.team_2DOWN.Margin = new System.Windows.Forms.Padding(0);
            this.team_2DOWN.Name = "team_2DOWN";
            this.team_2DOWN.Size = new System.Drawing.Size(317, 120);
            this.team_2DOWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.team_2DOWN.TabIndex = 1;
            this.team_2DOWN.TabStop = false;
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLabel.Font = new System.Drawing.Font("Times New Roman", 42F, System.Drawing.FontStyle.Bold);
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1290, 362);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Main text goes here!";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1290, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = " Data from Arduino";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 362);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 362);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1290, 362);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1290, 724);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Team_1Label, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(645, 362);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.team_1UP, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.team_1DOWN, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.team1_Points, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(322, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(323, 362);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.Team_2Label, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(645, 362);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.team_2UP, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.team_2DOWN, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.Team2_Points, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(325, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(317, 356);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1290, 724);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 480);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brain Ring";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.team_1UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team_1DOWN)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.team_2UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team_2DOWN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox team_1DOWN;
        private System.Windows.Forms.PictureBox team_1UP;
        private System.Windows.Forms.Label team1_Points;
        private System.Windows.Forms.Label Team_1Label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox team_2DOWN;
        private System.Windows.Forms.Label Team_2Label;
        private System.Windows.Forms.PictureBox team_2UP;
        private System.Windows.Forms.Label Team2_Points;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

