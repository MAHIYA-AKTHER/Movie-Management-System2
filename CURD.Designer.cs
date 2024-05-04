namespace LogReg
{
    partial class CURD
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
            label1 = new Label();
            MovieRecordDataGridView = new DataGridView();
            button1 = new Button();
            p_id = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            p_name = new TextBox();
            label4 = new Label();
            u_price = new TextBox();
            label5 = new Label();
            u_available = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)MovieRecordDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 27);
            label1.Name = "label1";
            label1.Size = new Size(611, 51);
            label1.TabIndex = 0;
            label1.Text = "Movie Management System";
            // 
            // MovieRecordDataGridView
            // 
            MovieRecordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MovieRecordDataGridView.Location = new Point(257, 283);
            MovieRecordDataGridView.Name = "MovieRecordDataGridView";
            MovieRecordDataGridView.RowHeadersWidth = 51;
            MovieRecordDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MovieRecordDataGridView.Size = new Size(713, 358);
            MovieRecordDataGridView.TabIndex = 2;
            MovieRecordDataGridView.CellClick += MovieRecordDataGridView_CellClick;
            MovieRecordDataGridView.CellContentClick += MovieRecordDataGridView_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(1, 109);
            button1.Name = "button1";
            button1.Size = new Size(216, 37);
            button1.TabIndex = 3;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // p_id
            // 
            p_id.BackColor = Color.Lime;
            p_id.Font = new Font("Segoe UI", 11F);
            p_id.Location = new Point(388, 111);
            p_id.Name = "p_id";
            p_id.Size = new Size(196, 32);
            p_id.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(1, 179);
            button2.Name = "button2";
            button2.Size = new Size(216, 37);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(1, 254);
            button3.Name = "button3";
            button3.Size = new Size(216, 37);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(1, 334);
            button4.Name = "button4";
            button4.Size = new Size(216, 37);
            button4.TabIndex = 7;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lime;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(291, 114);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 8;
            label2.Text = "Movie ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(259, 212);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 10;
            label3.Text = "Movie Name:";
            // 
            // p_name
            // 
            p_name.BackColor = Color.Lime;
            p_name.Font = new Font("Segoe UI", 11F);
            p_name.Location = new Point(388, 205);
            p_name.Name = "p_name";
            p_name.Size = new Size(196, 32);
            p_name.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lime;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(636, 212);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 14;
            label4.Text = "Ticket Price:";
            // 
            // u_price
            // 
            u_price.BackColor = Color.Lime;
            u_price.Font = new Font("Segoe UI", 11F);
            u_price.Location = new Point(754, 209);
            u_price.Name = "u_price";
            u_price.Size = new Size(196, 32);
            u_price.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lime;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(614, 114);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 12;
            label5.Text = "Seat Available:";
            // 
            // u_available
            // 
            u_available.BackColor = Color.Lime;
            u_available.Font = new Font("Segoe UI", 11F);
            u_available.Location = new Point(754, 111);
            u_available.Name = "u_available";
            u_available.Size = new Size(196, 32);
            u_available.TabIndex = 11;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1, 521);
            button5.Name = "button5";
            button5.Size = new Size(216, 65);
            button5.TabIndex = 15;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // CURD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(982, 653);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(u_price);
            Controls.Add(label5);
            Controls.Add(u_available);
            Controls.Add(label3);
            Controls.Add(p_name);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(p_id);
            Controls.Add(button1);
            Controls.Add(MovieRecordDataGridView);
            Controls.Add(label1);
            Name = "CURD";
            Text = "Form2";
            Load += CURD_Load;
            ((System.ComponentModel.ISupportInitialize)MovieRecordDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView InventoryRecordDataGridView;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private TextBox p_id;
        private TextBox p_name;
        private TextBox u_price;
        private TextBox u_available;
        private Button button5;
        private DataGridView MovieRecordDataGridView;
    }
}