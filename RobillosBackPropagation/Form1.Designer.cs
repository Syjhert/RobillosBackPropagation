using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace RobillosBackPropagation
{
    partial class Form1
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
            input1 = new TextBox();
            createBPNNBtn = new Button();
            trainNNBtn = new Button();
            testBtn = new Button();
            input2 = new TextBox();
            output = new TextBox();
            input3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            input4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            outputRounded = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input1.Location = new Point(182, 117);
            input1.Margin = new Padding(3, 4, 3, 4);
            input1.Name = "input1";
            input1.Size = new Size(122, 39);
            input1.TabIndex = 0;
            // 
            // createBPNNBtn
            // 
            createBPNNBtn.Location = new Point(131, 361);
            createBPNNBtn.Margin = new Padding(3, 4, 3, 4);
            createBPNNBtn.Name = "createBPNNBtn";
            createBPNNBtn.Size = new Size(155, 63);
            createBPNNBtn.TabIndex = 3;
            createBPNNBtn.Text = "Create BPNN";
            createBPNNBtn.UseVisualStyleBackColor = true;
            createBPNNBtn.Click += createBtn_Click;
            // 
            // trainNNBtn
            // 
            trainNNBtn.Location = new Point(350, 361);
            trainNNBtn.Margin = new Padding(3, 4, 3, 4);
            trainNNBtn.Name = "trainNNBtn";
            trainNNBtn.Size = new Size(145, 63);
            trainNNBtn.TabIndex = 4;
            trainNNBtn.Text = "Train the NN";
            trainNNBtn.UseVisualStyleBackColor = true;
            trainNNBtn.Click += trainBtn_Click;
            // 
            // testBtn
            // 
            testBtn.Location = new Point(565, 361);
            testBtn.Margin = new Padding(3, 4, 3, 4);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(102, 63);
            testBtn.TabIndex = 5;
            testBtn.Text = "Test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // input2
            // 
            input2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input2.Location = new Point(182, 169);
            input2.Margin = new Padding(3, 4, 3, 4);
            input2.Name = "input2";
            input2.Size = new Size(122, 39);
            input2.TabIndex = 6;
            // 
            // output
            // 
            output.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            output.Location = new Point(339, 169);
            output.Margin = new Padding(3, 4, 3, 4);
            output.Name = "output";
            output.Size = new Size(405, 39);
            output.TabIndex = 7;
            // 
            // input3
            // 
            input3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input3.Location = new Point(182, 221);
            input3.Margin = new Padding(3, 4, 3, 4);
            input3.Name = "input3";
            input3.Size = new Size(122, 39);
            input3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Inputs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 136);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "Output";
            // 
            // input4
            // 
            input4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input4.Location = new Point(182, 273);
            input4.Margin = new Padding(3, 4, 3, 4);
            input4.Name = "input4";
            input4.Size = new Size(122, 39);
            input4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(145, 437);
            label4.Name = "label4";
            label4.Size = new Size(290, 37);
            label4.TabIndex = 13;
            label4.Text = "Training yield = 16 sets";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(145, 484);
            label5.Name = "label5";
            label5.Size = new Size(705, 37);
            label5.TabIndex = 14;
            label5.Text = "Min Number of HiddenNeurons = 1 (around 1500 epochs)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 531);
            label6.Name = "label6";
            label6.Size = new Size(768, 37);
            label6.TabIndex = 15;
            label6.Text = "Min Number of Epochs = around 50-100 (600 Hidden Neurons)";
            // 
            // outputRounded
            // 
            outputRounded.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputRounded.Location = new Point(486, 273);
            outputRounded.Margin = new Padding(3, 4, 3, 4);
            outputRounded.Name = "outputRounded";
            outputRounded.Size = new Size(102, 39);
            outputRounded.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 240);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 17;
            label1.Text = "Rounded Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(outputRounded);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(input4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(input3);
            Controls.Add(output);
            Controls.Add(input2);
            Controls.Add(testBtn);
            Controls.Add(trainNNBtn);
            Controls.Add(createBPNNBtn);
            Controls.Add(input1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1;
        private Button createBPNNBtn;
        private Button trainNNBtn;
        private Button testBtn;
        private TextBox input2;
        private TextBox output;
        private TextBox input3;
        private Label label2;
        private Label label3;
        private TextBox input4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox outputRounded;
        private Label label1;
    }
}