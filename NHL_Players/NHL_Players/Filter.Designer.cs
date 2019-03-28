namespace NHL_Players
{
    partial class Filter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FilterValueTextBox = new System.Windows.Forms.TextBox();
            this.FilterOperatorBox = new System.Windows.Forms.ComboBox();
            this.FilterPropertyBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FilterValueTextBox
            // 
            this.FilterValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterValueTextBox.Location = new System.Drawing.Point(343, 6);
            this.FilterValueTextBox.Name = "FilterValueTextBox";
            this.FilterValueTextBox.Size = new System.Drawing.Size(325, 41);
            this.FilterValueTextBox.TabIndex = 11;
            this.FilterValueTextBox.TextChanged += new System.EventHandler(this.FilterValueTextBox_TextChanged_1);
            // 
            // FilterOperatorBox
            // 
            this.FilterOperatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterOperatorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterOperatorBox.FormattingEnabled = true;
            this.FilterOperatorBox.Location = new System.Drawing.Point(216, 5);
            this.FilterOperatorBox.Name = "FilterOperatorBox";
            this.FilterOperatorBox.Size = new System.Drawing.Size(121, 40);
            this.FilterOperatorBox.TabIndex = 10;
            this.FilterOperatorBox.SelectedIndexChanged += new System.EventHandler(this.FilterOperatorBox_SelectedIndexChanged);
            // 
            // FilterPropertyBox
            // 
            this.FilterPropertyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterPropertyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterPropertyBox.FormattingEnabled = true;
            this.FilterPropertyBox.Location = new System.Drawing.Point(2, 5);
            this.FilterPropertyBox.Name = "FilterPropertyBox";
            this.FilterPropertyBox.Size = new System.Drawing.Size(208, 40);
            this.FilterPropertyBox.TabIndex = 9;
            this.FilterPropertyBox.SelectedIndexChanged += new System.EventHandler(this.FilterPropertyBox_SelectedIndexChanged);
            this.FilterPropertyBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterValueTextBox);
            this.Controls.Add(this.FilterOperatorBox);
            this.Controls.Add(this.FilterPropertyBox);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(676, 55);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox FilterValueTextBox;
        private System.Windows.Forms.ComboBox FilterOperatorBox;
        private System.Windows.Forms.ComboBox FilterPropertyBox;
    }
}
