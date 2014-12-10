namespace Airline_Res_System
{
    partial class Quote
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
            this.Quote_QuoteLbl = new System.Windows.Forms.Label();
            this.Quote_Quote = new System.Windows.Forms.TextBox();
            this.Quote_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quote_QuoteLbl
            // 
            this.Quote_QuoteLbl.AutoSize = true;
            this.Quote_QuoteLbl.Location = new System.Drawing.Point(12, 30);
            this.Quote_QuoteLbl.Name = "Quote_QuoteLbl";
            this.Quote_QuoteLbl.Size = new System.Drawing.Size(58, 13);
            this.Quote_QuoteLbl.TabIndex = 0;
            this.Quote_QuoteLbl.Text = "Total Price";
            // 
            // Quote_Quote
            // 
            this.Quote_Quote.Location = new System.Drawing.Point(95, 27);
            this.Quote_Quote.Name = "Quote_Quote";
            this.Quote_Quote.Size = new System.Drawing.Size(100, 20);
            this.Quote_Quote.TabIndex = 1;
            // 
            // Quote_Close
            // 
            this.Quote_Close.Location = new System.Drawing.Point(214, 27);
            this.Quote_Close.Name = "Quote_Close";
            this.Quote_Close.Size = new System.Drawing.Size(75, 23);
            this.Quote_Close.TabIndex = 2;
            this.Quote_Close.Text = "Close";
            this.Quote_Close.UseVisualStyleBackColor = true;
            this.Quote_Close.Click += new System.EventHandler(this.Quote_Close_Click);
            // 
            // Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 75);
            this.Controls.Add(this.Quote_Close);
            this.Controls.Add(this.Quote_Quote);
            this.Controls.Add(this.Quote_QuoteLbl);
            this.Name = "Quote";
            this.Text = "Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Quote_QuoteLbl;
        private System.Windows.Forms.TextBox Quote_Quote;
        private System.Windows.Forms.Button Quote_Close;

    }
}