using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITEWiki
{
    //Student Riley, Date: 24/02/2023
    public partial class FormCITEWiki : Form
    {
        public FormCITEWiki()
        {
            InitializeComponent();
            InitializeArray();
            ButtonSave.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonEdit.Enabled = false;
        }

        #region HelperMethods
        private void InitializeArray()
        {
            for (int x = 0; x < rows; x++)
            {
                DataTable[x, 0] = "~"; // tilde character
                DataTable[x, 1] = " "; // used with CompareOrdinal
                DataTable[x, 2] = " "; // in the Sort and Display
                DataTable[x, 3] = " ";
            }
        }
        #endregion

        #region GlobalVariables

        //9.1 - Create a global 2D string array, use static variables for the dimensions(row = 12, column = 4),
        static int rows = 12;
        static int columns = 4;
        int selectedRow = -1;
        int ptr = 0;
        string[,] DataTable = new string[rows, columns];

        #endregion

        #region Buttons

        //9.2 - Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void ButtonAdd_Click(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(TextBoxCategory.Text) && !string.IsNullOrEmpty(TextBoxStructure.Text) && !string.IsNullOrEmpty(TextBoxDefinition.Text) && ptr < rows)
            {
                DataTable[ptr, 0] = TextBoxName.Text;
                DataTable[ptr, 1] = TextBoxCategory.Text;
                DataTable[ptr, 2] = TextBoxStructure.Text;
                DataTable[ptr, 3] = TextBoxDefinition.Text;

                ptr++;
                DisplayTable();
                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;

                ClearTextBoxes();
                ButtonSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Could not add property, make sure all the input fields are filled in and that the list isn't full");
            }
        }

        //9.3 - Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array,
        private void ButtonEdit_Click(object sender, MouseEventArgs e)
        {
            //Check if anything is selected in the list
            if (ListViewProperties.SelectedItems.Count > 0)
            {
                //Set the DataTable's values to the new ones
                DataTable[selectedRow, 0] = TextBoxName.Text;
                DataTable[selectedRow, 1] = TextBoxCategory.Text;
                DataTable[selectedRow, 2] = TextBoxStructure.Text;
                DataTable[selectedRow, 3] = TextBoxDefinition.Text;

                DisplayTable();
                ClearTextBoxes();

                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a value in the list");
            }
        }

        //9.4 - Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs,
        private void ButtonDelete_Click(object sender, MouseEventArgs e)
        {
            //Set the DataTable's values to blank
            DataTable[selectedRow, 0] = "~";
            DataTable[selectedRow, 1] = " ";
            DataTable[selectedRow, 2] = " ";
            DataTable[selectedRow, 3] = " ";

            ptr--;
            DisplayTable();
            ClearTextBoxes();

            ButtonEdit.Enabled = false;
            ButtonDelete.Enabled = false;
        }

        #endregion

        #region Methods
        //9.5 - Create a CLEAR method to clear the four text boxes so a new definition can be added,
        private void ClearTextBoxes()
        {
            TextBoxName.Clear();
            TextBoxCategory.Clear();
            TextBoxStructure.Clear();
            TextBoxDefinition.Clear();
        }

        //9.6 - Write the code for a Bubble Sort method to sort the 2D array by Name ascending, ensure you use a separate swap method that passes the array element to be swapped (do not use any built-in array methods),
        private void BubbleSort()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - 1; j++)
                {
                    if (string.CompareOrdinal(DataTable[i, 0], DataTable[j, 0]) < 0 )
                    {
                        SwapElements(i, j);
                    }
                }
            }
        }

        private void SwapElements(int indxI, int indxJ)
        {
            string temp;
            for (int x = 0; x < columns; x++)
            {
                temp = DataTable[indxI, x];
                DataTable[indxI, x] = DataTable[indxJ, x];
                DataTable[indxJ, x] = temp;
            }
        }

        #endregion

        #region BinarySearch
        //9.7 - Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found, add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void ButtonSearch_Click(object sender, MouseEventArgs e)
        {
            BubbleSort();
            bool found = false; // assume the item has not been found
            int min = 0;
            int max = ptr; // max is the current size
            int foundIndex = 0;
            string findThis = TextBoxSearch.Text;
            while (min <= max)
            {
                int mid = ((min + max) / 2); // uses integer division
                if (findThis.CompareTo(DataTable[mid, 0]) == 0)
                {
                    found = true;
                    foundIndex = mid;
                    break;
                }
                else if (findThis.CompareTo(DataTable[mid, 0]) < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (!found)
            {
                MessageBox.Show("Search failed: item not found");
            }
            else
            {
                //MessageBox.Show("Success: the item was found " + DataTable[foundIndex, 0]);

                //Set the input textboxes to the datatables values of the found index
                TextBoxName.Text = DataTable[foundIndex, 0];
                TextBoxCategory.Text = DataTable[foundIndex, 1];
                TextBoxStructure.Text = DataTable[foundIndex, 2];
                TextBoxDefinition.Text = DataTable[foundIndex, 3];

                //Select the property in the list
                ListViewProperties.SelectedItems.Clear();
                ListViewProperties.Items[foundIndex].Selected = true;
                ListViewProperties.Select();

                selectedRow = foundIndex;

                ButtonEdit.Enabled = true;
                ButtonDelete.Enabled = true;
            }
        }

        #endregion

        #region Methods
        //9.8 - Create a display method that will show the following information in a ListView: Name and Category,
        private void DisplayTable()
        {
            BubbleSort();
            ListViewProperties.Items.Clear();
            for (int x = 0; x < rows; x++)
            {
                ListViewItem lvi = new ListViewItem(DataTable[x, 0]);
                lvi.SubItems.Add(DataTable[x, 1]);
                lvi.SubItems.Add(DataTable[x, 2]);
                lvi.SubItems.Add(DataTable[x, 3]);
                ListViewProperties.Items.Add(lvi);
            }
        }

        //9.9 - Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes,
        private void ListViewProperties_Click(object sender, EventArgs e)
        {
            selectedRow = ListViewProperties.SelectedIndices[0];

            TextBoxName.Text = DataTable[selectedRow, 0];
            TextBoxCategory.Text = DataTable[selectedRow, 1];
            TextBoxStructure.Text = DataTable[selectedRow, 2];
            TextBoxDefinition.Text = DataTable[selectedRow, 3];

            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
        }
        #endregion

        #region File IO
        //9.10 - Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name, ensure the user has the option to select an alternative file. Use a file stream and BinaryWriter to create the file.
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "dat file|*.dat";
            saveFileDialog.Title = "Save a dat file";
            saveFileDialog.DefaultExt = "dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(saveFileDialog.FileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        for (int x = 0; x < rows; x++)
                        {
                            writer.Write(DataTable[x, 0]);
                            writer.Write(DataTable[x, 1]);
                            writer.Write(DataTable[x, 2]);
                            writer.Write(DataTable[x, 3]);
                        }
                    }
                }
                MessageBox.Show("Table has been saved to dat file");
            }
        }

        //9.11 - Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array, ensure the user has the option to select an alternative file.Use a file stream and BinaryReader to complete this task.
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "DAT Files|*.dat";
            openFileDialog.Title = "Open a DAT file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (File.Exists(openFileDialog.FileName))
                {
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            Array.Clear(DataTable, 0, rows);
                            ptr = 0;
                            while (stream.Position < stream.Length)
                            {
                                for (int y = 0; y < rows; y++)
                                {
                                    DataTable[y, 0] = reader.ReadString();
                                    DataTable[y, 1] = reader.ReadString();
                                    DataTable[y, 2] = reader.ReadString();
                                    DataTable[y, 3] = reader.ReadString();

                                    if (DataTable[y, 0] != "~")
                                        ptr++;
                                }
                            }
                        }
                    }
                    ClearTextBoxes();
                    DisplayTable();
                    ButtonSave.Enabled = true;
                    MessageBox.Show("Table has been loaded from dat file");
                }
            }
        }
        #endregion
    }
}