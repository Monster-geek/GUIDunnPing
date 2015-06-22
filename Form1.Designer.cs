namespace GUIDunnPing
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbox_ip_start_2 = new System.Windows.Forms.TextBox();
            this.txtbox_ip_start_3 = new System.Windows.Forms.TextBox();
            this.txtbox_ip_start_4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset_start = new System.Windows.Forms.Button();
            this.txtbox_ip_start_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reset_end = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_ip_end_4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_ip_end_3 = new System.Windows.Forms.TextBox();
            this.txtbox_ip_end_2 = new System.Windows.Forms.TextBox();
            this.txtbox_ip_end_1 = new System.Windows.Forms.TextBox();
            this.txtboxresult = new System.Windows.Forms.RichTextBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_ip_start_2
            // 
            this.txtbox_ip_start_2.Location = new System.Drawing.Point(68, 29);
            this.txtbox_ip_start_2.MaxLength = 3;
            this.txtbox_ip_start_2.Name = "txtbox_ip_start_2";
            this.txtbox_ip_start_2.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_start_2.TabIndex = 1;
            // 
            // txtbox_ip_start_3
            // 
            this.txtbox_ip_start_3.Location = new System.Drawing.Point(130, 29);
            this.txtbox_ip_start_3.MaxLength = 3;
            this.txtbox_ip_start_3.Name = "txtbox_ip_start_3";
            this.txtbox_ip_start_3.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_start_3.TabIndex = 2;
            // 
            // txtbox_ip_start_4
            // 
            this.txtbox_ip_start_4.Location = new System.Drawing.Point(192, 30);
            this.txtbox_ip_start_4.MaxLength = 3;
            this.txtbox_ip_start_4.Name = "txtbox_ip_start_4";
            this.txtbox_ip_start_4.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_start_4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbox_ip_start_4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbox_ip_start_3);
            this.groupBox1.Controls.Add(this.btn_reset_start);
            this.groupBox1.Controls.Add(this.txtbox_ip_start_1);
            this.groupBox1.Controls.Add(this.txtbox_ip_start_2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plage de début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // btn_reset_start
            // 
            this.btn_reset_start.Location = new System.Drawing.Point(7, 71);
            this.btn_reset_start.Name = "btn_reset_start";
            this.btn_reset_start.Size = new System.Drawing.Size(75, 23);
            this.btn_reset_start.TabIndex = 4;
            this.btn_reset_start.Text = "Reset";
            this.btn_reset_start.UseVisualStyleBackColor = true;
            this.btn_reset_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox_ip_start_1
            // 
            this.txtbox_ip_start_1.Location = new System.Drawing.Point(6, 30);
            this.txtbox_ip_start_1.MaxLength = 3;
            this.txtbox_ip_start_1.Name = "txtbox_ip_start_1";
            this.txtbox_ip_start_1.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_start_1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reset_end);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtbox_ip_end_4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbox_ip_end_3);
            this.groupBox2.Controls.Add(this.txtbox_ip_end_2);
            this.groupBox2.Controls.Add(this.txtbox_ip_end_1);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plage de fin";
            // 
            // btn_reset_end
            // 
            this.btn_reset_end.Location = new System.Drawing.Point(9, 71);
            this.btn_reset_end.Name = "btn_reset_end";
            this.btn_reset_end.Size = new System.Drawing.Size(75, 23);
            this.btn_reset_end.TabIndex = 10;
            this.btn_reset_end.Text = "Reset";
            this.btn_reset_end.UseVisualStyleBackColor = true;
            this.btn_reset_end.Click += new System.EventHandler(this.btn_reset_end_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = ".";
            // 
            // txtbox_ip_end_4
            // 
            this.txtbox_ip_end_4.Location = new System.Drawing.Point(195, 29);
            this.txtbox_ip_end_4.MaxLength = 3;
            this.txtbox_ip_end_4.Name = "txtbox_ip_end_4";
            this.txtbox_ip_end_4.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_end_4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = ".";
            // 
            // txtbox_ip_end_3
            // 
            this.txtbox_ip_end_3.Location = new System.Drawing.Point(133, 30);
            this.txtbox_ip_end_3.MaxLength = 3;
            this.txtbox_ip_end_3.Name = "txtbox_ip_end_3";
            this.txtbox_ip_end_3.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_end_3.TabIndex = 2;
            // 
            // txtbox_ip_end_2
            // 
            this.txtbox_ip_end_2.Location = new System.Drawing.Point(71, 30);
            this.txtbox_ip_end_2.MaxLength = 3;
            this.txtbox_ip_end_2.Name = "txtbox_ip_end_2";
            this.txtbox_ip_end_2.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_end_2.TabIndex = 1;
            // 
            // txtbox_ip_end_1
            // 
            this.txtbox_ip_end_1.Location = new System.Drawing.Point(9, 29);
            this.txtbox_ip_end_1.MaxLength = 3;
            this.txtbox_ip_end_1.Name = "txtbox_ip_end_1";
            this.txtbox_ip_end_1.Size = new System.Drawing.Size(40, 20);
            this.txtbox_ip_end_1.TabIndex = 0;
            // 
            // txtboxresult
            // 
            this.txtboxresult.Location = new System.Drawing.Point(12, 160);
            this.txtboxresult.Name = "txtboxresult";
            this.txtboxresult.Size = new System.Drawing.Size(523, 243);
            this.txtboxresult.TabIndex = 6;
            this.txtboxresult.Text = "";
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(12, 129);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(523, 23);
            this.btn_scan.TabIndex = 7;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 415);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.txtboxresult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DunnPing v2 ™";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_ip_start_2;
        private System.Windows.Forms.TextBox txtbox_ip_start_3;
        private System.Windows.Forms.TextBox txtbox_ip_start_4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset_start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_reset_end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_ip_end_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_ip_end_3;
        private System.Windows.Forms.TextBox txtbox_ip_end_2;
        private System.Windows.Forms.TextBox txtbox_ip_end_1;
        private System.Windows.Forms.RichTextBox txtboxresult;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.TextBox txtbox_ip_start_1;
    }
}

