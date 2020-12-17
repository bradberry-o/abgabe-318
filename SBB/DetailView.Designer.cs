
namespace SBB
{
    partial class Detail
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
            this.DetailGroup = new System.Windows.Forms.GroupBox();
            this.arival_time_placerholder = new System.Windows.Forms.Label();
            this.deprautre_time_placerholder = new System.Windows.Forms.Label();
            this.destination_time_placerholder = new System.Windows.Forms.Label();
            this.deprautre_placerholder = new System.Windows.Forms.Label();
            this.arival_time_ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ltvConnections = new System.Windows.Forms.ListView();
            this.arrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departure_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DetailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailGroup
            // 
            this.DetailGroup.Controls.Add(this.arival_time_placerholder);
            this.DetailGroup.Controls.Add(this.deprautre_time_placerholder);
            this.DetailGroup.Controls.Add(this.destination_time_placerholder);
            this.DetailGroup.Controls.Add(this.deprautre_placerholder);
            this.DetailGroup.Controls.Add(this.arival_time_);
            this.DetailGroup.Controls.Add(this.label3);
            this.DetailGroup.Controls.Add(this.label2);
            this.DetailGroup.Controls.Add(this.label1);
            this.DetailGroup.Location = new System.Drawing.Point(24, 21);
            this.DetailGroup.Name = "DetailGroup";
            this.DetailGroup.Size = new System.Drawing.Size(649, 87);
            this.DetailGroup.TabIndex = 0;
            this.DetailGroup.TabStop = false;
            this.DetailGroup.Text = "Details";
            // 
            // arival_time_placerholder
            // 
            this.arival_time_placerholder.AutoSize = true;
            this.arival_time_placerholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arival_time_placerholder.Location = new System.Drawing.Point(434, 50);
            this.arival_time_placerholder.Name = "arival_time_placerholder";
            this.arival_time_placerholder.Size = new System.Drawing.Size(96, 16);
            this.arival_time_placerholder.TabIndex = 17;
            this.arival_time_placerholder.Text = "placerholder";
            // 
            // deprautre_time_placerholder
            // 
            this.deprautre_time_placerholder.AutoSize = true;
            this.deprautre_time_placerholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deprautre_time_placerholder.Location = new System.Drawing.Point(434, 26);
            this.deprautre_time_placerholder.Name = "deprautre_time_placerholder";
            this.deprautre_time_placerholder.Size = new System.Drawing.Size(96, 16);
            this.deprautre_time_placerholder.TabIndex = 16;
            this.deprautre_time_placerholder.Text = "placerholder";
            // 
            // destination_time_placerholder
            // 
            this.destination_time_placerholder.AutoSize = true;
            this.destination_time_placerholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_time_placerholder.Location = new System.Drawing.Point(142, 50);
            this.destination_time_placerholder.Name = "destination_time_placerholder";
            this.destination_time_placerholder.Size = new System.Drawing.Size(91, 16);
            this.destination_time_placerholder.TabIndex = 15;
            this.destination_time_placerholder.Text = "placeholder";
            // 
            // deprautre_placerholder
            // 
            this.deprautre_placerholder.AutoSize = true;
            this.deprautre_placerholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deprautre_placerholder.Location = new System.Drawing.Point(142, 27);
            this.deprautre_placerholder.Name = "deprautre_placerholder";
            this.deprautre_placerholder.Size = new System.Drawing.Size(91, 16);
            this.deprautre_placerholder.TabIndex = 14;
            this.deprautre_placerholder.Text = "placeholder";
            // 
            // arival_time_
            // 
            this.arival_time_.AutoSize = true;
            this.arival_time_.Location = new System.Drawing.Point(325, 52);
            this.arival_time_.Name = "arival_time_";
            this.arival_time_.Size = new System.Drawing.Size(92, 13);
            this.arival_time_.TabIndex = 3;
            this.arival_time_.Text = "Destination Time: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deprature Time: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deprature Station: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stations";
            // 
            // ltvConnections
            // 
            this.ltvConnections.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ltvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.arrivalTime,
            this.stationName,
            this.departure_time});
            this.ltvConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvConnections.FullRowSelect = true;
            this.ltvConnections.GridLines = true;
            this.ltvConnections.HideSelection = false;
            this.ltvConnections.Location = new System.Drawing.Point(51, 172);
            this.ltvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.ltvConnections.Name = "ltvConnections";
            this.ltvConnections.Size = new System.Drawing.Size(592, 520);
            this.ltvConnections.TabIndex = 13;
            this.ltvConnections.UseCompatibleStateImageBehavior = false;
            this.ltvConnections.View = System.Windows.Forms.View.Details;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Text = "Arrival Time";
            this.arrivalTime.Width = 161;
            // 
            // stationName
            // 
            this.stationName.Text = "station name";
            this.stationName.Width = 173;
            // 
            // departure_time
            // 
            this.departure_time.Text = "departure_time";
            this.departure_time.Width = 182;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Send per Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(352, 130);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(192, 20);
            this.EmailInput.TabIndex = 15;
            this.EmailInput.Text = "example@email.com";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ltvConnections);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetailGroup);
            this.Name = "Detail";
            this.Text = "Detail View";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.DetailGroup.ResumeLayout(false);
            this.DetailGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DetailGroup;
        private System.Windows.Forms.Label arival_time_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView ltvConnections;
        private System.Windows.Forms.ColumnHeader arrivalTime;
        private System.Windows.Forms.ColumnHeader stationName;
        private System.Windows.Forms.ColumnHeader departure_time;
        private System.Windows.Forms.Label arival_time_placerholder;
        private System.Windows.Forms.Label deprautre_time_placerholder;
        private System.Windows.Forms.Label destination_time_placerholder;
        private System.Windows.Forms.Label deprautre_placerholder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Button button1;
    }
}