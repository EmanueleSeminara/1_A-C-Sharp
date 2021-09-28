
namespace _1_A_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_text = new System.Windows.Forms.Button();
            this.button_startStop = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            this.pictureBox_rectangle = new System.Windows.Forms.PictureBox();
            this.pictureBox_ball = new System.Windows.Forms.PictureBox();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // button_text
            // 
            this.button_text.Location = new System.Drawing.Point(12, 71);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(75, 23);
            this.button_text.TabIndex = 0;
            this.button_text.Text = "Text";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // button_startStop
            // 
            this.button_startStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_startStop.Location = new System.Drawing.Point(12, 173);
            this.button_startStop.Name = "button_startStop";
            this.button_startStop.Size = new System.Drawing.Size(75, 23);
            this.button_startStop.TabIndex = 1;
            this.button_startStop.Text = "Start";
            this.button_startStop.UseVisualStyleBackColor = true;
            this.button_startStop.Click += new System.EventHandler(this.button_startStop_Click);
            // 
            // label_speed
            // 
            this.label_speed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_speed.AutoSize = true;
            this.label_speed.Location = new System.Drawing.Point(28, 205);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(38, 13);
            this.label_speed.TabIndex = 2;
            this.label_speed.Text = "Speed";
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_speed.Location = new System.Drawing.Point(12, 221);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(75, 21);
            this.comboBox_speed.TabIndex = 3;
            this.comboBox_speed.Text = "1";
            this.comboBox_speed.SelectedIndexChanged += new System.EventHandler(this.comboBox_speed_SelectedIndexChanged);
            // 
            // pictureBox_rectangle
            // 
            this.pictureBox_rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_rectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_rectangle.Location = new System.Drawing.Point(93, 159);
            this.pictureBox_rectangle.Name = "pictureBox_rectangle";
            this.pictureBox_rectangle.Size = new System.Drawing.Size(288, 189);
            this.pictureBox_rectangle.TabIndex = 4;
            this.pictureBox_rectangle.TabStop = false;
            // 
            // pictureBox_ball
            // 
            this.pictureBox_ball.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ball.Image")));
            this.pictureBox_ball.Location = new System.Drawing.Point(94, 160);
            this.pictureBox_ball.Name = "pictureBox_ball";
            this.pictureBox_ball.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_ball.TabIndex = 5;
            this.pictureBox_ball.TabStop = false;
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_text.Location = new System.Drawing.Point(93, 12);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(288, 141);
            this.richTextBox_text.TabIndex = 6;
            this.richTextBox_text.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 360);
            this.Controls.Add(this.richTextBox_text);
            this.Controls.Add(this.pictureBox_ball);
            this.Controls.Add(this.pictureBox_rectangle);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.button_startStop);
            this.Controls.Add(this.button_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "1_A C#";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_text;
        private System.Windows.Forms.Button button_startStop;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.ComboBox comboBox_speed;
        private System.Windows.Forms.PictureBox pictureBox_rectangle;
        private System.Windows.Forms.PictureBox pictureBox_ball;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private System.Windows.Forms.Timer timer1;
    }
}

