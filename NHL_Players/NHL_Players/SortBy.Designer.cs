namespace NHL_Players
{
    partial class SortBy
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
            this.PropFilterBox = new System.Windows.Forms.ComboBox();
            this.PropFilterOrder = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PropFilterBox
            // 
            this.PropFilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropFilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropFilterBox.FormattingEnabled = true;
            this.PropFilterBox.Location = new System.Drawing.Point(4, 4);
            this.PropFilterBox.Name = "PropFilterBox";
            this.PropFilterBox.Size = new System.Drawing.Size(208, 40);
            this.PropFilterBox.TabIndex = 0;
            // 
            // PropFilterOrder
            // 
            this.PropFilterOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropFilterOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropFilterOrder.FormattingEnabled = true;
            this.PropFilterOrder.Location = new System.Drawing.Point(218, 4);
            this.PropFilterOrder.Name = "PropFilterOrder";
            this.PropFilterOrder.Size = new System.Drawing.Size(121, 40);
            this.PropFilterOrder.TabIndex = 1;
            // 
            // OrderByFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PropFilterOrder);
            this.Controls.Add(this.PropFilterBox);
            this.Name = "OrderByFilter";
            this.Size = new System.Drawing.Size(344, 55);
            this.Load += new System.EventHandler(this.OrderByFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PropFilterBox;
        private System.Windows.Forms.ComboBox PropFilterOrder;
    }
}
