namespace FastFoodSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelFastFoodZone = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOrderForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFastFoodZone
            // 
            this.labelFastFoodZone.AutoSize = true;
            this.labelFastFoodZone.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFastFoodZone.Location = new System.Drawing.Point(288, 25);
            this.labelFastFoodZone.Name = "labelFastFoodZone";
            this.labelFastFoodZone.Size = new System.Drawing.Size(417, 70);
            this.labelFastFoodZone.TabIndex = 0;
            this.labelFastFoodZone.Text = "Fast Food Zone";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOrderForm
            // 
            this.buttonOrderForm.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderForm.Location = new System.Drawing.Point(637, 233);
            this.buttonOrderForm.Name = "buttonOrderForm";
            this.buttonOrderForm.Size = new System.Drawing.Size(249, 157);
            this.buttonOrderForm.TabIndex = 2;
            this.buttonOrderForm.Text = "Order Form";
            this.buttonOrderForm.UseVisualStyleBackColor = true;
            this.buttonOrderForm.Click += new System.EventHandler(this.ButtonOrderForm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 508);
            this.Controls.Add(this.buttonOrderForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFastFoodZone);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFastFoodZone;
        private PictureBox pictureBox1;
        private Button buttonOrderForm;
        private EventHandler buttonOrderForm_Click;
    }
}