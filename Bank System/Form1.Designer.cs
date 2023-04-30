namespace Bank_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtBalance = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnShow = new Button();
            btnUpgrade = new Button();
            btnDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.Location = new Point(34, 611);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "New Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(787, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(459, 644);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(112, 42);
            label1.Name = "label1";
            label1.Size = new Size(137, 24);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(414, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(290, 27);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(414, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 27);
            txtName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(414, 227);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(290, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(414, 322);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(290, 27);
            txtBalance.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(112, 137);
            label2.Name = "label2";
            label2.Size = new Size(170, 24);
            label2.TabIndex = 7;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(112, 230);
            label3.Name = "label3";
            label3.Size = new Size(91, 24);
            label3.TabIndex = 8;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(112, 325);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 9;
            label4.Text = "Balance";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Transparent;
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnShow.Location = new Point(224, 611);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(149, 45);
            btnShow.TabIndex = 10;
            btnShow.Text = "Show Data";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnUpgrade
            // 
            btnUpgrade.BackColor = Color.Transparent;
            btnUpgrade.FlatStyle = FlatStyle.Popup;
            btnUpgrade.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpgrade.Location = new Point(425, 611);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(149, 45);
            btnUpgrade.TabIndex = 11;
            btnUpgrade.Text = "Upgrade Data";
            btnUpgrade.UseVisualStyleBackColor = false;
            btnUpgrade.Click += btnUpgrade_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Transparent;
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDel.Location = new Point(619, 611);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(149, 45);
            btnDel.TabIndex = 12;
            btnDel.Text = "Delete Data";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 683);
            Controls.Add(btnDel);
            Controls.Add(btnUpgrade);
            Controls.Add(btnShow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBalance);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Blanco Bank";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtBalance;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnShow;
        private Button btnUpgrade;
        private Button btnDel;
    }
}