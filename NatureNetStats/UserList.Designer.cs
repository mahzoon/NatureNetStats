namespace NatureNetStats
{
    partial class UserList
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
            this.radioButton_atoz = new System.Windows.Forms.RadioButton();
            this.radioButton_top = new System.Windows.Forms.RadioButton();
            this.radioButton_recent = new System.Windows.Forms.RadioButton();
            this.label_sortby_text = new System.Windows.Forms.Label();
            this.tableLayoutPanel_header = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_items = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_frame = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_header.SuspendLayout();
            this.tableLayoutPanel_frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_atoz
            // 
            this.radioButton_atoz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_atoz.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_atoz.Checked = true;
            this.radioButton_atoz.Location = new System.Drawing.Point(217, 5);
            this.radioButton_atoz.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_atoz.Name = "radioButton_atoz";
            this.radioButton_atoz.Size = new System.Drawing.Size(90, 25);
            this.radioButton_atoz.TabIndex = 1;
            this.radioButton_atoz.TabStop = true;
            this.radioButton_atoz.Text = "A - Z";
            this.radioButton_atoz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_atoz.UseVisualStyleBackColor = true;
            this.radioButton_atoz.CheckedChanged += new System.EventHandler(this.radioButton_atoz_CheckedChanged);
            // 
            // radioButton_top
            // 
            this.radioButton_top.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_top.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_top.Location = new System.Drawing.Point(307, 5);
            this.radioButton_top.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_top.Name = "radioButton_top";
            this.radioButton_top.Size = new System.Drawing.Size(90, 25);
            this.radioButton_top.TabIndex = 1;
            this.radioButton_top.TabStop = true;
            this.radioButton_top.Text = "Top";
            this.radioButton_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_top.UseVisualStyleBackColor = true;
            this.radioButton_top.CheckedChanged += new System.EventHandler(this.radioButton_top_CheckedChanged);
            // 
            // radioButton_recent
            // 
            this.radioButton_recent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_recent.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_recent.Location = new System.Drawing.Point(397, 5);
            this.radioButton_recent.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_recent.Name = "radioButton_recent";
            this.radioButton_recent.Size = new System.Drawing.Size(90, 25);
            this.radioButton_recent.TabIndex = 1;
            this.radioButton_recent.TabStop = true;
            this.radioButton_recent.Text = "Recent";
            this.radioButton_recent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_recent.UseVisualStyleBackColor = true;
            this.radioButton_recent.CheckedChanged += new System.EventHandler(this.radioButton_recent_CheckedChanged);
            // 
            // label_sortby_text
            // 
            this.label_sortby_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_sortby_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sortby_text.Location = new System.Drawing.Point(0, 0);
            this.label_sortby_text.Name = "label_sortby_text";
            this.label_sortby_text.Size = new System.Drawing.Size(704, 19);
            this.label_sortby_text.TabIndex = 2;
            this.label_sortby_text.Text = "Sort by:";
            this.label_sortby_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel_header
            // 
            this.tableLayoutPanel_header.ColumnCount = 3;
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_header.Controls.Add(this.radioButton_atoz, 0, 0);
            this.tableLayoutPanel_header.Controls.Add(this.radioButton_top, 1, 0);
            this.tableLayoutPanel_header.Controls.Add(this.radioButton_recent, 2, 0);
            this.tableLayoutPanel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_header.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel_header.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_header.Name = "tableLayoutPanel_header";
            this.tableLayoutPanel_header.RowCount = 1;
            this.tableLayoutPanel_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_header.Size = new System.Drawing.Size(704, 35);
            this.tableLayoutPanel_header.TabIndex = 3;
            // 
            // tableLayoutPanel_items
            // 
            this.tableLayoutPanel_items.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_items.ColumnCount = 5;
            this.tableLayoutPanel_items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_items.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_items.Location = new System.Drawing.Point(37, 0);
            this.tableLayoutPanel_items.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_items.Name = "tableLayoutPanel_items";
            this.tableLayoutPanel_items.RowCount = 1;
            this.tableLayoutPanel_items.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_items.Size = new System.Drawing.Size(630, 100);
            this.tableLayoutPanel_items.TabIndex = 4;
            // 
            // tableLayoutPanel_frame
            // 
            this.tableLayoutPanel_frame.AutoScroll = true;
            this.tableLayoutPanel_frame.ColumnCount = 3;
            this.tableLayoutPanel_frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 630F));
            this.tableLayoutPanel_frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_frame.Controls.Add(this.tableLayoutPanel_items, 1, 0);
            this.tableLayoutPanel_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_frame.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel_frame.Name = "tableLayoutPanel_frame";
            this.tableLayoutPanel_frame.RowCount = 1;
            this.tableLayoutPanel_frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_frame.Size = new System.Drawing.Size(704, 100);
            this.tableLayoutPanel_frame.TabIndex = 5;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel_frame);
            this.Controls.Add(this.tableLayoutPanel_header);
            this.Controls.Add(this.label_sortby_text);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(704, 542);
            this.tableLayoutPanel_header.ResumeLayout(false);
            this.tableLayoutPanel_frame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_atoz;
        private System.Windows.Forms.RadioButton radioButton_top;
        private System.Windows.Forms.RadioButton radioButton_recent;
        private System.Windows.Forms.Label label_sortby_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_frame;
    }
}
