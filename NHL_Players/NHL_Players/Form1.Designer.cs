namespace NHL_Players
{
    partial class NHLForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.NHLDataView = new System.Windows.Forms.DataGridView();
            this.FieldLabel = new System.Windows.Forms.Label();
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.InsertFilter = new System.Windows.Forms.Button();
            this.FilterFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertOrder = new System.Windows.Forms.Button();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NHLDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateButton.Location = new System.Drawing.Point(764, 827);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(145, 146);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Run";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // NHLDataView
            // 
            this.NHLDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NHLDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NHLDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NHLDataView.Location = new System.Drawing.Point(915, 12);
            this.NHLDataView.Name = "NHLDataView";
            this.NHLDataView.RowTemplate.Height = 28;
            this.NHLDataView.Size = new System.Drawing.Size(947, 961);
            this.NHLDataView.TabIndex = 4;
            this.NHLDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NHLDataView_CellContentClick);
            // 
            // FieldLabel
            // 
            this.FieldLabel.AutoSize = true;
            this.FieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldLabel.Location = new System.Drawing.Point(13, 12);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(122, 32);
            this.FieldLabel.TabIndex = 5;
            this.FieldLabel.Text = "Property";
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorLabel.Location = new System.Drawing.Point(220, 12);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(61, 32);
            this.OperatorLabel.TabIndex = 6;
            this.OperatorLabel.Text = "Op.";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(347, 12);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(89, 32);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Value";
            // 
            // InsertFilter
            // 
            this.InsertFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertFilter.Location = new System.Drawing.Point(764, 47);
            this.InsertFilter.Name = "InsertFilter";
            this.InsertFilter.Size = new System.Drawing.Size(144, 51);
            this.InsertFilter.TabIndex = 10;
            this.InsertFilter.Text = "Add Filter";
            this.InsertFilter.UseVisualStyleBackColor = true;
            this.InsertFilter.Click += new System.EventHandler(this.InsertFilter_Click);
            // 
            // FilterFlowPanel
            // 
            this.FilterFlowPanel.AutoScroll = true;
            this.FilterFlowPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FilterFlowPanel.Location = new System.Drawing.Point(19, 47);
            this.FilterFlowPanel.Name = "FilterFlowPanel";
            this.FilterFlowPanel.Size = new System.Drawing.Size(739, 498);
            this.FilterFlowPanel.TabIndex = 12;
            this.FilterFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FilterFlowPanel_Paint);
            // 
            // OrderFlowPanel
            // 
            this.OrderFlowPanel.AutoScroll = true;
            this.OrderFlowPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OrderFlowPanel.Location = new System.Drawing.Point(19, 603);
            this.OrderFlowPanel.Name = "OrderFlowPanel";
            this.OrderFlowPanel.Size = new System.Drawing.Size(406, 370);
            this.OrderFlowPanel.TabIndex = 13;
            // 
            // InsertOrder
            // 
            this.InsertOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertOrder.Location = new System.Drawing.Point(431, 603);
            this.InsertOrder.Name = "InsertOrder";
            this.InsertOrder.Size = new System.Drawing.Size(144, 51);
            this.InsertOrder.TabIndex = 14;
            this.InsertOrder.Text = "Add Order";
            this.InsertOrder.UseVisualStyleBackColor = true;
            this.InsertOrder.Click += new System.EventHandler(this.InsertOrder_Click);
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderByLabel.Location = new System.Drawing.Point(13, 565);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(124, 32);
            this.OrderByLabel.TabIndex = 15;
            this.OrderByLabel.Text = "Order by";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Maroon;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetButton.Location = new System.Drawing.Point(764, 603);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(145, 146);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // NHLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 985);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OrderByLabel);
            this.Controls.Add(this.InsertOrder);
            this.Controls.Add(this.OrderFlowPanel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertFilter);
            this.Controls.Add(this.FilterFlowPanel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.OperatorLabel);
            this.Controls.Add(this.FieldLabel);
            this.Controls.Add(this.NHLDataView);
            this.Name = "NHLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHL Players";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHLDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView NHLDataView;
        private System.Windows.Forms.Label FieldLabel;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button InsertFilter;
        private System.Windows.Forms.FlowLayoutPanel FilterFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel OrderFlowPanel;
        private System.Windows.Forms.Button InsertOrder;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.Button ResetButton;
    }
}

