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
				new AClass("Храмовник", false, 0.54),
				new AClass("Мистик", false, 0.75),
				new AClass("Язычник", true, 0.7),
				new AClass("Бард", true, 1.0),
				new AClass("Волшебник", false, 0.65),
				new AClass("Инженер", false, 0.6),
				new AClass("Некромант", false, 0.5),
				new AClass("Жрец", false, 0.55),
				new AClass("Воин", true, 1.0),
				new AClass("Разведчик", false, 0.5)
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

		private void RefreshDataFromClassAndSumm(AClass aClass, int summ)
		{
			if (aClass == null) return;

			int maxR = 0;
			int maxM = 0;
			int maxBU = 0;
			int maxSKU = 0;
			double D = 0.0;
			double maxD = 0.0;

			for (int M = 0; M <= summ / 2; M++)
			{
				for (int SKU = 0; ((aClass.hasSKU) && (SKU <= summ - M * 2) && (SKU <= 500)) || (SKU < 1); SKU++)
				{
					for (int BU = 0; (BU < summ - M * 2 - SKU) && (BU < 181); BU++)
					{
						int R = summ - M * 2 - BU - SKU;
						D = (1.0 + M * 0.001) * (1.0 + M * 0.001) * (1.0 + R * 0.0015 * 0.95) *
						    (1.0 + BU * 0.0018 * aClass.partDamage) * (1.0 + SKU * 0.001333);
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
			if (aClass.hasSKU)
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

			RefreshDataFromClassAndSumm(selectedAClass, sum);
		}
	}
}