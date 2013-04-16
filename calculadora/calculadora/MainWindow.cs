using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnsumarClicked (object sender, EventArgs e)
	{


		int numero1 = int.Parse(entry1.Text);
		int numero2 = int.Parse(entry2.Text);

			int numero3 = numero1 + numero2;
			
	 			entry3.Text = numero3.ToString();

	}


	protected void OnBtnrestarClicked (object sender, EventArgs e)
	{
		
		int numero1 = int.Parse(entry1.Text);
		int numero2 = int.Parse(entry2.Text);
		
			int numero3 = numero1 - numero2;
		
				entry3.Text = numero3.ToString();
	}

	protected void OnBtnmultiplicarClicked (object sender, EventArgs e)
	{
		
		int numero1 = int.Parse(entry1.Text);
		int numero2 = int.Parse(entry2.Text);
		
			int numero3 = numero1 * numero2;
		
				entry3.Text = numero3.ToString();
	}

	protected void OnBtndividirClicked (object sender, EventArgs e)
	{
		
		int numero1 = int.Parse(entry1.Text);
		int numero2 = int.Parse(entry2.Text);
		
			int numero3 = numero1 / numero2;
		
				entry3.Text = numero3.ToString();
	}
}


