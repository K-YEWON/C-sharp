
namespace Calculator_pro
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Numbutton1 = new System.Windows.Forms.Button();
            this.Numbutton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumPlus = new System.Windows.Forms.Button();
            this.Numbutton3 = new System.Windows.Forms.Button();
            this.Numbutton4 = new System.Windows.Forms.Button();
            this.Numbutton5 = new System.Windows.Forms.Button();
            this.Numbutton6 = new System.Windows.Forms.Button();
            this.Numbutton7 = new System.Windows.Forms.Button();
            this.Numbutton8 = new System.Windows.Forms.Button();
            this.Numbutton9 = new System.Windows.Forms.Button();
            this.Numbutton0 = new System.Windows.Forms.Button();
            this.ButtonSub = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.ButtonMulti = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Numbutton1
            // 
            this.Numbutton1.Location = new System.Drawing.Point(27, 369);
            this.Numbutton1.Name = "Numbutton1";
            this.Numbutton1.Size = new System.Drawing.Size(75, 66);
            this.Numbutton1.TabIndex = 0;
            this.Numbutton1.Text = "1";
            this.Numbutton1.UseVisualStyleBackColor = true;
            this.Numbutton1.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton2
            // 
            this.Numbutton2.Location = new System.Drawing.Point(132, 369);
            this.Numbutton2.Name = "Numbutton2";
            this.Numbutton2.Size = new System.Drawing.Size(75, 66);
            this.Numbutton2.TabIndex = 0;
            this.Numbutton2.Text = "2";
            this.Numbutton2.UseVisualStyleBackColor = true;
            this.Numbutton2.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(23, 27);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(387, 54);
            this.NumScreen.TabIndex = 1;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NumPlus
            // 
            this.NumPlus.Location = new System.Drawing.Point(335, 455);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(75, 66);
            this.NumPlus.TabIndex = 2;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // Numbutton3
            // 
            this.Numbutton3.Location = new System.Drawing.Point(233, 369);
            this.Numbutton3.Name = "Numbutton3";
            this.Numbutton3.Size = new System.Drawing.Size(75, 66);
            this.Numbutton3.TabIndex = 0;
            this.Numbutton3.Text = "3";
            this.Numbutton3.UseVisualStyleBackColor = true;
            this.Numbutton3.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton4
            // 
            this.Numbutton4.Location = new System.Drawing.Point(27, 278);
            this.Numbutton4.Name = "Numbutton4";
            this.Numbutton4.Size = new System.Drawing.Size(75, 66);
            this.Numbutton4.TabIndex = 0;
            this.Numbutton4.Text = "4";
            this.Numbutton4.UseVisualStyleBackColor = true;
            this.Numbutton4.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton5
            // 
            this.Numbutton5.Location = new System.Drawing.Point(132, 278);
            this.Numbutton5.Name = "Numbutton5";
            this.Numbutton5.Size = new System.Drawing.Size(75, 66);
            this.Numbutton5.TabIndex = 0;
            this.Numbutton5.Text = "5";
            this.Numbutton5.UseVisualStyleBackColor = true;
            this.Numbutton5.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton6
            // 
            this.Numbutton6.Location = new System.Drawing.Point(233, 278);
            this.Numbutton6.Name = "Numbutton6";
            this.Numbutton6.Size = new System.Drawing.Size(75, 66);
            this.Numbutton6.TabIndex = 0;
            this.Numbutton6.Text = "6";
            this.Numbutton6.UseVisualStyleBackColor = true;
            this.Numbutton6.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton7
            // 
            this.Numbutton7.Location = new System.Drawing.Point(27, 187);
            this.Numbutton7.Name = "Numbutton7";
            this.Numbutton7.Size = new System.Drawing.Size(75, 66);
            this.Numbutton7.TabIndex = 0;
            this.Numbutton7.Text = "7";
            this.Numbutton7.UseVisualStyleBackColor = true;
            this.Numbutton7.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton8
            // 
            this.Numbutton8.Location = new System.Drawing.Point(132, 187);
            this.Numbutton8.Name = "Numbutton8";
            this.Numbutton8.Size = new System.Drawing.Size(75, 66);
            this.Numbutton8.TabIndex = 0;
            this.Numbutton8.Text = "8";
            this.Numbutton8.UseVisualStyleBackColor = true;
            this.Numbutton8.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton9
            // 
            this.Numbutton9.Location = new System.Drawing.Point(233, 187);
            this.Numbutton9.Name = "Numbutton9";
            this.Numbutton9.Size = new System.Drawing.Size(75, 66);
            this.Numbutton9.TabIndex = 0;
            this.Numbutton9.Text = "9";
            this.Numbutton9.UseVisualStyleBackColor = true;
            this.Numbutton9.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // Numbutton0
            // 
            this.Numbutton0.Location = new System.Drawing.Point(132, 455);
            this.Numbutton0.Name = "Numbutton0";
            this.Numbutton0.Size = new System.Drawing.Size(75, 66);
            this.Numbutton0.TabIndex = 0;
            this.Numbutton0.Text = "0";
            this.Numbutton0.UseVisualStyleBackColor = true;
            this.Numbutton0.Click += new System.EventHandler(this.Numbutton1_Click);
            // 
            // ButtonSub
            // 
            this.ButtonSub.Location = new System.Drawing.Point(335, 369);
            this.ButtonSub.Name = "ButtonSub";
            this.ButtonSub.Size = new System.Drawing.Size(75, 66);
            this.ButtonSub.TabIndex = 2;
            this.ButtonSub.Text = "-";
            this.ButtonSub.UseVisualStyleBackColor = true;
            this.ButtonSub.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(335, 187);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 66);
            this.buttonDiv.TabIndex = 2;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // ButtonMulti
            // 
            this.ButtonMulti.Location = new System.Drawing.Point(335, 278);
            this.ButtonMulti.Name = "ButtonMulti";
            this.ButtonMulti.Size = new System.Drawing.Size(75, 66);
            this.ButtonMulti.TabIndex = 2;
            this.ButtonMulti.Text = "*";
            this.ButtonMulti.UseVisualStyleBackColor = true;
            this.ButtonMulti.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(233, 103);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 66);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(335, 103);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(75, 66);
            this.buttonEqual.TabIndex = 2;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 649);
            this.Controls.Add(this.ButtonMulti);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.ButtonSub);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.Numbutton9);
            this.Controls.Add(this.Numbutton6);
            this.Controls.Add(this.Numbutton8);
            this.Controls.Add(this.Numbutton5);
            this.Controls.Add(this.Numbutton7);
            this.Controls.Add(this.Numbutton4);
            this.Controls.Add(this.Numbutton3);
            this.Controls.Add(this.Numbutton0);
            this.Controls.Add(this.Numbutton2);
            this.Controls.Add(this.Numbutton1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Numbutton1;
        private System.Windows.Forms.Button Numbutton2;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumPlus;
        private System.Windows.Forms.Button Numbutton3;
        private System.Windows.Forms.Button Numbutton4;
        private System.Windows.Forms.Button Numbutton5;
        private System.Windows.Forms.Button Numbutton6;
        private System.Windows.Forms.Button Numbutton7;
        private System.Windows.Forms.Button Numbutton8;
        private System.Windows.Forms.Button Numbutton9;
        private System.Windows.Forms.Button Numbutton0;
        private System.Windows.Forms.Button ButtonSub;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button ButtonMulti;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEqual;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

