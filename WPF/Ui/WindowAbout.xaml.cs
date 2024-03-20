//	Isomorophic MIDI Keyboard
//
//	Copyright © Sergey A Kryukov, 2017
//	http://www.SAKryukov.org
//	https://www.codeproject.com/Members/SAKryukov
//
//	Original publication:
//	"Musical Study with Isomorphic Computer Keyboard"
//	https://www.codeproject.com/Articles/1201737/Musical-Study-with-Isomorphic-Computer-Keyboard
//
namespace WPF.Ui {
	using System;
	using System.Windows;
	using System.Windows.Documents;
	using Process = System.Diagnostics.Process;

	public partial class WindowAbout : Window {

		public WindowAbout() {			
			InitializeComponent();
			var app = Main.TheApplication.Current;
			var version = app.AssemblyVersion;
			Title = app.ProductName;
			Icon = app.ApplicationIcon;
			buttonOk.Click += (sender, eventArgs) => { Hide(); };
			Info.Text = MidiOutApi.Api.SimpleApi.GetInfo();
		} //WindowAbout

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e) {
			e.Cancel = true;
			Hide();
		} //OnClosing

	} //class WindowAbout

} //namespace WPF.Ui 
