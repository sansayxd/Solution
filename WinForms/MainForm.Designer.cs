namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Import_Button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Configure_New_Button = new System.Windows.Forms.Button();
            this.Clear_All_Button = new System.Windows.Forms.Button();
            this.Clear_Selected_Button = new System.Windows.Forms.Button();
            this.Select_Largest_Button = new System.Windows.Forms.Button();
            this.Select_Cheapest_Button = new System.Windows.Forms.Button();
            this.Distance_Box = new System.Windows.Forms.NumericUpDown();
            this.distance_label = new System.Windows.Forms.Label();
            this.Type_Of_Selected_Button = new System.Windows.Forms.Button();
            this.Modify_Selected_Button = new System.Windows.Forms.Button();
            this.Get_Cost_Button = new System.Windows.Forms.Button();
            this.Selected_Info_Button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.count_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.selected_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthor_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Subscribe_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance_Box)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(227, 31);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(796, 460);
            this.dataGridView.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Import_Button
            // 
            this.Import_Button.Location = new System.Drawing.Point(12, 31);
            this.Import_Button.Name = "Import_Button";
            this.Import_Button.Size = new System.Drawing.Size(196, 40);
            this.Import_Button.TabIndex = 1;
            this.Import_Button.Text = "Import";
            this.Import_Button.UseVisualStyleBackColor = true;
            this.Import_Button.Click += new System.EventHandler(this.Import_Button_Click);
            // 
            // Export_Button
            // 
            this.Export_Button.Location = new System.Drawing.Point(12, 77);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(196, 40);
            this.Export_Button.TabIndex = 3;
            this.Export_Button.Text = "Export";
            this.Export_Button.UseVisualStyleBackColor = true;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // Configure_New_Button
            // 
            this.Configure_New_Button.Location = new System.Drawing.Point(12, 123);
            this.Configure_New_Button.Name = "Configure_New_Button";
            this.Configure_New_Button.Size = new System.Drawing.Size(196, 40);
            this.Configure_New_Button.TabIndex = 4;
            this.Configure_New_Button.Text = "Configure new vehicle";
            this.Configure_New_Button.UseVisualStyleBackColor = true;
            this.Configure_New_Button.Click += new System.EventHandler(this.Configure_New_Button_Click);
            // 
            // Clear_All_Button
            // 
            this.Clear_All_Button.Location = new System.Drawing.Point(12, 215);
            this.Clear_All_Button.Name = "Clear_All_Button";
            this.Clear_All_Button.Size = new System.Drawing.Size(196, 40);
            this.Clear_All_Button.TabIndex = 5;
            this.Clear_All_Button.Text = "Clear all";
            this.Clear_All_Button.UseVisualStyleBackColor = true;
            this.Clear_All_Button.Click += new System.EventHandler(this.Clear_All_Button_Click);
            // 
            // Clear_Selected_Button
            // 
            this.Clear_Selected_Button.Location = new System.Drawing.Point(12, 261);
            this.Clear_Selected_Button.Name = "Clear_Selected_Button";
            this.Clear_Selected_Button.Size = new System.Drawing.Size(196, 40);
            this.Clear_Selected_Button.TabIndex = 6;
            this.Clear_Selected_Button.Text = "Clear selected";
            this.Clear_Selected_Button.UseVisualStyleBackColor = true;
            this.Clear_Selected_Button.Click += new System.EventHandler(this.Clear_Selected_Button_Click);
            // 
            // Select_Largest_Button
            // 
            this.Select_Largest_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Select_Largest_Button.Location = new System.Drawing.Point(227, 498);
            this.Select_Largest_Button.Name = "Select_Largest_Button";
            this.Select_Largest_Button.Size = new System.Drawing.Size(196, 40);
            this.Select_Largest_Button.TabIndex = 7;
            this.Select_Largest_Button.Text = "Select largest";
            this.Select_Largest_Button.UseVisualStyleBackColor = true;
            this.Select_Largest_Button.Click += new System.EventHandler(this.Select_Largest_Button_Click);
            // 
            // Select_Cheapest_Button
            // 
            this.Select_Cheapest_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Select_Cheapest_Button.Location = new System.Drawing.Point(523, 498);
            this.Select_Cheapest_Button.Name = "Select_Cheapest_Button";
            this.Select_Cheapest_Button.Size = new System.Drawing.Size(196, 40);
            this.Select_Cheapest_Button.TabIndex = 8;
            this.Select_Cheapest_Button.Text = "Select cheapest";
            this.Select_Cheapest_Button.UseVisualStyleBackColor = true;
            this.Select_Cheapest_Button.Click += new System.EventHandler(this.Select_Cheapest_Button_Click);
            // 
            // Distance_Box
            // 
            this.Distance_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Distance_Box.Location = new System.Drawing.Point(769, 554);
            this.Distance_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.Distance_Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Distance_Box.Name = "Distance_Box";
            this.Distance_Box.Size = new System.Drawing.Size(104, 27);
            this.Distance_Box.TabIndex = 10;
            this.Distance_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // distance_label
            // 
            this.distance_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.distance_label.AutoSize = true;
            this.distance_label.Location = new System.Drawing.Point(677, 556);
            this.distance_label.Name = "distance_label";
            this.distance_label.Size = new System.Drawing.Size(66, 20);
            this.distance_label.TabIndex = 11;
            this.distance_label.Text = "Distance";
            // 
            // Type_Of_Selected_Button
            // 
            this.Type_Of_Selected_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Type_Of_Selected_Button.Location = new System.Drawing.Point(227, 546);
            this.Type_Of_Selected_Button.Name = "Type_Of_Selected_Button";
            this.Type_Of_Selected_Button.Size = new System.Drawing.Size(196, 40);
            this.Type_Of_Selected_Button.TabIndex = 12;
            this.Type_Of_Selected_Button.Text = "Type of selected";
            this.Type_Of_Selected_Button.UseVisualStyleBackColor = true;
            this.Type_Of_Selected_Button.Click += new System.EventHandler(this.Type_Of_Selected_Button_Click);
            // 
            // Modify_Selected_Button
            // 
            this.Modify_Selected_Button.Location = new System.Drawing.Point(12, 169);
            this.Modify_Selected_Button.Name = "Modify_Selected_Button";
            this.Modify_Selected_Button.Size = new System.Drawing.Size(196, 40);
            this.Modify_Selected_Button.TabIndex = 13;
            this.Modify_Selected_Button.Text = "Modify selected";
            this.Modify_Selected_Button.UseVisualStyleBackColor = true;
            this.Modify_Selected_Button.Click += new System.EventHandler(this.Modify_Selected_Button_Click);
            // 
            // Get_Cost_Button
            // 
            this.Get_Cost_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Get_Cost_Button.Location = new System.Drawing.Point(827, 498);
            this.Get_Cost_Button.Name = "Get_Cost_Button";
            this.Get_Cost_Button.Size = new System.Drawing.Size(196, 40);
            this.Get_Cost_Button.TabIndex = 14;
            this.Get_Cost_Button.Text = "Get cost";
            this.Get_Cost_Button.UseVisualStyleBackColor = true;
            this.Get_Cost_Button.Click += new System.EventHandler(this.Get_Cost_Button_Click);
            // 
            // Selected_Info_Button
            // 
            this.Selected_Info_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Selected_Info_Button.Location = new System.Drawing.Point(227, 592);
            this.Selected_Info_Button.Name = "Selected_Info_Button";
            this.Selected_Info_Button.Size = new System.Drawing.Size(196, 40);
            this.Selected_Info_Button.TabIndex = 15;
            this.Selected_Info_Button.Text = "Selected info";
            this.Selected_Info_Button.UseVisualStyleBackColor = true;
            this.Selected_Info_Button.Click += new System.EventHandler(this.Selected_Info_Button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.count_label,
            this.selected_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 26);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // count_label
            // 
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(118, 20);
            this.count_label.Text = "Vehicles count: 0";
            // 
            // selected_label
            // 
            this.selected_label.Name = "selected_label";
            this.selected_label.Size = new System.Drawing.Size(126, 20);
            this.selected_label.Text = "Selection count: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthor_Button,
            this.aboutProgram_Button});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutAuthor_Button
            // 
            this.aboutAuthor_Button.Name = "aboutAuthor_Button";
            this.aboutAuthor_Button.Size = new System.Drawing.Size(195, 26);
            this.aboutAuthor_Button.Text = "About author";
            this.aboutAuthor_Button.Click += new System.EventHandler(this.aboutAuthor_Button_Click);
            // 
            // aboutProgram_Button
            // 
            this.aboutProgram_Button.Name = "aboutProgram_Button";
            this.aboutProgram_Button.Size = new System.Drawing.Size(195, 26);
            this.aboutProgram_Button.Text = "About program";
            this.aboutProgram_Button.Click += new System.EventHandler(this.aboutProgram_Button_Click);
            // 
            // Subscribe_Button
            // 
            this.Subscribe_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Subscribe_Button.Location = new System.Drawing.Point(827, 592);
            this.Subscribe_Button.Name = "Subscribe_Button";
            this.Subscribe_Button.Size = new System.Drawing.Size(196, 40);
            this.Subscribe_Button.TabIndex = 18;
            this.Subscribe_Button.Text = "Subscribe all for occupied event";
            this.Subscribe_Button.UseVisualStyleBackColor = true;
            this.Subscribe_Button.Click += new System.EventHandler(this.Subscribe_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 673);
            this.Controls.Add(this.Subscribe_Button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Selected_Info_Button);
            this.Controls.Add(this.Get_Cost_Button);
            this.Controls.Add(this.Modify_Selected_Button);
            this.Controls.Add(this.Type_Of_Selected_Button);
            this.Controls.Add(this.distance_label);
            this.Controls.Add(this.Distance_Box);
            this.Controls.Add(this.Select_Cheapest_Button);
            this.Controls.Add(this.Select_Largest_Button);
            this.Controls.Add(this.Clear_Selected_Button);
            this.Controls.Add(this.Clear_All_Button);
            this.Controls.Add(this.Configure_New_Button);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.Import_Button);
            this.Controls.Add(this.dataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vehicle configurator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Distance_Box)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private OpenFileDialog openFileDialog1;
        private Button Import_Button;
        private SaveFileDialog saveFileDialog1;
        private Button Export_Button;
        private Button Configure_New_Button;
        private Button Clear_All_Button;
        private Button Clear_Selected_Button;
        private Button Select_Largest_Button;
        private Button Select_Cheapest_Button;
        private NumericUpDown Distance_Box;
        private Label distance_label;
        private Button Type_Of_Selected_Button;
        private Button Modify_Selected_Button;
        private Button Get_Cost_Button;
        private Button Selected_Info_Button;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel count_label;
        private ToolStripStatusLabel selected_label;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutAuthor_Button;
        private ToolStripMenuItem aboutProgram_Button;
        private Button Subscribe_Button;
    }
}