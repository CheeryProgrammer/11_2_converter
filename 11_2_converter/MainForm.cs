using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Converter;

namespace _11_2_converter
{
	public partial class MainForm : Form
	{
		private static readonly string digits_11 = "0123456789A";
		private static readonly string digits_2 = "01";
		private LinkedList<Conversion> _list = new LinkedList<Conversion>();
		private Direction _direction;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			cbDirection.SelectedIndex = 0;
			cbHistory.DisplayMember = "DisplayName";
			_direction = (Direction)cbDirection.SelectedIndex;
		}

		private void btnClearHistory_Click(object sender, EventArgs e)
		{
			_list.Clear();
			UpdateBindings();
		}

		private void UpdateBindings()
		{
			cbHistory.DataSource = new BindingList<Conversion>(_list.ToList());
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			var input = tbSource.Text.Trim().TrimStart('0').ToUpperInvariant();
			if (IsInputValid(input))
			{
				var existing = _list.FirstOrDefault(conv => conv.Source == input
				                                            && conv.Direction == _direction);
				if (existing == null)
				{
					string output;
					if (Converter_2_11.TryConvert(input, out output, _direction))
					{
						tbDestination.Text = output;
						_list.AddFirst(new Conversion(input, output, _direction));
						UpdateBindings();
					}
					else
					{
						MessageBox.Show("Possible overflow. Please, check input",
							"Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					tbDestination.Text = existing.Destination;
					RaiseToTop(existing);
				}
			}
			else
			{
				MessageBox.Show("Unknown digit. Please, check input",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}

		private bool IsInputValid(string input)
		{
			return _direction == Direction._2_to_11
				? input.All(digits_2.Contains)
				: input.All(digits_11.Contains);
		}

		private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			_direction = (Direction)cbDirection.SelectedIndex;
			UpdateLabels();
			tbDestination.ResetText();
		}

		private void UpdateLabels()
		{
			if (_direction == Direction._2_to_11)
			{
				lblSource.Text = "2_based value:";
				lblDestination.Text = "11_based value:";
			}
			else
			{
				lblSource.Text = "11_based value:";
				lblDestination.Text = "2_based value:";
			}
		}

		private void cbHistory_SelectionChangeCommitted(object sender, EventArgs e)
		{
			var conversion = _list.ElementAt(cbHistory.SelectedIndex);
			PopulateConversionFields(conversion);
			RaiseToTop(conversion);
			cbHistory.SelectedIndex = 0;
		}

		private void RaiseToTop(Conversion conversion)
		{
			_list.Remove(conversion);
			_list.AddFirst(conversion);
			UpdateBindings();
		}

		private void PopulateConversionFields(Conversion conversion)
		{
			_direction = conversion.Direction;
			cbDirection.SelectedIndex = (int) _direction;
			UpdateLabels();
			tbSource.Text = conversion.Source;
			tbDestination.Text = conversion.Destination;
		}
	}
}
