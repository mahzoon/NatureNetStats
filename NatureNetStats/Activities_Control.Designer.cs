namespace NatureNetStats
{
    partial class Activities_Control
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
            this.tableLayoutPanel_activities = new System.Windows.Forms.TableLayoutPanel();
            this.panel_whole = new System.Windows.Forms.Panel();
            this.panel_whole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_activities
            // 
            this.tableLayoutPanel_activities.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_activities.ColumnCount = 1;
            this.tableLayoutPanel_activities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_activities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_activities.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_activities.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_activities.Name = "tableLayoutPanel_activities";
            this.tableLayoutPanel_activities.RowCount = 1;
            this.tableLayoutPanel_activities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_activities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel_activities.Size = new System.Drawing.Size(510, 141);
            this.tableLayoutPanel_activities.TabIndex = 0;
            // 
            // panel_whole
            // 
            this.panel_whole.AutoScroll = true;
            this.panel_whole.Controls.Add(this.tableLayoutPanel_activities);
            this.panel_whole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_whole.Location = new System.Drawing.Point(0, 0);
            this.panel_whole.Name = "panel_whole";
            this.panel_whole.Size = new System.Drawing.Size(510, 405);
            this.panel_whole.TabIndex = 1;
            // 
            // Activities_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_whole);
            this.Name = "Activities_Control";
            this.Size = new System.Drawing.Size(510, 405);
            this.panel_whole.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_activities;
        private System.Windows.Forms.Panel panel_whole;
    }
}
