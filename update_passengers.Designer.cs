namespace Railways_Ticket_Reservation_System
{
    partial class update_passengers
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
            this.passengers_details = new System.Windows.Forms.Label();
            this.dgv_passengers_details = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_passengers_details)).BeginInit();
            this.SuspendLayout();
            // 
            // passengers_details
            // 
            this.passengers_details.AutoSize = true;
            this.passengers_details.Location = new System.Drawing.Point(378, 38);
            this.passengers_details.Name = "passengers_details";
            this.passengers_details.Size = new System.Drawing.Size(90, 13);
            this.passengers_details.TabIndex = 0;
            this.passengers_details.Text = "Passenger details";
            // 
            // dgv_passengers_details
            // 
            this.dgv_passengers_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_passengers_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_passengers_details.Location = new System.Drawing.Point(12, 95);
            this.dgv_passengers_details.Name = "dgv_passengers_details";
            this.dgv_passengers_details.Size = new System.Drawing.Size(821, 243);
            this.dgv_passengers_details.TabIndex = 1;
            this.dgv_passengers_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_passengers_details_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(381, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save and exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(381, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // update_passengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_passengers_details);
            this.Controls.Add(this.passengers_details);
            this.Name = "update_passengers";
            this.Text = "update_passengers";
            this.Load += new System.EventHandler(this.update_passengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_passengers_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passengers_details;
        private System.Windows.Forms.DataGridView dgv_passengers_details;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}