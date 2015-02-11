namespace ConfigurationManager
{
    partial class ConfigurationManager
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
            this.tvConfiguration = new System.Windows.Forms.TreeView();
            this.btnLoadConfiguration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfigurationFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSelectedValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvConfiguration
            // 
            this.tvConfiguration.Location = new System.Drawing.Point(12, 12);
            this.tvConfiguration.Name = "tvConfiguration";
            this.tvConfiguration.Size = new System.Drawing.Size(216, 350);
            this.tvConfiguration.TabIndex = 0;
            this.tvConfiguration.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvConfiguration_AfterSelect);
            // 
            // btnLoadConfiguration
            // 
            this.btnLoadConfiguration.Location = new System.Drawing.Point(407, 38);
            this.btnLoadConfiguration.Name = "btnLoadConfiguration";
            this.btnLoadConfiguration.Size = new System.Drawing.Size(121, 23);
            this.btnLoadConfiguration.TabIndex = 1;
            this.btnLoadConfiguration.Text = "Load Configuration";
            this.btnLoadConfiguration.UseVisualStyleBackColor = true;
            this.btnLoadConfiguration.Click += new System.EventHandler(this.btnLoadConfiguration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuration File:";
            // 
            // txtConfigurationFilePath
            // 
            this.txtConfigurationFilePath.Location = new System.Drawing.Point(333, 12);
            this.txtConfigurationFilePath.Name = "txtConfigurationFilePath";
            this.txtConfigurationFilePath.Size = new System.Drawing.Size(332, 20);
            this.txtConfigurationFilePath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(671, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSelectedValue
            // 
            this.txtSelectedValue.Location = new System.Drawing.Point(94, 24);
            this.txtSelectedValue.Name = "txtSelectedValue";
            this.txtSelectedValue.ReadOnly = true;
            this.txtSelectedValue.Size = new System.Drawing.Size(332, 20);
            this.txtSelectedValue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Value:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSelectedValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(237, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration Details";
            // 
            // ConfigurationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtConfigurationFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadConfiguration);
            this.Controls.Add(this.tvConfiguration);
            this.Name = "ConfigurationManager";
            this.Text = "Configuration Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvConfiguration;
        private System.Windows.Forms.Button btnLoadConfiguration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigurationFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSelectedValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

