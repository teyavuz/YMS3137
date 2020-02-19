namespace WFA_EntityFramework
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstConnected = new System.Windows.Forms.ListBox();
            this.lstDisconected = new System.Windows.Forms.ListBox();
            this.lstEf = new System.Windows.Forms.ListBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblDiconnected = new System.Windows.Forms.Label();
            this.lblEf = new System.Windows.Forms.Label();
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.btnEntityFramework = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(289, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "DisConnected";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(533, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "EntityFramework";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstConnected
            // 
            this.lstConnected.FormattingEnabled = true;
            this.lstConnected.Location = new System.Drawing.Point(46, 66);
            this.lstConnected.Name = "lstConnected";
            this.lstConnected.Size = new System.Drawing.Size(226, 381);
            this.lstConnected.TabIndex = 1;
            // 
            // lstDisconected
            // 
            this.lstDisconected.FormattingEnabled = true;
            this.lstDisconected.Location = new System.Drawing.Point(289, 66);
            this.lstDisconected.Name = "lstDisconected";
            this.lstDisconected.Size = new System.Drawing.Size(226, 381);
            this.lstDisconected.TabIndex = 1;
            // 
            // lstEf
            // 
            this.lstEf.FormattingEnabled = true;
            this.lstEf.Location = new System.Drawing.Point(533, 66);
            this.lstEf.Name = "lstEf";
            this.lstEf.Size = new System.Drawing.Size(226, 381);
            this.lstEf.TabIndex = 1;
            // 
            // lblConnected
            // 
            this.lblConnected.BackColor = System.Drawing.Color.LightGreen;
            this.lblConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConnected.Location = new System.Drawing.Point(46, 450);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(226, 43);
            this.lblConnected.TabIndex = 0;
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiconnected
            // 
            this.lblDiconnected.BackColor = System.Drawing.Color.Tomato;
            this.lblDiconnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiconnected.Location = new System.Drawing.Point(289, 450);
            this.lblDiconnected.Name = "lblDiconnected";
            this.lblDiconnected.Size = new System.Drawing.Size(226, 43);
            this.lblDiconnected.TabIndex = 0;
            this.lblDiconnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEf
            // 
            this.lblEf.BackColor = System.Drawing.Color.SkyBlue;
            this.lblEf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEf.Location = new System.Drawing.Point(533, 450);
            this.lblEf.Name = "lblEf";
            this.lblEf.Size = new System.Drawing.Size(226, 43);
            this.lblEf.TabIndex = 0;
            this.lblEf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnected
            // 
            this.btnConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnected.Location = new System.Drawing.Point(46, 496);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(226, 42);
            this.btnConnected.TabIndex = 2;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnected.Location = new System.Drawing.Point(289, 496);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(226, 42);
            this.btnDisconnected.TabIndex = 2;
            this.btnDisconnected.Text = "DisConnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnEntityFramework
            // 
            this.btnEntityFramework.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntityFramework.Location = new System.Drawing.Point(533, 496);
            this.btnEntityFramework.Name = "btnEntityFramework";
            this.btnEntityFramework.Size = new System.Drawing.Size(226, 42);
            this.btnEntityFramework.TabIndex = 2;
            this.btnEntityFramework.Text = "Entity Framework";
            this.btnEntityFramework.UseVisualStyleBackColor = true;
            this.btnEntityFramework.Click += new System.EventHandler(this.btnEntityFramework_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 556);
            this.Controls.Add(this.btnEntityFramework);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.lstEf);
            this.Controls.Add(this.lstDisconected);
            this.Controls.Add(this.lstConnected);
            this.Controls.Add(this.lblEf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDiconnected);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstConnected;
        private System.Windows.Forms.ListBox lstDisconected;
        private System.Windows.Forms.ListBox lstEf;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblDiconnected;
        private System.Windows.Forms.Label lblEf;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnEntityFramework;
    }
}

