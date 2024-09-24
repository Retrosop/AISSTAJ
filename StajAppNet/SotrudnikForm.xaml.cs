using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestConnectDB;

namespace StajAppNet
{
	/// <summary>
	/// Логика взаимодействия для SotrudnikForm.xaml
	/// </summary>
	public partial class SotrudnikForm : Window
	{
		//int IdSelected = 0;
		//ObservableCollection<Sotrudnik> sotrudniks;
		public SotrudnikForm()
		{
		//	InitializeComponent();
		//	sotrudniks = new ObservableCollection<Sotrudnik>();
		//	sotrudnikList.SelectedIndex = IdSelected;
		//	using (DataContext db = new DataContext())
		//	{
		//		var glist = db.Sotrudnik.ToList();
		//		foreach (Sotrudnik g in glist)
		//		{
		//			sotrudniks.Add(g);
		//		}

		//		sotrudnikList.ItemsSource = sotrudniks;
		//		if (IdSelected != 0)
		//		{
		//			var t = db.Sotrudnik
		//				.Where(c => c.Id == (sotrudnikList.SelectedItems[0] as Sotrudnik).Id)
		//				.FirstOrDefault();
		//			InputFio.Text = t.Fio;
		//			InputFioBeforeMarry.Text = t.FioBeforeMarry;
		//			InputAge.Text = t.Age.ToString();
		//			InputPol.IsChecked = t.Pol;
		//			InputMarry.IsChecked = t.Marry;
		//			InputDater.Text = t.Dater.ToString("dd.MM.yyyy");
		//		}
		//	}
		}

		//Добавление записи
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//using (DataContext db = new DataContext())
			//{
			//	Sotrudnik sotrudnik = new Sotrudnik();
			//	sotrudnik.Fio = InputFio.Text;
			//	sotrudnik.FioBeforeMarry = InputFioBeforeMarry.Text;
			//	sotrudnik.Dater = DateTime.Parse(InputDater.Text);
			//	sotrudnik.Pol = InputPol.IsChecked;
			//	sotrudnik.Age = int.Parse(InputAge.Text);
			//	sotrudnik.Marry = InputMarry.IsChecked;

			//	try
			//	{
			//		db.Sotrudnik.Add(sotrudnik);
			//		db.SaveChanges();
			//	}
			//	catch (FormatException)
			//	{
			//		//MessageBox.Show("{0}: Неправильно введен возраст", InputAge.Text);
			//	}
			//	//==================
			//	sotrudniks.Clear();
			//	var glist = db.Sotrudnik.ToList();
			//	foreach (Sotrudnik g1 in glist)
			//	{
			//		sotrudniks.Add(g1);
			//	}
			//	sotrudnikList.ItemsSource = sotrudniks;
			//	//==================

			//}
		}
		//Выделение записи левой кнопкой мыши
		private void MouseClick(object sender, MouseButtonEventArgs e)
		{
			//IdSelected = sotrudnikList.SelectedIndex;

			//using (var db = new DataContext())
			//{
			//	if (sotrudnikList.SelectedIndex == -1)
			//	{
			//		MessageBox.Show("Выделите запись");
			//	} else 
			//	{
			//		Sotrudnik t = db.Sotrudnik
			//						.Where(c => c.Id == (sotrudnikList.SelectedItems[0] as Sotrudnik).Id).FirstOrDefault();
			//		InputFio.Text = t.Fio;
			//		InputFioBeforeMarry.Text = t.FioBeforeMarry;
			//		InputAge.Text = t.Age.ToString();
			//		InputPol.IsChecked = t.Pol;
			//		InputMarry.IsChecked = t.Marry;
			//		InputDater.Text = t.Dater.ToString("dd.MM.yyyy");
			//	}
			//}
		}

		//Удаление записи
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			//if (sotrudnikList.SelectedIndex == -1)
			//{
			//	MessageBox.Show("Выделите запись");
			//}
			//else
			//{
			//	MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись"
			//		, "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
			//	if (dialogResult == MessageBoxResult.Yes)
			//	{
			//		using (var db = new DataContext())
			//		{
			//			Sotrudnik t = db.Sotrudnik
			//							.Where(c => c.Id == (sotrudnikList.SelectedItems[0] as Sotrudnik).Id).FirstOrDefault();
			//			db.Sotrudnik.Remove(t);
			//			db.SaveChanges();

			//			//==================
			//			sotrudniks.Clear();
			//			var glist = db.Sotrudnik.ToList();
			//			foreach (Sotrudnik g1 in glist)
			//			{
			//				sotrudniks.Add(g1);
			//			}
			//			sotrudnikList.ItemsSource = sotrudniks;
			//			//==================
			//		}
			//	}
			//}
		}

		//Обновление записей
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			//if (sotrudnikList.SelectedIndex == -1)
			//{
			//	MessageBox.Show("Выделите запись");
			//}
			//else
			//{
			//	using (var db = new DataContext())
			//	{
			//		Sotrudnik t = db.Sotrudnik
			//						.Where(c => c.Id == (sotrudnikList.SelectedItems[0] as Sotrudnik).Id).FirstOrDefault();

			//		t.Fio = InputFio.Text;
			//		t.FioBeforeMarry = InputFioBeforeMarry.Text;
			//		t.Age = int.Parse(InputAge.Text);
			//		t.Pol = InputPol.IsChecked;
			//		t.Marry = InputMarry.IsChecked;
			//		t.Dater = DateTime.Parse(InputDater.Text);


			//		db.SaveChanges();

			//		//==================
			//		sotrudniks.Clear();
			//		var glist = db.Sotrudnik.ToList();
			//		foreach (Sotrudnik g1 in glist)
			//		{
			//			sotrudniks.Add(g1);
			//		}
			//		sotrudnikList.ItemsSource = sotrudniks;
			//		//==================
			//	}
			//}
		}
	}
}


