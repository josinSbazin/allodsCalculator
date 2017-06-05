using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AllodsCalc
{
	public class Controller
	{
		private MainWindow view;
		private AClass selectedClass;

		public Controller(Form view)
		{
			this.view = (MainWindow) view;
			Initialize();
		}

		private void Initialize()
		{
			AClass[] classes =
			{
				new AClass("Храмовник", false),
				new AClass("Мистик", false),
				new AClass("Язычник", true),
				new AClass("Бард", true),
				new AClass("Волшебник", false),
				new AClass("Инженер", false),
				new AClass("Некромант", false),
				new AClass("Жрец", false),
				new AClass("Воин", true),
				new AClass("Разведчик", false)
			};

			view.comboBox.Items.AddRange(classes);
			view.comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
			view.comboBox.SelectedItem = view.comboBox.Items[0];
			view.Invalidate();
		}

		private void ComboBox_SelectedIndexChanged(object sender,
			System.EventArgs e)
		{
			selectedClass = (AClass) view.comboBox.SelectedItem;
			SetSpecialsText(selectedClass);
		}

		private void SetSpecialsText(AClass aClass)
		{
			if (aClass == null) return;

			view.stateInputLabel2.Text
				= aClass.hasSKU
					? "(С учетом основной специальной характеристики)"
					: "(Без учета основной специальной характеристики)";
		}

		private void RefreshDataFromClassAndSumm(AClass aClass, int summ, int VU, int doubleR, bool hasSKUcheckBox)
		{
			if (aClass == null) return;

			bool hasSKU = aClass.hasSKU && hasSKUcheckBox;

			int maxR = 0;
			int maxM = 0;
			int maxBU = 0;
			int maxSKU = 0;
			double D = 0.0;
			double maxD = 0.0;

			for (int M = 0; M <= summ / 2; M++)
			{
				for (int SKU = 0; ((hasSKU) && (SKU <= summ - M * 2) && (SKU <= 500)) || (SKU < 1); SKU++)
				{
					for (int BU = 0; (BU < summ - M * 2 - SKU) && (BU < 181); BU++)
					{
						int R = summ - M * 2 - BU - SKU;
						D = (1.0D + M * 0.001D) * (1.0D + M * 0.001D) * (1.0D + R * 1.5E-5D * doubleR) 
							* (1.0D + BU * 1.8E-5D * VU) * (1.0D + SKU * 0.001333D);
						if (D > maxD)
						{
							maxD = D;
							maxR = R;
							maxM = M;
							maxBU = BU;
							maxSKU = SKU;
						}
					}
				}
			}

			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Максимальный коэфф. дамага = {maxD:N3}");
			sb.AppendLine();
			sb.AppendLine($"Коэфф. дамага при последнем расчете = {D:N3}");
			sb.AppendLine();
			if (hasSKU)
			{
				sb.AppendLine($"Сила крит урона = {maxSKU}");
				sb.AppendLine();
			}
			sb.AppendLine($"Вид урона = {maxBU}");
			sb.AppendLine();
			sb.AppendLine($"Беспощадность = {maxM}");
			sb.AppendLine();
			sb.AppendLine($"Мастерство = {maxM}");
			sb.AppendLine();
			sb.Append($"Решимость = {maxR}");
			

			view.text.Text = sb.ToString();
			view.Invalidate();
		}

		public void FireButtonClick()
		{
			AClass selectedAClass = (AClass) view.comboBox.SelectedItem;
			int sum = Convert.ToInt32(view.numericUpDown.Value);
			int VU = Convert.ToInt32(view.numericUpDownVU.Value);
			int doubleR = Convert.ToInt32(view.numericUpDownDoubleR.Value);
			bool hasSKUCheckBox = view.checkBoxSKU.Checked;

			RefreshDataFromClassAndSumm(selectedAClass, sum, VU, doubleR, hasSKUCheckBox);
		}
	}
}