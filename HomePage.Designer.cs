
namespace database
{
    partial class HomePage
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtcountryhome = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpasshome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemailhome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnamehome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblwelcomename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(755, 239);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(265, 213);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Edit Database";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(158, 475);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(411, 42);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update My Account";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtcountryhome
            // 
            this.txtcountryhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcountryhome.FormattingEnabled = true;
            this.txtcountryhome.Items.AddRange(new object[] {
            "Australia",
            "China",
            "France",
            "Germany",
            "Indonesia",
            "Japan",
            "Netherland",
            "Rusia",
            "Singapore",
            "Spain",
            "UK",
            "USA",
            ""});
            this.txtcountryhome.Location = new System.Drawing.Point(158, 415);
            this.txtcountryhome.Name = "txtcountryhome";
            this.txtcountryhome.Size = new System.Drawing.Size(411, 39);
            this.txtcountryhome.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Country:";
            // 
            // txtpasshome
            // 
            this.txtpasshome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasshome.Location = new System.Drawing.Point(158, 353);
            this.txtpasshome.Name = "txtpasshome";
            this.txtpasshome.Size = new System.Drawing.Size(411, 38);
            this.txtpasshome.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-mail:";
            // 
            // txtemailhome
            // 
            this.txtemailhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailhome.Location = new System.Drawing.Point(158, 298);
            this.txtemailhome.Name = "txtemailhome";
            this.txtemailhome.Size = new System.Drawing.Size(411, 38);
            this.txtemailhome.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // txtnamehome
            // 
            this.txtnamehome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamehome.Location = new System.Drawing.Point(158, 235);
            this.txtnamehome.Name = "txtnamehome";
            this.txtnamehome.Size = new System.Drawing.Size(411, 38);
            this.txtnamehome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl.Location = new System.Drawing.Point(18, 137);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(418, 46);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Change Account Settings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(755, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete My Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblwelcomename
            // 
            this.lblwelcomename.AutoSize = true;
            this.lblwelcomename.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcomename.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblwelcomename.Location = new System.Drawing.Point(381, 9);
            this.lblwelcomename.Name = "lblwelcomename";
            this.lblwelcomename.Size = new System.Drawing.Size(330, 46);
            this.lblwelcomename.TabIndex = 21;
            this.lblwelcomename.Text = "Welcome Username";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 604);
            this.Controls.Add(this.lblwelcomename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtcountryhome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpasshome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemailhome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnamehome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogout);
            this.Name = "HomePage";
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox txtcountryhome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpasshome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemailhome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnamehome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblwelcomename;
    }
}