namespace Airline_Res_System
{
    partial class Status
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
            this.Status_Grid = new System.Windows.Forms.DataGridView();
            this.Status_CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Status_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Status_Grid
            // 
            this.Status_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Status_Grid.Location = new System.Drawing.Point(0, -1);
            this.Status_Grid.Name = "Status_Grid";
            this.Status_Grid.Size = new System.Drawing.Size(748, 382);
            this.Status_Grid.TabIndex = 0;
            // 
            // Status_CloseBtn
            // 
            this.Status_CloseBtn.Location = new System.Drawing.Point(12, 387);
            this.Status_CloseBtn.Name = "Status_CloseBtn";
            this.Status_CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.Status_CloseBtn.TabIndex = 1;
            this.Status_CloseBtn.Text = "Close";
            this.Status_CloseBtn.UseVisualStyleBackColor = true;
            this.Status_CloseBtn.Click += new System.EventHandler(this.Status_CloseBtn_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 413);
            this.Controls.Add(this.Status_CloseBtn);
            this.Controls.Add(this.Status_Grid);
            this.Name = "Status";
            this.Text = "Status";
            ((System.ComponentModel.ISupportInitialize)(this.Status_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Status_Grid;
        private System.Windows.Forms.Button Status_CloseBtn;
    }
}