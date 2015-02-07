namespace OGB
{
    partial class adjuster
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Value = new System.Windows.Forms.TextBox();
            this.BTN_Down = new System.Windows.Forms.Button();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.LBL_Desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Value
            // 
            this.TB_Value.Location = new System.Drawing.Point(122, 5);
            this.TB_Value.Name = "TB_Value";
            this.TB_Value.ReadOnly = true;
            this.TB_Value.Size = new System.Drawing.Size(41, 20);
            this.TB_Value.TabIndex = 0;
            this.TB_Value.Text = "0";
            // 
            // BTN_Down
            // 
            this.BTN_Down.Location = new System.Drawing.Point(93, 3);
            this.BTN_Down.Name = "BTN_Down";
            this.BTN_Down.Size = new System.Drawing.Size(23, 23);
            this.BTN_Down.TabIndex = 1;
            this.BTN_Down.Text = "-";
            this.BTN_Down.UseVisualStyleBackColor = true;
            this.BTN_Down.Click += new System.EventHandler(this.BTN_Down_Click);
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Location = new System.Drawing.Point(169, 3);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(24, 23);
            this.BTN_Plus.TabIndex = 2;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // LBL_Desc
            // 
            this.LBL_Desc.AutoSize = true;
            this.LBL_Desc.Location = new System.Drawing.Point(3, 8);
            this.LBL_Desc.Name = "LBL_Desc";
            this.LBL_Desc.Size = new System.Drawing.Size(60, 13);
            this.LBL_Desc.TabIndex = 3;
            this.LBL_Desc.Text = "Description";
            // 
            // adjuster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_Desc);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.BTN_Down);
            this.Controls.Add(this.TB_Value);
            this.Name = "adjuster";
            this.Size = new System.Drawing.Size(200, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Down;
        private System.Windows.Forms.Button BTN_Plus;
        public System.Windows.Forms.Label LBL_Desc;
        public System.Windows.Forms.TextBox TB_Value;
    }
}
