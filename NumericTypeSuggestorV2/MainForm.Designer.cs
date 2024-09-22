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
            integralCheckBox = new CheckBox();
            mustBePreciseCheckBox = new CheckBox();
            label1 = new Label();
            resultOutput = new Label();
            minValueInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            maxValueInput = new TextBox();
            SuspendLayout();
            // 
            // integralCheckBox
            // 
            integralCheckBox.AutoSize = true;
            integralCheckBox.Font = new Font("MADE TOMMY", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            integralCheckBox.Location = new Point(79, 120);
            integralCheckBox.Name = "integralCheckBox";
            integralCheckBox.Size = new Size(133, 24);
            integralCheckBox.TabIndex = 0;
            integralCheckBox.Text = "Integral only?";
            integralCheckBox.UseVisualStyleBackColor = true;
            integralCheckBox.CheckedChanged += integralCheckBox_CheckedChanged;
            // 
            // mustBePreciseCheckBox
            // 
            mustBePreciseCheckBox.AutoSize = true;
            mustBePreciseCheckBox.Font = new Font("MADE TOMMY", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mustBePreciseCheckBox.Location = new Point(79, 150);
            mustBePreciseCheckBox.Name = "mustBePreciseCheckBox";
            mustBePreciseCheckBox.Size = new Size(161, 24);
            mustBePreciseCheckBox.TabIndex = 1;
            mustBePreciseCheckBox.Text = "Must be Precise? ";
            mustBePreciseCheckBox.UseVisualStyleBackColor = true;
            mustBePreciseCheckBox.CheckedChanged += mustBePreciseCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(5, 192);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "Suggested Type:";
            // 
            // resultOutput
            // 
            resultOutput.AutoSize = true;
            resultOutput.Font = new Font("MADE TOMMY", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultOutput.Location = new Point(183, 194);
            resultOutput.Name = "resultOutput";
            resultOutput.Size = new Size(182, 26);
            resultOutput.TabIndex = 3;
            resultOutput.Tag = "resultOutput";
            resultOutput.Text = "Not enough Data";
            // 
            // minValueInput
            // 
            minValueInput.Location = new Point(183, 40);
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
            label3.Location = new Point(57, 39);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 5;
            label3.Text = "Min. Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MADE TOMMY", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 77);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 6;
            label4.Text = "Min. Value";
            // 
            // maxValueInput
            // 
            maxValueInput.Location = new Point(183, 80);
            maxValueInput.Name = "maxValueInput";
            maxValueInput.Size = new Size(195, 23);
            maxValueInput.TabIndex = 7;
            maxValueInput.TextChanged += maxValueInput_TextChanged;
            maxValueInput.KeyPress += maxValueInput_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(393, 236);
            Controls.Add(maxValueInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(minValueInput);
            Controls.Add(resultOutput);
            Controls.Add(label1);
            Controls.Add(mustBePreciseCheckBox);
            Controls.Add(integralCheckBox);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox integralCheckBox;
        private CheckBox mustBePreciseCheckBox;
        private Label label1;
        private Label resultOutput;
        private TextBox minValueInput;
        private Label label3;
        private Label label4;
        private TextBox maxValueInput;
    }
}
