namespace NatureNetStats
{
    partial class ActivityItem
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
            this.label_activity_text = new System.Windows.Forms.Label();
            this.label_activity = new System.Windows.Forms.Label();
            this.label_desc_text = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.dataGridView_contributions = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contributions)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_activity_text
            // 
            this.label_activity_text.AutoSize = true;
            this.label_activity_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_activity_text.Location = new System.Drawing.Point(3, 5);
            this.label_activity_text.Name = "label_activity_text";
            this.label_activity_text.Size = new System.Drawing.Size(65, 19);
            this.label_activity_text.TabIndex = 0;
            this.label_activity_text.Text = "Activity:";
            // 
            // label_activity
            // 
            this.label_activity.AutoSize = true;
            this.label_activity.Location = new System.Drawing.Point(74, 8);
            this.label_activity.Name = "label_activity";
            this.label_activity.Size = new System.Drawing.Size(42, 15);
            this.label_activity.TabIndex = 1;
            this.label_activity.Text = "label1";
            // 
            // label_desc_text
            // 
            this.label_desc_text.AutoSize = true;
            this.label_desc_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desc_text.Location = new System.Drawing.Point(3, 0);
            this.label_desc_text.Name = "label_desc_text";
            this.label_desc_text.Size = new System.Drawing.Size(90, 19);
            this.label_desc_text.TabIndex = 0;
            this.label_desc_text.Text = "Description:";
            // 
            // label_desc
            // 
            this.label_desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_desc.Location = new System.Drawing.Point(90, 3);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(388, 36);
            this.label_desc.TabIndex = 1;
            this.label_desc.Text = "label1";
            // 
            // dataGridView_contributions
            // 
            this.dataGridView_contributions.AllowUserToAddRows = false;
            this.dataGridView_contributions.AllowUserToDeleteRows = false;
            this.dataGridView_contributions.AllowUserToOrderColumns = true;
            this.dataGridView_contributions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_contributions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_contributions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_contributions.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_contributions.Name = "dataGridView_contributions";
            this.dataGridView_contributions.ReadOnly = true;
            this.dataGridView_contributions.Size = new System.Drawing.Size(481, 516);
            this.dataGridView_contributions.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 597);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_activity_text);
            this.panel1.Controls.Add(this.label_activity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 24);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_desc_text);
            this.panel2.Controls.Add(this.label_desc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 39);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dataGridView_contributions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 516);
            this.panel3.TabIndex = 2;
            // 
            // ActivityItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ActivityItem";
            this.Size = new System.Drawing.Size(487, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_contributions)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_activity_text;
        private System.Windows.Forms.Label label_activity;
        private System.Windows.Forms.Label label_desc_text;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.DataGridView dataGridView_contributions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
