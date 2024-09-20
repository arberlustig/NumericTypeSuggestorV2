namespace NumericTypeSuggestorV2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            minValueInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            maxValueInput = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("MADE TOMMY", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(121, 137);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Integral only?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("MADE TOMMY", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(121, 167);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(161, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Must be Precise? ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(47, 209);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "Suggested Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MADE TOMMY", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 211);
            label2.Name = "label2";
            label2.Size = new Size(182, 26);
            label2.TabIndex = 3;
            label2.Tag = "resultOutput";
            label2.Text = "Not enough Data";
            // 
            // minValueInput
            // 
            minValueInput.Location = new Point(225, 57);
            minValueInput.Name = "minValueInput";
            minValueInput.Size = new Size(195, 23);
            minValueInput.TabIndex = 4;
            minValueInput.TextChanged += minValueInput_TextChanged;
            minValueInput.KeyPress += minValueInput_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MADE TOMMY", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 56);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 5;
            label3.Text = "Min. Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MADE TOMMY", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 94);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 6;
            label4.Text = "Min. Value";
            // 
            // maxValueInput
            // 
            maxValueInput.Location = new Point(225, 97);
            maxValueInput.Name = "maxValueInput";
            maxValueInput.Size = new Size(195, 23);
            maxValueInput.TabIndex = 7;
            maxValueInput.TextChanged += minValueInput_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 292);
            Controls.Add(maxValueInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(minValueInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label label2;
        private TextBox minValueInput;
        private Label label3;
        private Label label4;
        private TextBox maxValueInput;
    }
}
