namespace TapAz
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            textBoxUpdate = new TextBox();
            buttonRefresh = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1178, 381);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // textBoxUpdate
            // 
            textBoxUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxUpdate.Location = new Point(656, 217);
            textBoxUpdate.Multiline = true;
            textBoxUpdate.Name = "textBoxUpdate";
            textBoxUpdate.Size = new Size(156, 43);
            textBoxUpdate.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRefresh.Location = new Point(12, 216);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(194, 43);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            buttonRefresh.MouseLeave += buttonRefresh_MouseLeave;
            buttonRefresh.MouseMove += buttonRefresh_MouseMove;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(989, 213);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(194, 43);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            buttonUpdate.MouseLeave += buttonUpdate_MouseLeave;
            buttonUpdate.MouseMove += buttonUpdate_MouseMove;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.White;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDelete.Location = new Point(273, 217);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(194, 43);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            buttonDelete.MouseLeave += buttonDelete_MouseLeave;
            buttonDelete.MouseMove += buttonDelete_MouseMove;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSearch.Location = new Point(978, 23);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(194, 43);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            buttonSearch.MouseLeave += buttonSearch_MouseLeave;
            buttonSearch.MouseMove += buttonSearch_MouseMove;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(767, 23);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(205, 43);
            textBoxSearch.TabIndex = 1;
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxID.Location = new Point(861, 216);
            textBoxID.Multiline = true;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(97, 42);
            textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(878, 172);
            label1.Name = "label1";
            label1.Size = new Size(35, 31);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(697, 172);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1184, 659);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRefresh);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxID);
            Controls.Add(textBoxUpdate);
            Controls.Add(dataGridView1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxUpdate;
        private Button buttonRefresh;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private TextBox textBoxID;
        private Label label1;
        private Label label2;
    }
}