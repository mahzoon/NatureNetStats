namespace NatureNetStats
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_interactions_text = new System.Windows.Forms.TextBox();
            this.label_interactions = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_likes_text = new System.Windows.Forms.TextBox();
            this.label_likes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_comments_text = new System.Windows.Forms.TextBox();
            this.label_comments = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_users_text = new System.Windows.Forms.TextBox();
            this.label_users = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_observations_text = new System.Windows.Forms.TextBox();
            this.label_observations = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_designideas_text = new System.Windows.Forms.TextBox();
            this.label_designideas = new System.Windows.Forms.Label();
            this.dataGridView_log = new System.Windows.Forms.DataGridView();
            this.plotView_interactions = new OxyPlot.WindowsForms.PlotView();
            this.label_from_text = new System.Windows.Forms.Label();
            this.label_source_table_text = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label_to_text = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.comboBox_source_tables = new System.Windows.Forms.ComboBox();
            this.button_refresh_tables = new System.Windows.Forms.Button();
            this.label_source_plot_text = new System.Windows.Forms.Label();
            this.comboBox_source_plot = new System.Windows.Forms.ComboBox();
            this.button_refresh_plot = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_log)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 268);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 150);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Controls.Add(this.label_interactions_text);
            this.panel6.Controls.Add(this.label_interactions);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(481, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 69);
            this.panel6.TabIndex = 12;
            // 
            // label_interactions_text
            // 
            this.label_interactions_text.BackColor = System.Drawing.Color.Green;
            this.label_interactions_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_interactions_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_interactions_text.ForeColor = System.Drawing.Color.White;
            this.label_interactions_text.Location = new System.Drawing.Point(68, 25);
            this.label_interactions_text.Multiline = true;
            this.label_interactions_text.Name = "label_interactions_text";
            this.label_interactions_text.ReadOnly = true;
            this.label_interactions_text.Size = new System.Drawing.Size(96, 23);
            this.label_interactions_text.TabIndex = 1;
            this.label_interactions_text.Text = "Interactions";
            this.label_interactions_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_interactions
            // 
            this.label_interactions.AutoSize = true;
            this.label_interactions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_interactions.ForeColor = System.Drawing.Color.White;
            this.label_interactions.Location = new System.Drawing.Point(7, 22);
            this.label_interactions.Name = "label_interactions";
            this.label_interactions.Size = new System.Drawing.Size(30, 23);
            this.label_interactions.TabIndex = 0;
            this.label_interactions.Text = "50";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Controls.Add(this.label_likes_text);
            this.panel5.Controls.Add(this.label_likes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(242, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 69);
            this.panel5.TabIndex = 11;
            // 
            // label_likes_text
            // 
            this.label_likes_text.BackColor = System.Drawing.Color.Green;
            this.label_likes_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_likes_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_likes_text.ForeColor = System.Drawing.Color.White;
            this.label_likes_text.Location = new System.Drawing.Point(44, 25);
            this.label_likes_text.Multiline = true;
            this.label_likes_text.Name = "label_likes_text";
            this.label_likes_text.ReadOnly = true;
            this.label_likes_text.Size = new System.Drawing.Size(53, 23);
            this.label_likes_text.TabIndex = 1;
            this.label_likes_text.Text = "Likes";
            this.label_likes_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_likes
            // 
            this.label_likes.AutoSize = true;
            this.label_likes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_likes.ForeColor = System.Drawing.Color.White;
            this.label_likes.Location = new System.Drawing.Point(7, 22);
            this.label_likes.Name = "label_likes";
            this.label_likes.Size = new System.Drawing.Size(30, 23);
            this.label_likes.TabIndex = 0;
            this.label_likes.Text = "50";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Controls.Add(this.label_comments_text);
            this.panel4.Controls.Add(this.label_comments);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 69);
            this.panel4.TabIndex = 10;
            // 
            // label_comments_text
            // 
            this.label_comments_text.BackColor = System.Drawing.Color.Green;
            this.label_comments_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_comments_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comments_text.ForeColor = System.Drawing.Color.White;
            this.label_comments_text.Location = new System.Drawing.Point(44, 25);
            this.label_comments_text.Multiline = true;
            this.label_comments_text.Name = "label_comments_text";
            this.label_comments_text.ReadOnly = true;
            this.label_comments_text.Size = new System.Drawing.Size(79, 23);
            this.label_comments_text.TabIndex = 1;
            this.label_comments_text.Text = "Comments";
            this.label_comments_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_comments
            // 
            this.label_comments.AutoSize = true;
            this.label_comments.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comments.ForeColor = System.Drawing.Color.White;
            this.label_comments.Location = new System.Drawing.Point(5, 22);
            this.label_comments.Name = "label_comments";
            this.label_comments.Size = new System.Drawing.Size(30, 23);
            this.label_comments.TabIndex = 0;
            this.label_comments.Text = "50";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.label_users_text);
            this.panel3.Controls.Add(this.label_users);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(481, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 69);
            this.panel3.TabIndex = 9;
            // 
            // label_users_text
            // 
            this.label_users_text.BackColor = System.Drawing.Color.Green;
            this.label_users_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_users_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_users_text.ForeColor = System.Drawing.Color.White;
            this.label_users_text.Location = new System.Drawing.Point(68, 25);
            this.label_users_text.Multiline = true;
            this.label_users_text.Name = "label_users_text";
            this.label_users_text.ReadOnly = true;
            this.label_users_text.Size = new System.Drawing.Size(55, 23);
            this.label_users_text.TabIndex = 1;
            this.label_users_text.Text = "Users";
            this.label_users_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_users
            // 
            this.label_users.AutoSize = true;
            this.label_users.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_users.ForeColor = System.Drawing.Color.White;
            this.label_users.Location = new System.Drawing.Point(7, 22);
            this.label_users.Name = "label_users";
            this.label_users.Size = new System.Drawing.Size(30, 23);
            this.label_users.TabIndex = 0;
            this.label_users.Text = "50";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label_observations_text);
            this.panel2.Controls.Add(this.label_observations);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(242, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 69);
            this.panel2.TabIndex = 8;
            // 
            // label_observations_text
            // 
            this.label_observations_text.BackColor = System.Drawing.Color.Green;
            this.label_observations_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_observations_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_observations_text.ForeColor = System.Drawing.Color.White;
            this.label_observations_text.Location = new System.Drawing.Point(44, 25);
            this.label_observations_text.Multiline = true;
            this.label_observations_text.Name = "label_observations_text";
            this.label_observations_text.ReadOnly = true;
            this.label_observations_text.Size = new System.Drawing.Size(98, 23);
            this.label_observations_text.TabIndex = 1;
            this.label_observations_text.Text = "Observations";
            this.label_observations_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_observations
            // 
            this.label_observations.AutoSize = true;
            this.label_observations.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_observations.ForeColor = System.Drawing.Color.White;
            this.label_observations.Location = new System.Drawing.Point(7, 22);
            this.label_observations.Name = "label_observations";
            this.label_observations.Size = new System.Drawing.Size(30, 23);
            this.label_observations.TabIndex = 0;
            this.label_observations.Text = "50";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label_designideas_text);
            this.panel1.Controls.Add(this.label_designideas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 69);
            this.panel1.TabIndex = 7;
            // 
            // label_designideas_text
            // 
            this.label_designideas_text.BackColor = System.Drawing.Color.Green;
            this.label_designideas_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_designideas_text.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_designideas_text.ForeColor = System.Drawing.Color.White;
            this.label_designideas_text.Location = new System.Drawing.Point(44, 25);
            this.label_designideas_text.Multiline = true;
            this.label_designideas_text.Name = "label_designideas_text";
            this.label_designideas_text.ReadOnly = true;
            this.label_designideas_text.Size = new System.Drawing.Size(95, 41);
            this.label_designideas_text.TabIndex = 1;
            this.label_designideas_text.Text = "Design Ideas";
            this.label_designideas_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_designideas
            // 
            this.label_designideas.AutoSize = true;
            this.label_designideas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_designideas.ForeColor = System.Drawing.Color.White;
            this.label_designideas.Location = new System.Drawing.Point(5, 22);
            this.label_designideas.Name = "label_designideas";
            this.label_designideas.Size = new System.Drawing.Size(30, 23);
            this.label_designideas.TabIndex = 0;
            this.label_designideas.Text = "50";
            // 
            // dataGridView_log
            // 
            this.dataGridView_log.AllowUserToAddRows = false;
            this.dataGridView_log.AllowUserToDeleteRows = false;
            this.dataGridView_log.AllowUserToOrderColumns = true;
            this.dataGridView_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_log.Location = new System.Drawing.Point(20, 472);
            this.dataGridView_log.Name = "dataGridView_log";
            this.dataGridView_log.ReadOnly = true;
            this.dataGridView_log.Size = new System.Drawing.Size(713, 146);
            this.dataGridView_log.TabIndex = 4;
            // 
            // plotView_interactions
            // 
            this.plotView_interactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView_interactions.Location = new System.Drawing.Point(17, 42);
            this.plotView_interactions.Name = "plotView_interactions";
            this.plotView_interactions.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView_interactions.Size = new System.Drawing.Size(719, 199);
            this.plotView_interactions.TabIndex = 5;
            this.plotView_interactions.Text = "Interaction Log Plot";
            this.plotView_interactions.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView_interactions.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView_interactions.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label_from_text
            // 
            this.label_from_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_from_text.AutoSize = true;
            this.label_from_text.Location = new System.Drawing.Point(253, 446);
            this.label_from_text.Name = "label_from_text";
            this.label_from_text.Size = new System.Drawing.Size(38, 15);
            this.label_from_text.TabIndex = 6;
            this.label_from_text.Text = "From:";
            // 
            // label_source_table_text
            // 
            this.label_source_table_text.AutoSize = true;
            this.label_source_table_text.Location = new System.Drawing.Point(17, 446);
            this.label_source_table_text.Name = "label_source_table_text";
            this.label_source_table_text.Size = new System.Drawing.Size(47, 15);
            this.label_source_table_text.TabIndex = 6;
            this.label_source_table_text.Text = "Source:";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_to.Location = new System.Drawing.Point(533, 443);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_to.TabIndex = 7;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // label_to_text
            // 
            this.label_to_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_to_text.AutoSize = true;
            this.label_to_text.Location = new System.Drawing.Point(506, 446);
            this.label_to_text.Name = "label_to_text";
            this.label_to_text.Size = new System.Drawing.Size(22, 15);
            this.label_to_text.TabIndex = 6;
            this.label_to_text.Text = "To:";
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_from.Location = new System.Drawing.Point(297, 443);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_from.TabIndex = 7;
            this.dateTimePicker_from.Value = new System.DateTime(2014, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            // 
            // comboBox_source_tables
            // 
            this.comboBox_source_tables.FormattingEnabled = true;
            this.comboBox_source_tables.Items.AddRange(new object[] {
            "Daily Log",
            "Interaction Log"});
            this.comboBox_source_tables.Location = new System.Drawing.Point(70, 443);
            this.comboBox_source_tables.Name = "comboBox_source_tables";
            this.comboBox_source_tables.Size = new System.Drawing.Size(128, 23);
            this.comboBox_source_tables.TabIndex = 8;
            // 
            // button_refresh_tables
            // 
            this.button_refresh_tables.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh_tables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh_tables.BackgroundImage")));
            this.button_refresh_tables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh_tables.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_refresh_tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh_tables.Location = new System.Drawing.Point(204, 443);
            this.button_refresh_tables.Name = "button_refresh_tables";
            this.button_refresh_tables.Size = new System.Drawing.Size(23, 23);
            this.button_refresh_tables.TabIndex = 9;
            this.button_refresh_tables.UseVisualStyleBackColor = false;
            this.button_refresh_tables.Click += new System.EventHandler(this.button_refresh_tables_Click);
            // 
            // label_source_plot_text
            // 
            this.label_source_plot_text.AutoSize = true;
            this.label_source_plot_text.Location = new System.Drawing.Point(17, 16);
            this.label_source_plot_text.Name = "label_source_plot_text";
            this.label_source_plot_text.Size = new System.Drawing.Size(47, 15);
            this.label_source_plot_text.TabIndex = 6;
            this.label_source_plot_text.Text = "Source:";
            // 
            // comboBox_source_plot
            // 
            this.comboBox_source_plot.FormattingEnabled = true;
            this.comboBox_source_plot.Items.AddRange(new object[] {
            "Observations",
            "Design Ideas",
            "Interactions"});
            this.comboBox_source_plot.Location = new System.Drawing.Point(70, 13);
            this.comboBox_source_plot.Name = "comboBox_source_plot";
            this.comboBox_source_plot.Size = new System.Drawing.Size(128, 23);
            this.comboBox_source_plot.TabIndex = 8;
            // 
            // button_refresh_plot
            // 
            this.button_refresh_plot.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh_plot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh_plot.BackgroundImage")));
            this.button_refresh_plot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh_plot.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_refresh_plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh_plot.Location = new System.Drawing.Point(204, 13);
            this.button_refresh_plot.Name = "button_refresh_plot";
            this.button_refresh_plot.Size = new System.Drawing.Size(23, 23);
            this.button_refresh_plot.TabIndex = 9;
            this.button_refresh_plot.UseVisualStyleBackColor = false;
            this.button_refresh_plot.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_refresh_plot);
            this.Controls.Add(this.button_refresh_tables);
            this.Controls.Add(this.comboBox_source_plot);
            this.Controls.Add(this.comboBox_source_tables);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.label_source_plot_text);
            this.Controls.Add(this.label_to_text);
            this.Controls.Add(this.label_source_table_text);
            this.Controls.Add(this.label_from_text);
            this.Controls.Add(this.plotView_interactions);
            this.Controls.Add(this.dataGridView_log);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(755, 635);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_log;
        private OxyPlot.WindowsForms.PlotView plotView_interactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_designideas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox label_observations_text;
        private System.Windows.Forms.Label label_observations;
        private System.Windows.Forms.TextBox label_designideas_text;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox label_users_text;
        private System.Windows.Forms.Label label_users;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox label_interactions_text;
        private System.Windows.Forms.Label label_interactions;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox label_likes_text;
        private System.Windows.Forms.Label label_likes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox label_comments_text;
        private System.Windows.Forms.Label label_comments;
        private System.Windows.Forms.Label label_from_text;
        private System.Windows.Forms.Label label_source_table_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label_to_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.ComboBox comboBox_source_tables;
        private System.Windows.Forms.Button button_refresh_tables;
        private System.Windows.Forms.Label label_source_plot_text;
        private System.Windows.Forms.ComboBox comboBox_source_plot;
        private System.Windows.Forms.Button button_refresh_plot;
    }
}
