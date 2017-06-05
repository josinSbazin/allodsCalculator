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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownDoubleR = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownVU = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxSKU = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoubleR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVU)).BeginInit();
			this.SuspendLayout();
			// 
			// stateInputLabel1
			// 
			this.stateInputLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stateInputLabel1.AutoSize = true;
			this.stateInputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stateInputLabel1.Location = new System.Drawing.Point(91, 125);
			this.stateInputLabel1.Name = "stateInputLabel1";
			this.stateInputLabel1.Size = new System.Drawing.Size(145, 13);
			this.stateInputLabel1.TabIndex = 0;
			this.stateInputLabel1.Text = "Введите сумму статов:";
			this.stateInputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.stateInputLabel1.Click += new System.EventHandler(this.stateInputLabel1_Click);
			// 
			// stateInputLabel2
			// 
			this.stateInputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stateInputLabel2.Location = new System.Drawing.Point(-1, 138);
			this.stateInputLabel2.Name = "stateInputLabel2";
			this.stateInputLabel2.Size = new System.Drawing.Size(334, 13);
			this.stateInputLabel2.TabIndex = 1;
			this.stateInputLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(61, 23);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(210, 21);
			this.comboBox.TabIndex = 2;
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(106, 189);
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
			this.button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button.Location = new System.Drawing.Point(106, 215);
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
			this.text.Location = new System.Drawing.Point(12, 241);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(310, 207);
			this.text.TabIndex = 5;
			this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(117, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Выберите класс";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(24, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(286, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Введите средний уровень решимости в бою %:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// numericUpDownDoubleR
			// 
			this.numericUpDownDoubleR.Location = new System.Drawing.Point(106, 63);
			this.numericUpDownDoubleR.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownDoubleR.Name = "numericUpDownDoubleR";
			this.numericUpDownDoubleR.Size = new System.Drawing.Size(115, 20);
			this.numericUpDownDoubleR.TabIndex = 8;
			// 
			// numericUpDownVU
			// 
			this.numericUpDownVU.Location = new System.Drawing.Point(106, 102);
			this.numericUpDownVU.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numericUpDownVU.Name = "numericUpDownVU";
			this.numericUpDownVU.Size = new System.Drawing.Size(115, 20);
			this.numericUpDownVU.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(24, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(280, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Введите долю превосходящего вида урона %:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBoxSKU
			// 
			this.checkBoxSKU.AutoSize = true;
			this.checkBoxSKU.Location = new System.Drawing.Point(94, 166);
			this.checkBoxSKU.Name = "checkBoxSKU";
			this.checkBoxSKU.Size = new System.Drawing.Size(134, 17);
			this.checkBoxSKU.TabIndex = 11;
			this.checkBoxSKU.Text = "С учетом Силы Крита";
			this.checkBoxSKU.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 462);
			this.Controls.Add(this.checkBoxSKU);
			this.Controls.Add(this.numericUpDownVU);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numericUpDownDoubleR);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.text);
			this.Controls.Add(this.button);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.stateInputLabel2);
			this.Controls.Add(this.stateInputLabel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(350, 500);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(350, 500);
			this.Name = "MainWindow";
			this.Text = "Калькулятор статов (Аллоды 8.1)";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoubleR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVU)).EndInit();
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.NumericUpDown numericUpDownDoubleR;
		public System.Windows.Forms.NumericUpDown numericUpDownVU;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.CheckBox checkBoxSKU;
	}
}