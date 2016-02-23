namespace SerialStepperControl
{
    partial class Rotator
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
            this.sendMove = new System.Windows.Forms.Button();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.label_Debug = new System.Windows.Forms.Label();
            this.label_Return = new System.Windows.Forms.Label();
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            this.button_Debug = new System.Windows.Forms.Button();
            this.label_CurPos = new System.Windows.Forms.Label();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendMove
            // 
            this.sendMove.Location = new System.Drawing.Point(12, 120);
            this.sendMove.Name = "sendMove";
            this.sendMove.Size = new System.Drawing.Size(100, 23);
            this.sendMove.TabIndex = 0;
            this.sendMove.Text = "Send";
            this.sendMove.UseVisualStyleBackColor = true;
            this.sendMove.Click += new System.EventHandler(this.SendMove_Click);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(13, 13);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 20);
            this.textBox_X.TabIndex = 1;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(13, 40);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y.TabIndex = 2;
            // 
            // textBox_Z
            // 
            this.textBox_Z.Location = new System.Drawing.Point(13, 67);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(100, 20);
            this.textBox_Z.TabIndex = 3;
            // 
            // label_Debug
            // 
            this.label_Debug.Location = new System.Drawing.Point(119, 40);
            this.label_Debug.Name = "label_Debug";
            this.label_Debug.Size = new System.Drawing.Size(153, 103);
            this.label_Debug.TabIndex = 4;
            // 
            // label_Return
            // 
            this.label_Return.Location = new System.Drawing.Point(12, 146);
            this.label_Return.Name = "label_Return";
            this.label_Return.Size = new System.Drawing.Size(260, 55);
            this.label_Return.TabIndex = 5;
            this.label_Return.Text = "Return";
            this.label_Return.Click += new System.EventHandler(this.label_Return_Click);
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.Location = new System.Drawing.Point(15, 204);
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.Size = new System.Drawing.Size(257, 20);
            this.textBox_Debug.TabIndex = 6;
            // 
            // button_Debug
            // 
            this.button_Debug.Location = new System.Drawing.Point(15, 230);
            this.button_Debug.Name = "button_Debug";
            this.button_Debug.Size = new System.Drawing.Size(257, 23);
            this.button_Debug.TabIndex = 7;
            this.button_Debug.Text = "button1";
            this.button_Debug.UseVisualStyleBackColor = true;
            this.button_Debug.Click += new System.EventHandler(this.Button_Debug_Click);
            // 
            // label_CurPos
            // 
            this.label_CurPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurPos.Location = new System.Drawing.Point(119, 13);
            this.label_CurPos.Name = "label_CurPos";
            this.label_CurPos.Size = new System.Drawing.Size(153, 20);
            this.label_CurPos.TabIndex = 8;
            // 
            // textBox_S
            // 
            this.textBox_S.Enabled = false;
            this.textBox_S.Location = new System.Drawing.Point(13, 94);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(100, 20);
            this.textBox_S.TabIndex = 9;
            this.textBox_S.Text = "0";
            // 
            // Rotator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_S);
            this.Controls.Add(this.label_CurPos);
            this.Controls.Add(this.button_Debug);
            this.Controls.Add(this.textBox_Debug);
            this.Controls.Add(this.label_Return);
            this.Controls.Add(this.label_Debug);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.sendMove);
            this.Name = "Rotator";
            this.Text = "Rotator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMove;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.Label label_Debug;
        private System.Windows.Forms.Label label_Return;
        private System.Windows.Forms.TextBox textBox_Debug;
        private System.Windows.Forms.Button button_Debug;
        private System.Windows.Forms.Label label_CurPos;
        private System.Windows.Forms.TextBox textBox_S;
    }
}