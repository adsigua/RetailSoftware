namespace RetailSoftware
{
    partial class ExitSubMenuForm
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
            this.tblpSubFormExit = new System.Windows.Forms.TableLayoutPanel();
            this.btnExitProgram = new System.Windows.Forms.CheckBox();
            this.btnEndDay = new System.Windows.Forms.CheckBox();
            this.btnLogOut = new System.Windows.Forms.CheckBox();
            this.tblpSubFormExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpSubFormExit
            // 
            this.tblpSubFormExit.ColumnCount = 2;
            this.tblpSubFormExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.701031F));
            this.tblpSubFormExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29897F));
            this.tblpSubFormExit.Controls.Add(this.btnExitProgram, 1, 2);
            this.tblpSubFormExit.Controls.Add(this.btnEndDay, 1, 1);
            this.tblpSubFormExit.Controls.Add(this.btnLogOut, 1, 0);
            this.tblpSubFormExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpSubFormExit.Location = new System.Drawing.Point(0, 0);
            this.tblpSubFormExit.Margin = new System.Windows.Forms.Padding(0);
            this.tblpSubFormExit.Name = "tblpSubFormExit";
            this.tblpSubFormExit.RowCount = 3;
            this.tblpSubFormExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpSubFormExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpSubFormExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpSubFormExit.Size = new System.Drawing.Size(194, 81);
            this.tblpSubFormExit.TabIndex = 17;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnExitProgram.AutoSize = true;
            this.btnExitProgram.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExitProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitProgram.FlatAppearance.BorderSize = 0;
            this.btnExitProgram.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProgram.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitProgram.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitProgram.Location = new System.Drawing.Point(12, 54);
            this.btnExitProgram.Margin = new System.Windows.Forms.Padding(0);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(182, 27);
            this.btnExitProgram.TabIndex = 18;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExitProgram.UseVisualStyleBackColor = false;
            this.btnExitProgram.Click += new System.EventHandler(this.subMenu_Clicked);
            this.btnExitProgram.Resize += new System.EventHandler(this.SubMenuForm_Resize);
            // 
            // btnEndDay
            // 
            this.btnEndDay.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnEndDay.AutoSize = true;
            this.btnEndDay.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEndDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEndDay.FlatAppearance.BorderSize = 0;
            this.btnEndDay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnEndDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndDay.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndDay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEndDay.Location = new System.Drawing.Point(12, 27);
            this.btnEndDay.Margin = new System.Windows.Forms.Padding(0);
            this.btnEndDay.Name = "btnEndDay";
            this.btnEndDay.Size = new System.Drawing.Size(182, 27);
            this.btnEndDay.TabIndex = 17;
            this.btnEndDay.Text = "End Day";
            this.btnEndDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEndDay.UseVisualStyleBackColor = false;
            this.btnEndDay.Click += new System.EventHandler(this.subMenu_Clicked);
            this.btnEndDay.Resize += new System.EventHandler(this.SubMenuForm_Resize);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Location = new System.Drawing.Point(12, 0);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(182, 27);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.subMenu_Clicked);
            this.btnLogOut.Resize += new System.EventHandler(this.SubMenuForm_Resize);
            // 
            // ExitSubMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(194, 81);
            this.Controls.Add(this.tblpSubFormExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitSubMenuForm";
            this.Text = "ExitSubMenuForm";
            this.tblpSubFormExit.ResumeLayout(false);
            this.tblpSubFormExit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpSubFormExit;
        private System.Windows.Forms.CheckBox btnExitProgram;
        private System.Windows.Forms.CheckBox btnEndDay;
        private System.Windows.Forms.CheckBox btnLogOut;
    }
}