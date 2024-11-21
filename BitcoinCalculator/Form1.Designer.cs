namespace BitcoinCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bitcoinamountinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tulemuslabel = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyselector
            // 
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "EEK"});
            this.currencyselector.Location = new System.Drawing.Point(607, 149);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(121, 21);
            this.currencyselector.TabIndex = 0;
            this.currencyselector.Text = "Vali Valuuta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Arvuta kurss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bitcoinamountinput
            // 
            this.bitcoinamountinput.Location = new System.Drawing.Point(607, 112);
            this.bitcoinamountinput.Name = "bitcoinamountinput";
            this.bitcoinamountinput.Size = new System.Drawing.Size(121, 20);
            this.bitcoinamountinput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(607, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta Bitcoini arv";
            // 
            // tulemuslabel
            // 
            this.tulemuslabel.AutoSize = true;
            this.tulemuslabel.BackColor = System.Drawing.Color.Transparent;
            this.tulemuslabel.ForeColor = System.Drawing.Color.Lime;
            this.tulemuslabel.Location = new System.Drawing.Point(607, 282);
            this.tulemuslabel.Name = "tulemuslabel";
            this.tulemuslabel.Size = new System.Drawing.Size(53, 13);
            this.tulemuslabel.TabIndex = 4;
            this.tulemuslabel.Text = "Tulemus: ";
            // 
            // resultlabel
            // 
            this.resultlabel.BackColor = System.Drawing.Color.Black;
            this.resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultlabel.ForeColor = System.Drawing.Color.Lime;
            this.resultlabel.Location = new System.Drawing.Point(607, 298);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(121, 49);
            this.resultlabel.TabIndex = 5;
            this.resultlabel.Text = "Pole";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.tulemuslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinamountinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyselector);
            this.Name = "Form1";
            this.Text = "BitcoinCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bitcoinamountinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tulemuslabel;
        private System.Windows.Forms.TextBox resultlabel;
    }
}

