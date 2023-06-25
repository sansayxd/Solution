namespace WinForms
{
    partial class ModifyVehicleForm
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
            this.meal_cost_Box = new System.Windows.Forms.NumericUpDown();
            this.meal_cost_label = new System.Windows.Forms.Label();
            this.occupied_seats_Box = new System.Windows.Forms.NumericUpDown();
            this.occupied_seats_label = new System.Windows.Forms.Label();
            this.seats_Box = new System.Windows.Forms.NumericUpDown();
            this.seats_label = new System.Windows.Forms.Label();
            this.cost_per_km_Box = new System.Windows.Forms.NumericUpDown();
            this.cost_per_km_label = new System.Windows.Forms.Label();
            this.avarage_speed_Box = new System.Windows.Forms.NumericUpDown();
            this.avarage_speed_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.type_Box = new System.Windows.Forms.ComboBox();
            this.Configure_Button = new System.Windows.Forms.Button();
            this.isLongRange_Box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.meal_cost_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupied_seats_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seats_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_per_km_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avarage_speed_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // meal_cost_Box
            // 
            this.meal_cost_Box.Location = new System.Drawing.Point(153, 178);
            this.meal_cost_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.meal_cost_Box.Name = "meal_cost_Box";
            this.meal_cost_Box.Size = new System.Drawing.Size(150, 27);
            this.meal_cost_Box.TabIndex = 27;
            this.meal_cost_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // meal_cost_label
            // 
            this.meal_cost_label.AutoSize = true;
            this.meal_cost_label.Location = new System.Drawing.Point(13, 180);
            this.meal_cost_label.Name = "meal_cost_label";
            this.meal_cost_label.Size = new System.Drawing.Size(73, 20);
            this.meal_cost_label.TabIndex = 26;
            this.meal_cost_label.Text = "Meal cost";
            // 
            // occupied_seats_Box
            // 
            this.occupied_seats_Box.Location = new System.Drawing.Point(153, 145);
            this.occupied_seats_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.occupied_seats_Box.Name = "occupied_seats_Box";
            this.occupied_seats_Box.Size = new System.Drawing.Size(150, 27);
            this.occupied_seats_Box.TabIndex = 25;
            this.occupied_seats_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // occupied_seats_label
            // 
            this.occupied_seats_label.AutoSize = true;
            this.occupied_seats_label.Location = new System.Drawing.Point(13, 147);
            this.occupied_seats_label.Name = "occupied_seats_label";
            this.occupied_seats_label.Size = new System.Drawing.Size(109, 20);
            this.occupied_seats_label.TabIndex = 24;
            this.occupied_seats_label.Text = "Occupied seats";
            // 
            // seats_Box
            // 
            this.seats_Box.Location = new System.Drawing.Point(153, 112);
            this.seats_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.seats_Box.Name = "seats_Box";
            this.seats_Box.Size = new System.Drawing.Size(150, 27);
            this.seats_Box.TabIndex = 23;
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
            this.seats_label.Location = new System.Drawing.Point(13, 114);
            this.seats_label.Name = "seats_label";
            this.seats_label.Size = new System.Drawing.Size(44, 20);
            this.seats_label.TabIndex = 22;
            this.seats_label.Text = "Seats";
            // 
            // cost_per_km_Box
            // 
            this.cost_per_km_Box.Location = new System.Drawing.Point(153, 79);
            this.cost_per_km_Box.Maximum = new decimal(new int[] {
            27000,
            0,
            0,
            0});
            this.cost_per_km_Box.Name = "cost_per_km_Box";
            this.cost_per_km_Box.Size = new System.Drawing.Size(150, 27);
            this.cost_per_km_Box.TabIndex = 21;
            this.cost_per_km_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cost_per_km_label
            // 
            this.cost_per_km_label.AutoSize = true;
            this.cost_per_km_label.Location = new System.Drawing.Point(13, 81);
            this.cost_per_km_label.Name = "cost_per_km_label";
            this.cost_per_km_label.Size = new System.Drawing.Size(88, 20);
            this.cost_per_km_label.TabIndex = 20;
            this.cost_per_km_label.Text = "Cost per km";
            // 
            // avarage_speed_Box
            // 
            this.avarage_speed_Box.Location = new System.Drawing.Point(152, 46);
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
            this.avarage_speed_Box.TabIndex = 19;
            this.avarage_speed_Box.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // avarage_speed_label
            // 
            this.avarage_speed_label.AutoSize = true;
            this.avarage_speed_label.Location = new System.Drawing.Point(12, 48);
            this.avarage_speed_label.Name = "avarage_speed_label";
            this.avarage_speed_label.Size = new System.Drawing.Size(108, 20);
            this.avarage_speed_label.TabIndex = 18;
            this.avarage_speed_label.Text = "Avarage speed";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(12, 9);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(89, 20);
            this.type_label.TabIndex = 17;
            this.type_label.Text = "Vehicle type";
            // 
            // type_Box
            // 
            this.type_Box.FormattingEnabled = true;
            this.type_Box.Location = new System.Drawing.Point(152, 9);
            this.type_Box.Name = "type_Box";
            this.type_Box.Size = new System.Drawing.Size(151, 28);
            this.type_Box.TabIndex = 16;
            // 
            // Configure_Button
            // 
            this.Configure_Button.Location = new System.Drawing.Point(119, 227);
            this.Configure_Button.Name = "Configure_Button";
            this.Configure_Button.Size = new System.Drawing.Size(94, 29);
            this.Configure_Button.TabIndex = 15;
            this.Configure_Button.Text = "Configure";
            this.Configure_Button.UseVisualStyleBackColor = true;
            this.Configure_Button.Click += new System.EventHandler(this.Configure_Button_Click);
            // 
            // isLongRange_Box
            // 
            this.isLongRange_Box.AutoSize = true;
            this.isLongRange_Box.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isLongRange_Box.Location = new System.Drawing.Point(90, 121);
            this.isLongRange_Box.Name = "isLongRange_Box";
            this.isLongRange_Box.Size = new System.Drawing.Size(156, 24);
            this.isLongRange_Box.TabIndex = 28;
            this.isLongRange_Box.Text = "Long range vehicle";
            this.isLongRange_Box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isLongRange_Box.UseVisualStyleBackColor = true;
            // 
            // ModifyVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.isLongRange_Box);
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
            this.Name = "ModifyVehicleForm";
            this.Text = "ModifyVehicleForm";
            this.Load += new System.EventHandler(this.ModifyVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meal_cost_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupied_seats_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seats_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cost_per_km_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avarage_speed_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown meal_cost_Box;
        private Label meal_cost_label;
        private NumericUpDown occupied_seats_Box;
        private Label occupied_seats_label;
        private NumericUpDown seats_Box;
        private Label seats_label;
        private NumericUpDown cost_per_km_Box;
        private Label cost_per_km_label;
        private NumericUpDown avarage_speed_Box;
        private Label avarage_speed_label;
        private Label type_label;
        private ComboBox type_Box;
        private Button Configure_Button;
        private CheckBox isLongRange_Box;
    }
}