namespace Railways_Ticket_Reservation_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.chk_oneway = new System.Windows.Forms.CheckBox();
            this.chk_round = new System.Windows.Forms.CheckBox();
            this.cbx_from_city = new System.Windows.Forms.ComboBox();
            this.cbx_to_city = new System.Windows.Forms.ComboBox();
            this.Dept_dt_pick = new System.Windows.Forms.DateTimePicker();
            this.Return_dt_pick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Date";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(306, 214);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 32);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chk_oneway
            // 
            this.chk_oneway.AutoSize = true;
            this.chk_oneway.Location = new System.Drawing.Point(95, 28);
            this.chk_oneway.Name = "chk_oneway";
            this.chk_oneway.Size = new System.Drawing.Size(71, 17);
            this.chk_oneway.TabIndex = 9;
            this.chk_oneway.Text = "One Way";
            this.chk_oneway.UseVisualStyleBackColor = true;
            this.chk_oneway.CheckedChanged += new System.EventHandler(this.chk_oneway_CheckedChanged);
            // 
            // chk_round
            // 
            this.chk_round.AutoSize = true;
            this.chk_round.Location = new System.Drawing.Point(197, 28);
            this.chk_round.Name = "chk_round";
            this.chk_round.Size = new System.Drawing.Size(79, 17);
            this.chk_round.TabIndex = 10;
            this.chk_round.Text = "Round Trip";
            this.chk_round.UseVisualStyleBackColor = true;
            this.chk_round.CheckedChanged += new System.EventHandler(this.chk_round_CheckedChanged);
            // 
            // cbx_from_city
            // 
            this.cbx_from_city.FormattingEnabled = true;
            this.cbx_from_city.Location = new System.Drawing.Point(95, 68);
            this.cbx_from_city.Name = "cbx_from_city";
            this.cbx_from_city.Size = new System.Drawing.Size(121, 21);
            this.cbx_from_city.TabIndex = 11;
            // 
            // cbx_to_city
            // 
            this.cbx_to_city.FormattingEnabled = true;
            this.cbx_to_city.Location = new System.Drawing.Point(268, 67);
            this.cbx_to_city.Name = "cbx_to_city";
            this.cbx_to_city.Size = new System.Drawing.Size(121, 21);
            this.cbx_to_city.TabIndex = 12;
            // 
            // Dept_dt_pick
            // 
            this.Dept_dt_pick.Location = new System.Drawing.Point(152, 133);
            this.Dept_dt_pick.Name = "Dept_dt_pick";
            this.Dept_dt_pick.Size = new System.Drawing.Size(200, 20);
            this.Dept_dt_pick.TabIndex = 13;
            // 
            // Return_dt_pick
            // 
            this.Return_dt_pick.Location = new System.Drawing.Point(420, 133);
            this.Return_dt_pick.Name = "Return_dt_pick";
            this.Return_dt_pick.Size = new System.Drawing.Size(200, 20);
            this.Return_dt_pick.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Depature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Return:";
            // 
            // cbx_class
            // 
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(455, 68);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(121, 21);
            this.cbx_class.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Class";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(306, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_class);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Return_dt_pick);
            this.Controls.Add(this.Dept_dt_pick);
            this.Controls.Add(this.cbx_to_city);
            this.Controls.Add(this.cbx_from_city);
            this.Controls.Add(this.chk_round);
            this.Controls.Add(this.chk_oneway);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox chk_oneway;
        private System.Windows.Forms.CheckBox chk_round;
        private System.Windows.Forms.ComboBox cbx_from_city;
        private System.Windows.Forms.ComboBox cbx_to_city;
        private System.Windows.Forms.DateTimePicker Dept_dt_pick;
        private System.Windows.Forms.DateTimePicker Return_dt_pick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

