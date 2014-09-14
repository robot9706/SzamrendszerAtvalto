namespace SzamRendszerek
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.sourceSystem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.targetSystem = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.TextBox();
            this.cr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sourceSystem
            // 
            this.sourceSystem.BackColor = System.Drawing.Color.White;
            this.sourceSystem.Location = new System.Drawing.Point(139, 37);
            this.sourceSystem.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.sourceSystem.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sourceSystem.Name = "sourceSystem";
            this.sourceSystem.Size = new System.Drawing.Size(152, 22);
            this.sourceSystem.TabIndex = 3;
            this.sourceSystem.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sourceSystem.ValueChanged += new System.EventHandler(this.targetSystem_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Számrendszerből:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // targetSystem
            // 
            this.targetSystem.BackColor = System.Drawing.Color.White;
            this.targetSystem.Location = new System.Drawing.Point(139, 65);
            this.targetSystem.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.targetSystem.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.targetSystem.Name = "targetSystem";
            this.targetSystem.Size = new System.Drawing.Size(152, 22);
            this.targetSystem.TabIndex = 5;
            this.targetSystem.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.targetSystem.ValueChanged += new System.EventHandler(this.targetSystem_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Számrendszerbe:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eredmény:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(140, 95);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(151, 54);
            this.result.TabIndex = 8;
            // 
            // source
            // 
            this.source.BackColor = System.Drawing.Color.White;
            this.source.Location = new System.Drawing.Point(138, 9);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(152, 22);
            this.source.TabIndex = 9;
            this.source.Text = "0";
            this.source.TextChanged += new System.EventHandler(this.source_TextChanged);
            // 
            // cr
            // 
            this.cr.AutoSize = true;
            this.cr.ForeColor = System.Drawing.Color.LightGray;
            this.cr.Location = new System.Drawing.Point(177, 156);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(125, 16);
            this.cr.TabIndex = 10;
            this.cr.Text = "~robot9706 (c) 2013";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 178);
            this.Controls.Add(this.cr);
            this.Controls.Add(this.source);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targetSystem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourceSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számrendszerek";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sourceSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown targetSystem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.Label cr;
    }
}

