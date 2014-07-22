namespace NatureNetStats
{
    partial class DesignIdeasControl
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
            this.splitContainer_whole = new System.Windows.Forms.SplitContainer();
            this.dataGridView_designideas = new System.Windows.Forms.DataGridView();
            this.dataGridView_comments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_whole)).BeginInit();
            this.splitContainer_whole.Panel1.SuspendLayout();
            this.splitContainer_whole.Panel2.SuspendLayout();
            this.splitContainer_whole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_designideas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_comments)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_whole
            // 
            this.splitContainer_whole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_whole.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_whole.Name = "splitContainer_whole";
            this.splitContainer_whole.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_whole.Panel1
            // 
            this.splitContainer_whole.Panel1.Controls.Add(this.dataGridView_designideas);
            // 
            // splitContainer_whole.Panel2
            // 
            this.splitContainer_whole.Panel2.Controls.Add(this.dataGridView_comments);
            this.splitContainer_whole.Size = new System.Drawing.Size(430, 356);
            this.splitContainer_whole.SplitterDistance = 220;
            this.splitContainer_whole.TabIndex = 0;
            // 
            // dataGridView_designideas
            // 
            this.dataGridView_designideas.AllowUserToAddRows = false;
            this.dataGridView_designideas.AllowUserToDeleteRows = false;
            this.dataGridView_designideas.AllowUserToOrderColumns = true;
            this.dataGridView_designideas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_designideas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_designideas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_designideas.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_designideas.Name = "dataGridView_designideas";
            this.dataGridView_designideas.ReadOnly = true;
            this.dataGridView_designideas.Size = new System.Drawing.Size(430, 220);
            this.dataGridView_designideas.TabIndex = 0;
            // 
            // dataGridView_comments
            // 
            this.dataGridView_comments.AllowUserToAddRows = false;
            this.dataGridView_comments.AllowUserToDeleteRows = false;
            this.dataGridView_comments.AllowUserToOrderColumns = true;
            this.dataGridView_comments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_comments.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_comments.Name = "dataGridView_comments";
            this.dataGridView_comments.ReadOnly = true;
            this.dataGridView_comments.Size = new System.Drawing.Size(430, 132);
            this.dataGridView_comments.TabIndex = 0;
            // 
            // DesignIdeasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_whole);
            this.Name = "DesignIdeasControl";
            this.Size = new System.Drawing.Size(430, 356);
            this.splitContainer_whole.Panel1.ResumeLayout(false);
            this.splitContainer_whole.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_whole)).EndInit();
            this.splitContainer_whole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_designideas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_comments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_whole;
        private System.Windows.Forms.DataGridView dataGridView_designideas;
        private System.Windows.Forms.DataGridView dataGridView_comments;
    }
}
