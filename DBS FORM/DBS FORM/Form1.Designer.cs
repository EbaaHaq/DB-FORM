namespace DBS_FORM
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_CN = new System.Windows.Forms.TextBox();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Count = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerID: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name: ";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(202, 46);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(200, 22);
            this.textBox_ID.TabIndex = 2;
            // 
            // textBox_CN
            // 
            this.textBox_CN.Location = new System.Drawing.Point(202, 101);
            this.textBox_CN.Name = "textBox_CN";
            this.textBox_CN.Size = new System.Drawing.Size(200, 22);
            this.textBox_CN.TabIndex = 3;
            // 
            // textBox_Count
            // 
            this.textBox_Count.Location = new System.Drawing.Point(444, 27);
            this.textBox_Count.Multiline = true;
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(329, 162);
            this.textBox_Count.TabIndex = 4;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(139, 199);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(138, 35);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Update Databse";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Count
            // 
            this.button_Count.Location = new System.Drawing.Point(541, 199);
            this.button_Count.Name = "button_Count";
            this.button_Count.Size = new System.Drawing.Size(138, 35);
            this.button_Count.TabIndex = 7;
            this.button_Count.Text = "Count Record";
            this.button_Count.UseVisualStyleBackColor = true;
            this.button_Count.Click += new System.EventHandler(this.button_Count_Click);
            // 
            // button_View
            // 
            this.button_View.Location = new System.Drawing.Point(318, 405);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(138, 35);
            this.button_View.TabIndex = 8;
            this.button_View.Text = "View Database";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_View);
            this.Controls.Add(this.button_Count);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.textBox_CN);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_CN;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Count;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

