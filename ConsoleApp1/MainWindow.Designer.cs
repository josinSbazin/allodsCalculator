namespace AllodsCalc
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.stateInputLabel1 = new System.Windows.Forms.Label();
			this.stateInputLabel2 = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.button = new System.Windows.Forms.Button();
			this.text = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// stateInputLabel1
			// 
			this.stateInputLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stateInputLabel1.AutoSize = true;
			this.stateInputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stateInputLabel1.Location = new System.Drawing.Point(91, 9);
			this.stateInputLabel1.Name = "stateInputLabel1";
			this.stateInputLabel1.Size = new System.Drawing.Size(145, 13);
			this.stateInputLabel1.TabIndex = 0;
			this.stateInputLabel1.Text = "Введите сумму статов:";
			this.stateInputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stateInputLabel2
			// 
			this.stateInputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stateInputLabel2.Location = new System.Drawing.Point(0, 22);
			this.stateInputLabel2.Name = "stateInputLabel2";
			this.stateInputLabel2.Size = new System.Drawing.Size(334, 13);
			this.stateInputLabel2.TabIndex = 1;
			this.stateInputLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(60, 38);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(210, 21);
			this.comboBox.TabIndex = 2;
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(106, 65);
			this.numericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(115, 20);
			this.numericUpDown.TabIndex = 3;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(106, 91);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(115, 23);
			this.button.TabIndex = 4;
			this.button.Text = "Вычислить";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// text
			// 
			this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.text.Location = new System.Drawing.Point(12, 129);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(310, 174);
			this.text.TabIndex = 5;
			this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 312);
			this.Controls.Add(this.text);
			this.Controls.Add(this.button);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.stateInputLabel2);
			this.Controls.Add(this.stateInputLabel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(350, 350);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(350, 350);
			this.Name = "MainWindow";
			this.Text = "Калькулятор статов (Аллоды 8.1)";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label stateInputLabel1;
		public System.Windows.Forms.Label stateInputLabel2;
		public System.Windows.Forms.ComboBox comboBox;
		public System.Windows.Forms.NumericUpDown numericUpDown;
		public System.Windows.Forms.Button button;
		public System.Windows.Forms.Label text;
	}
}