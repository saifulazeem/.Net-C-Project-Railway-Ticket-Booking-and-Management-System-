namespace Railways_Ticket_Reservation_System
{
    partial class update_trains
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
            this.dgv_train_details = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_train_details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_train_details
            // 
            this.dgv_train_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_train_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_train_details.Location = new System.Drawing.Point(12, 115);
            this.dgv_train_details.Name = "dgv_train_details";
            this.dgv_train_details.Size = new System.Drawing.Size(810, 237);
            this.dgv_train_details.TabIndex = 0;
            this.dgv_train_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_train_details_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modify train details here";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Location = new System.Drawing.Point(359, 385);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 40);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Save and Exit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(359, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_train_details);
            this.Name = "update_trains";
            this.Text = "update_trains";
            this.Load += new System.EventHandler(this.update_trains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_train_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_train_details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
    }
}