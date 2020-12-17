
namespace SBB
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.searchBtn = new System.Windows.Forms.Button();
            this.dateTimePickerGB = new System.Windows.Forms.GroupBox();
            this.roundButtonArival = new System.Windows.Forms.RadioButton();
            this.roundButtonDeparture = new System.Windows.Forms.RadioButton();
            this.DateTimePickerChecker = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblDestinationLocation = new System.Windows.Forms.Label();
            this.startLocationInputCB = new System.Windows.Forms.ComboBox();
            this.destionationInputCB = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.viewResetBtn = new System.Windows.Forms.Button();
            this.mainViewLsv = new System.Windows.Forms.ListView();
            this.clmStartStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDestinationStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePickerGB.SuspendLayout();
            this.grbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(623, 156);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(208, 26);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "&Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePickerGB
            // 
            this.dateTimePickerGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerGB.Controls.Add(this.roundButtonArival);
            this.dateTimePickerGB.Controls.Add(this.roundButtonDeparture);
            this.dateTimePickerGB.Controls.Add(this.DateTimePickerChecker);
            this.dateTimePickerGB.Controls.Add(this.dateTimePicker);
            this.dateTimePickerGB.Location = new System.Drawing.Point(352, 102);
            this.dateTimePickerGB.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerGB.Name = "dateTimePickerGB";
            this.dateTimePickerGB.Padding = new System.Windows.Forms.Padding(2);
            this.dateTimePickerGB.Size = new System.Drawing.Size(255, 86);
            this.dateTimePickerGB.TabIndex = 6;
            this.dateTimePickerGB.TabStop = false;
            this.dateTimePickerGB.Text = "Time";
            // 
            // roundButtonArival
            // 
            this.roundButtonArival.AutoSize = true;
            this.roundButtonArival.Location = new System.Drawing.Point(96, 54);
            this.roundButtonArival.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonArival.Name = "roundButtonArival";
            this.roundButtonArival.Size = new System.Drawing.Size(54, 17);
            this.roundButtonArival.TabIndex = 5;
            this.roundButtonArival.Text = "Arrival";
            this.roundButtonArival.UseVisualStyleBackColor = true;
            // 
            // roundButtonDeparture
            // 
            this.roundButtonDeparture.AutoSize = true;
            this.roundButtonDeparture.Checked = true;
            this.roundButtonDeparture.Location = new System.Drawing.Point(9, 54);
            this.roundButtonDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonDeparture.Name = "roundButtonDeparture";
            this.roundButtonDeparture.Size = new System.Drawing.Size(72, 17);
            this.roundButtonDeparture.TabIndex = 4;
            this.roundButtonDeparture.TabStop = true;
            this.roundButtonDeparture.Text = "Departure";
            this.roundButtonDeparture.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerChecker
            // 
            this.DateTimePickerChecker.AutoSize = true;
            this.DateTimePickerChecker.Location = new System.Drawing.Point(9, 25);
            this.DateTimePickerChecker.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePickerChecker.Name = "DateTimePickerChecker";
            this.DateTimePickerChecker.Size = new System.Drawing.Size(78, 17);
            this.DateTimePickerChecker.TabIndex = 2;
            this.DateTimePickerChecker.Text = "&Datepicker";
            this.DateTimePickerChecker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DateTimePickerChecker.UseVisualStyleBackColor = true;
            this.DateTimePickerChecker.CheckStateChanged += new System.EventHandler(this.chbSpecifyTime_CheckStateChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CustomFormat = "HH:mm / yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(110, 25);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2020, 12, 17, 9, 4, 30, 0);
            // 
            // grbLocation
            // 
            this.grbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocation.Controls.Add(this.lblStartLocation);
            this.grbLocation.Controls.Add(this.lblDestinationLocation);
            this.grbLocation.Controls.Add(this.startLocationInputCB);
            this.grbLocation.Controls.Add(this.destionationInputCB);
            this.grbLocation.Location = new System.Drawing.Point(352, 11);
            this.grbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Padding = new System.Windows.Forms.Padding(2);
            this.grbLocation.Size = new System.Drawing.Size(490, 87);
            this.grbLocation.TabIndex = 5;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Destination";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.Location = new System.Drawing.Point(4, 26);
            this.lblStartLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(109, 14);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Start station:";
            // 
            // lblDestinationLocation
            // 
            this.lblDestinationLocation.Location = new System.Drawing.Point(4, 54);
            this.lblDestinationLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationLocation.Name = "lblDestinationLocation";
            this.lblDestinationLocation.Size = new System.Drawing.Size(122, 14);
            this.lblDestinationLocation.TabIndex = 0;
            this.lblDestinationLocation.Text = "Destinatinon staion:";
            // 
            // startLocationInputCB
            // 
            this.startLocationInputCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLocationInputCB.FormattingEnabled = true;
            this.startLocationInputCB.Location = new System.Drawing.Point(130, 26);
            this.startLocationInputCB.Margin = new System.Windows.Forms.Padding(2);
            this.startLocationInputCB.Name = "startLocationInputCB";
            this.startLocationInputCB.Size = new System.Drawing.Size(340, 21);
            this.startLocationInputCB.TabIndex = 0;
            this.startLocationInputCB.TextUpdate += new System.EventHandler(this.startLocationInput_TextUpdate);
            // 
            // destionationInputCB
            // 
            this.destionationInputCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destionationInputCB.FormattingEnabled = true;
            this.destionationInputCB.Location = new System.Drawing.Point(130, 51);
            this.destionationInputCB.Margin = new System.Windows.Forms.Padding(2);
            this.destionationInputCB.Name = "destionationInputCB";
            this.destionationInputCB.Size = new System.Drawing.Size(340, 21);
            this.destionationInputCB.TabIndex = 1;
            this.destionationInputCB.TextUpdate += new System.EventHandler(this.cmbDestinationLocation_TextUpdate);
            // 
            // Logo
            // 
            this.Logo.Image = global::SBB.Properties.Resources.SBB_Logo;
            this.Logo.Location = new System.Drawing.Point(18, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(307, 164);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // viewResetBtn
            // 
            this.viewResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewResetBtn.Location = new System.Drawing.Point(623, 118);
            this.viewResetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewResetBtn.Name = "viewResetBtn";
            this.viewResetBtn.Size = new System.Drawing.Size(208, 26);
            this.viewResetBtn.TabIndex = 11;
            this.viewResetBtn.Text = "reset entry";
            this.viewResetBtn.UseVisualStyleBackColor = true;
            this.viewResetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainViewLsv
            // 
            this.mainViewLsv.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.mainViewLsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainViewLsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStartStation,
            this.clmDepartureTime,
            this.clmDestinationStation,
            this.clmArrivalTime,
            this.clmDuration});
            this.mainViewLsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainViewLsv.FullRowSelect = true;
            this.mainViewLsv.GridLines = true;
            this.mainViewLsv.HideSelection = false;
            this.mainViewLsv.Location = new System.Drawing.Point(18, 218);
            this.mainViewLsv.Margin = new System.Windows.Forms.Padding(2);
            this.mainViewLsv.Name = "mainViewLsv";
            this.mainViewLsv.Size = new System.Drawing.Size(813, 399);
            this.mainViewLsv.TabIndex = 12;
            this.mainViewLsv.UseCompatibleStateImageBehavior = false;
            this.mainViewLsv.View = System.Windows.Forms.View.Details;
            this.mainViewLsv.SelectedIndexChanged += new System.EventHandler(this.ltvConnections_SelectedIndexChanged);
            // 
            // clmStartStation
            // 
            this.clmStartStation.Text = "Start Station";
            this.clmStartStation.Width = 150;
            // 
            // clmDepartureTime
            // 
            this.clmDepartureTime.Text = "Departure Time";
            this.clmDepartureTime.Width = 150;
            // 
            // clmDestinationStation
            // 
            this.clmDestinationStation.Text = "Destination Station";
            this.clmDestinationStation.Width = 150;
            // 
            // clmArrivalTime
            // 
            this.clmArrivalTime.Text = "Arrival Time";
            this.clmArrivalTime.Width = 150;
            // 
            // clmDuration
            // 
            this.clmDuration.Text = "Duration";
            this.clmDuration.Width = 150;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 663);
            this.Controls.Add(this.mainViewLsv);
            this.Controls.Add(this.viewResetBtn);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dateTimePickerGB);
            this.Controls.Add(this.grbLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Fahrplan ala ";
            this.dateTimePickerGB.ResumeLayout(false);
            this.dateTimePickerGB.PerformLayout();
            this.grbLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox dateTimePickerGB;
        private System.Windows.Forms.RadioButton roundButtonArival;
        private System.Windows.Forms.RadioButton roundButtonDeparture;
        private System.Windows.Forms.GroupBox grbLocation;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblDestinationLocation;
        private System.Windows.Forms.ComboBox startLocationInputCB;
        private System.Windows.Forms.ComboBox destionationInputCB;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button viewResetBtn;
        private System.Windows.Forms.ListView mainViewLsv;
        private System.Windows.Forms.ColumnHeader clmStartStation;
        private System.Windows.Forms.ColumnHeader clmDepartureTime;
        private System.Windows.Forms.ColumnHeader clmDestinationStation;
        private System.Windows.Forms.ColumnHeader clmArrivalTime;
        private System.Windows.Forms.ColumnHeader clmDuration;
        private System.Windows.Forms.CheckBox DateTimePickerChecker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}