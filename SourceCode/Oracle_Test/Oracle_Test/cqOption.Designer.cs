﻿namespace Oracle_Test
{
    partial class cqOption
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
            this.cqcu_btn = new System.Windows.Forms.Button();
            this.cqcr_btn = new System.Windows.Forms.Button();
            this.crcu_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cqcu_btn
            // 
            this.cqcu_btn.Location = new System.Drawing.Point(159, 91);
            this.cqcu_btn.Name = "cqcu_btn";
            this.cqcu_btn.Size = new System.Drawing.Size(450, 199);
            this.cqcu_btn.TabIndex = 0;
            this.cqcu_btn.Text = "CẤP QUYỀN CHO USER";
            this.cqcu_btn.UseVisualStyleBackColor = true;
            this.cqcu_btn.Click += new System.EventHandler(this.cqcu_btn_Click);
            // 
            // cqcr_btn
            // 
            this.cqcr_btn.Location = new System.Drawing.Point(159, 378);
            this.cqcr_btn.Name = "cqcr_btn";
            this.cqcr_btn.Size = new System.Drawing.Size(450, 199);
            this.cqcr_btn.TabIndex = 1;
            this.cqcr_btn.Text = "CẤP QUYỀN CHO ROLE";
            this.cqcr_btn.UseVisualStyleBackColor = true;
            this.cqcr_btn.Click += new System.EventHandler(this.cqcr_btn_Click);
            // 
            // crcu_btn
            // 
            this.crcu_btn.Location = new System.Drawing.Point(159, 654);
            this.crcu_btn.Name = "crcu_btn";
            this.crcu_btn.Size = new System.Drawing.Size(450, 199);
            this.crcu_btn.TabIndex = 2;
            this.crcu_btn.Text = "CẤP ROLE CHO USER";
            this.crcu_btn.UseVisualStyleBackColor = true;
            this.crcu_btn.Click += new System.EventHandler(this.crcu_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(1, 925);
            this.back_btn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 77);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "⬅";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // cqOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(752, 1003);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.crcu_btn);
            this.Controls.Add(this.cqcr_btn);
            this.Controls.Add(this.cqcu_btn);
            this.Name = "cqOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỰA CHỌN CẤP QUYỀN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cqcu_btn;
        private System.Windows.Forms.Button cqcr_btn;
        private System.Windows.Forms.Button crcu_btn;
        private System.Windows.Forms.Button back_btn;
    }
}