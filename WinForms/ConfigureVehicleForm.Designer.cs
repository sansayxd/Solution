namespace WinForms
{
    partial class ConfigureVehicleForm
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
            this.isLongRange_Box = new System.Windows.Forms.CheckBox();
            this.Configure_Button = new System.Windows.Forms.Button();
            this.type_Box = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.avarage_speed_label = new System.Windows.Forms.Label();
            this.avarage_speed_Box = new System.Windows.Forms.NumericUpDown();
            this.cost_per_km_Box = new System.Windows.Forms.NumericUpDown();
            this.cost_per_km_label = new System.Windows.Forms.Label();
            this.seats_Box = new System.Windows.Forms.NumericUpDown();
            this.seats_label = new System.Windows.Forms.Label();
            this.occupied_seats_Box = new System.Windows.Forms.NumericUpDown();
            this.occupied_seats_label = new System.Windows.Forms.Label();
            this.meal_cost_Box = new System.Windows.Forms.NumericUpDown();
            this.meal_cost_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avarage_speed_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_per_km_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seats_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupied_seats_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_cost_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // isLongRange_Box
            // 
            this.isLongRange_Box.AutoSize = true;
            this.isLongRange_Box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isLongRange_Box.Location = new System.Drawing.Point(12, 12);
            this.isLongRange_Box.Name = "isLongRange_Box";
            this.isLongRange_Box.Size = new System.Drawing.Size(156, 24);
            this.isLongRange_Box.TabIndex = 0;
            this.isLongRange_Box.Text = "Long range vehicle";
            this.isLongRange_Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isLongRange_Box.UseVisualStyleBackColor = true;
            this.isLongRange_Box.CheckedChanged += new System.EventHandler(this.isLongRange_Box_CheckedChanged);
            // 
            // Configure_Button
            // 
            this.Configure_Button.Location = new System.Drawing.Point(119, 311);
            this.Configure_Button.Name = "Configure_Button";
            this.Configure_Button.Size = new System.Drawing.Size(94, 29);
            this.Configure_Button.TabIndex = 1;
            this.Configure_Button.Text = "Configure";
            this.Configure_Button.UseVisualStyleBackColor = true;
            this.Configure_Button.Click += new System.EventHandler(this.Configure_Button_Click);
            // 
            // type_Box
            // 
            this.type_Box.FormattingEnabled = true;
            this.type_Box.Location = new System.Drawing.Point(152, 52);
            this.type_Box.Name = "type_Box";
            this.type_Box.Size = new System.Drawing.Size(151, 28);
            this.type_Box.TabIndex = 2;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(12, 52);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(89, 20);
            this.type_label.TabIndex = 3;
            this.type_label.Text = "Vehicle type";
            // 
            // avarage_speed_label
            // 
            this.avarage_speed_label.AutoSize = true;
            this.avarage_speed_label.Location = new System.Drawing.Point(12, 91);
            this.avarage_speed_label.Name = "avarage_speed_label";
            this.avarage_speed_label.Size = new System.Drawing.Size(108, 20);
            this.avarage_speed_label.TabIndex = 4;
            this.avarage_speed_label.Text = "Avarage speed";
            // 
            // avarage_speed_Box
            // 
            this.avarage_speed_Box.Location = new System.Drawing.Point(152, 89);
            this.avarage_speed_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.avarage_speed_Box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avarage_speed_Box.Name = "avarage_speed_Box";
            this.avarage_speed_Box.Size = new System.Drawing.Size(150, 27);
            this.avarage_speed_Box.TabIndex = 5;
            this.avarage_speed_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cost_per_km_Box
            // 
            this.cost_per_km_Box.Location = new System.Drawing.Point(153, 122);
            this.cost_per_km_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.cost_per_km_Box.Name = "cost_per_km_Box";
            this.cost_per_km_Box.Size = new System.Drawing.Size(150, 27);
            this.cost_per_km_Box.TabIndex = 7;
            this.cost_per_km_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cost_per_km_label
            // 
            this.cost_per_km_label.AutoSize = true;
            this.cost_per_km_label.Location = new System.Drawing.Point(13, 124);
            this.cost_per_km_label.Name = "cost_per_km_label";
            this.cost_per_km_label.Size = new System.Drawing.Size(88, 20);
            this.cost_per_km_label.TabIndex = 6;
            this.cost_per_km_label.Text = "Cost per km";
            // 
            // seats_Box
            // 
            this.seats_Box.Location = new System.Drawing.Point(153, 155);
            this.seats_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.seats_Box.Name = "seats_Box";
            this.seats_Box.Size = new System.Drawing.Size(150, 27);
            this.seats_Box.TabIndex = 9;
            this.seats_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seats_Box.ValueChanged += new System.EventHandler(this.seats_Box_ValueChanged);
            // 
            // seats_label
            // 
            this.seats_label.AutoSize = true;
            this.seats_label.Location = new System.Drawing.Point(13, 157);
            this.seats_label.Name = "seats_label";
            this.seats_label.Size = new System.Drawing.Size(44, 20);
            this.seats_label.TabIndex = 8;
            this.seats_label.Text = "Seats";
            // 
            // occupied_seats_Box
            // 
            this.occupied_seats_Box.Location = new System.Drawing.Point(153, 188);
            this.occupied_seats_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.occupied_seats_Box.Name = "occupied_seats_Box";
            this.occupied_seats_Box.Size = new System.Drawing.Size(150, 27);
            this.occupied_seats_Box.TabIndex = 11;
            this.occupied_seats_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // occupied_seats_label
            // 
            this.occupied_seats_label.AutoSize = true;
            this.occupied_seats_label.Location = new System.Drawing.Point(13, 190);
            this.occupied_seats_label.Name = "occupied_seats_label";
            this.occupied_seats_label.Size = new System.Drawing.Size(109, 20);
            this.occupied_seats_label.TabIndex = 10;
            this.occupied_seats_label.Text = "Occupied seats";
            // 
            // meal_cost_Box
            // 
            this.meal_cost_Box.Location = new System.Drawing.Point(153, 221);
            this.meal_cost_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.meal_cost_Box.Name = "meal_cost_Box";
            this.meal_cost_Box.Size = new System.Drawing.Size(150, 27);
            this.meal_cost_Box.TabIndex = 13;
            this.meal_cost_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // meal_cost_label
            // 
            this.meal_cost_label.AutoSize = true;
            this.meal_cost_label.Location = new System.Drawing.Point(13, 223);
            this.meal_cost_label.Name = "meal_cost_label";
            this.meal_cost_label.Size = new System.Drawing.Size(73, 20);
            this.meal_cost_label.TabIndex = 12;
            this.meal_cost_label.Text = "Meal cost";
            // 
            // ConfigureVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 352);
            this.Controls.Add(this.meal_cost_Box);
            this.Controls.Add(this.meal_cost_label);
            this.Controls.Add(this.occupied_seats_Box);
            this.Controls.Add(this.occupied_seats_label);
            this.Controls.Add(this.seats_Box);
            this.Controls.Add(this.seats_label);
            this.Controls.Add(this.cost_per_km_Box);
            this.Controls.Add(this.cost_per_km_label);
            this.Controls.Add(this.avarage_speed_Box);
            this.Controls.Add(this.avarage_speed_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.type_Box);
            this.Controls.Add(this.Configure_Button);
            this.Controls.Add(this.isLongRange_Box);
            this.Name = "ConfigureVehicleForm";
            this.Text = "  Configure new vehicle";
            this.Load += new System.EventHandler(this.ConfigureVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avarage_speed_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_per_km_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seats_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupied_seats_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_cost_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox isLongRange_Box;
        private Button Configure_Button;
        private ComboBox type_Box;
        private Label type_label;
        private Label avarage_speed_label;
        private NumericUpDown avarage_speed_Box;
        private NumericUpDown cost_per_km_Box;
        private Label cost_per_km_label;
        private NumericUpDown seats_Box;
        private Label seats_label;
        private NumericUpDown occupied_seats_Box;
        private Label occupied_seats_label;
        private NumericUpDown meal_cost_Box;
        private Label meal_cost_label;
    }
}