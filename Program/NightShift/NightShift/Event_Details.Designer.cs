namespace NightShift
{
    partial class Event_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event_Details));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEVDet = new System.Windows.Forms.DataGridView();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.dgvArtist = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEVDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(981, 620);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEVDet
            // 
            this.dgvEVDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEVDet.Location = new System.Drawing.Point(13, 290);
            this.dgvEVDet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEVDet.Name = "dgvEVDet";
            this.dgvEVDet.RowHeadersWidth = 51;
            this.dgvEVDet.RowTemplate.Height = 24;
            this.dgvEVDet.Size = new System.Drawing.Size(564, 159);
            this.dgvEVDet.TabIndex = 1;
            // 
            // dgvEvent
            // 
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Location = new System.Drawing.Point(13, 107);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.RowHeadersWidth = 51;
            this.dgvEvent.RowTemplate.Height = 24;
            this.dgvEvent.Size = new System.Drawing.Size(306, 150);
            this.dgvEvent.TabIndex = 3;
            // 
            // dgvArtist
            // 
            this.dgvArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtist.Location = new System.Drawing.Point(327, 107);
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.RowHeadersWidth = 51;
            this.dgvArtist.RowTemplate.Height = 24;
            this.dgvArtist.Size = new System.Drawing.Size(320, 150);
            this.dgvArtist.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Date of Event:";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(651, 63);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(308, 30);
            this.dtp1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add to Event Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(976, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacity Amount:";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(981, 63);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(100, 30);
            this.txtCap.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select entry to delete:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Click to Choose Event";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 45);
            this.button5.TabIndex = 14;
            this.button5.Text = "Click to Choose Artist";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Event_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvArtist);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.dgvEVDet);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Event_Details";
            this.Text = "Event_Details";
            this.Load += new System.EventHandler(this.Event_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEVDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEVDet;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.DataGridView dgvArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}