namespace Airline_Res_System
{
    partial class Schedule
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
            this.Schedule_Grid = new System.Windows.Forms.DataGridView();
            this.Schedule_FareSelect = new System.Windows.Forms.Button();
            this.Schedule_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Schedule_Grid
            // 
            this.Schedule_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schedule_Grid.Location = new System.Drawing.Point(2, -1);
            this.Schedule_Grid.Name = "Schedule_Grid";
            this.Schedule_Grid.Size = new System.Drawing.Size(710, 451);
            this.Schedule_Grid.TabIndex = 0;
            this.Schedule_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schedule_Grid_CellClick);
            // 
            // Schedule_FareSelect
            // 
            this.Schedule_FareSelect.Enabled = false;
            this.Schedule_FareSelect.Location = new System.Drawing.Point(718, 124);
            this.Schedule_FareSelect.Name = "Schedule_FareSelect";
            this.Schedule_FareSelect.Size = new System.Drawing.Size(75, 23);
            this.Schedule_FareSelect.TabIndex = 1;
            this.Schedule_FareSelect.Text = "Choose Schedule";
            this.Schedule_FareSelect.UseVisualStyleBackColor = true;
            // 
            // Schedule_Close
            // 
            this.Schedule_Close.Location = new System.Drawing.Point(718, 190);
            this.Schedule_Close.Name = "Schedule_Close";
            this.Schedule_Close.Size = new System.Drawing.Size(75, 23);
            this.Schedule_Close.TabIndex = 2;
            this.Schedule_Close.Text = "Close";
            this.Schedule_Close.UseVisualStyleBackColor = true;
            this.Schedule_Close.Click += new System.EventHandler(this.Schedule_Close_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.Schedule_Close);
            this.Controls.Add(this.Schedule_FareSelect);
            this.Controls.Add(this.Schedule_Grid);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Schedule_Grid;
        private System.Windows.Forms.Button Schedule_FareSelect;
        private System.Windows.Forms.Button Schedule_Close;
    }
}