namespace NatureNetStats
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_banner = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_menuitems = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_activities = new System.Windows.Forms.Button();
            this.button_designideas = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.panel_right_background = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.dashboard_control = new NatureNetStats.Dashboard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_banner)).BeginInit();
            this.tableLayoutPanel_main.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_menuitems.SuspendLayout();
            this.panel_right_background.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_banner
            // 
            this.pictureBox_banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_banner.BackColor = System.Drawing.Color.White;
            this.pictureBox_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_banner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_banner.Image")));
            this.pictureBox_banner.Location = new System.Drawing.Point(15, 15);
            this.pictureBox_banner.Name = "pictureBox_banner";
            this.pictureBox_banner.Size = new System.Drawing.Size(982, 138);
            this.pictureBox_banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_banner.TabIndex = 0;
            this.pictureBox_banner.TabStop = false;
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Controls.Add(this.panel_menu, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.panel_right_background, 1, 0);
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(12, 160);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 1;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(985, 614);
            this.tableLayoutPanel_main.TabIndex = 1;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.panel_menuitems);
            this.panel_menu.Controls.Add(this.button_dashboard);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(187, 614);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_menuitems
            // 
            this.panel_menuitems.Controls.Add(this.button_settings);
            this.panel_menuitems.Controls.Add(this.button_activities);
            this.panel_menuitems.Controls.Add(this.button_designideas);
            this.panel_menuitems.Controls.Add(this.button_users);
            this.panel_menuitems.Location = new System.Drawing.Point(0, 73);
            this.panel_menuitems.Margin = new System.Windows.Forms.Padding(0);
            this.panel_menuitems.Name = "panel_menuitems";
            this.panel_menuitems.Size = new System.Drawing.Size(187, 285);
            this.panel_menuitems.TabIndex = 1;
            // 
            // button_settings
            // 
            this.button_settings.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_settings.Location = new System.Drawing.Point(3, 132);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(180, 40);
            this.button_settings.TabIndex = 0;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Visible = false;
            // 
            // button_activities
            // 
            this.button_activities.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_activities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_activities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_activities.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_activities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_activities.Location = new System.Drawing.Point(3, 89);
            this.button_activities.Name = "button_activities";
            this.button_activities.Size = new System.Drawing.Size(180, 40);
            this.button_activities.TabIndex = 0;
            this.button_activities.Text = "Activities";
            this.button_activities.UseVisualStyleBackColor = true;
            this.button_activities.Click += new System.EventHandler(this.button_activities_Click);
            // 
            // button_designideas
            // 
            this.button_designideas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_designideas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_designideas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_designideas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_designideas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_designideas.Location = new System.Drawing.Point(3, 46);
            this.button_designideas.Name = "button_designideas";
            this.button_designideas.Size = new System.Drawing.Size(180, 40);
            this.button_designideas.TabIndex = 0;
            this.button_designideas.Text = "Design Ideas";
            this.button_designideas.UseVisualStyleBackColor = true;
            this.button_designideas.Click += new System.EventHandler(this.button_designideas_Click);
            // 
            // button_users
            // 
            this.button_users.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_users.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_users.Location = new System.Drawing.Point(3, 3);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(180, 40);
            this.button_users.TabIndex = 0;
            this.button_users.Text = "Users";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_dashboard.Location = new System.Drawing.Point(3, 3);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(180, 61);
            this.button_dashboard.TabIndex = 0;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // panel_right_background
            // 
            this.panel_right_background.BackColor = System.Drawing.Color.Gray;
            this.panel_right_background.Controls.Add(this.panel_right);
            this.panel_right_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right_background.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_right_background.Location = new System.Drawing.Point(187, 3);
            this.panel_right_background.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel_right_background.Name = "panel_right_background";
            this.panel_right_background.Padding = new System.Windows.Forms.Padding(1);
            this.panel_right_background.Size = new System.Drawing.Size(798, 611);
            this.panel_right_background.TabIndex = 1;
            // 
            // panel_right
            // 
            this.panel_right.AutoScroll = true;
            this.panel_right.BackColor = System.Drawing.SystemColors.Control;
            this.panel_right.Controls.Add(this.dashboard_control);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel_right.Location = new System.Drawing.Point(1, 1);
            this.panel_right.Margin = new System.Windows.Forms.Padding(0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Padding = new System.Windows.Forms.Padding(3);
            this.panel_right.Size = new System.Drawing.Size(796, 609);
            this.panel_right.TabIndex = 0;
            // 
            // dashboard_control
            // 
            this.dashboard_control.AutoScroll = true;
            this.dashboard_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_control.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_control.Location = new System.Drawing.Point(3, 3);
            this.dashboard_control.Name = "dashboard_control";
            this.dashboard_control.Size = new System.Drawing.Size(790, 603);
            this.dashboard_control.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 773);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Controls.Add(this.pictureBox_banner);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "NatureNet Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_banner)).EndInit();
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menuitems.ResumeLayout(false);
            this.panel_right_background.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_banner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_right_background;
        private System.Windows.Forms.Panel panel_menuitems;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_activities;
        private System.Windows.Forms.Button button_designideas;
        private System.Windows.Forms.Panel panel_right;
        private Dashboard dashboard_control;
    }
}

