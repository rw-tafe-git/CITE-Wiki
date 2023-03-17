using Microsoft.VisualBasic.Logging;
using System.Data.Common;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace CITEWiki
{
    // Student Riley, Date: 24/02/2023
    public partial class FormCITEWiki : Form
    {
        public FormCITEWiki()
        {
            InitializeComponent();
            InitializeArray();
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
            }
        }
        #endregion

        //9.1 - Create a global 2D string array, use static variables for the dimensions(row = 12, column = 4),
        static int rows = 12;
        static int columns = 4;
        int selectedRow = -1;
        int ptr = 0;
        string[,] DataTable = new string[rows, columns];

        private void SortTable()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    if (string.Compare(DataTable[i, 0], DataTable[i + 1, 0]) == 1)
                    {
                        SwapElements(x, i);
                    }
                }
            }
            DisplayTable();
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            SortTable();
            DisplayTable();
        }

        //9.2 - Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void ButtonAdd_Click(object sender, MouseEventArgs e)
        {
            var newName = TextBoxName.Text;
            var newCategory = TextBoxCategory.Text;
            var newStructure = TextBoxStructure.Text;
            var newDefinition = TextBoxDefinition.Text;

            if (/*!string.IsNullOrEmpty(newName) && !string.IsNullOrEmpty(newCategory) && !string.IsNullOrEmpty(newStructure) && !string.IsNullOrEmpty(newDefinition) &&*/ ptr < rows)
            {
                DataTable[ptr, 0] = newName;
                DataTable[ptr, 1] = newCategory;
                DataTable[ptr, 2] = newStructure;
                DataTable[ptr, 3] = newDefinition;

                ptr++;
                DisplayTable();
                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;

                ClearTextBoxes();

                Debug.WriteLine(ptr);
            }
        }

        //9.3 - Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array,
        private void ButtonEdit_Click(object sender, MouseEventArgs e)
        {
            DataTable[selectedRow, 0] = TextBoxName.Text; ;
            DataTable[selectedRow, 1] = TextBoxCategory.Text;
            DataTable[selectedRow, 2] = TextBoxStructure.Text;
            DataTable[selectedRow, 3] = TextBoxDefinition.Text;

            ptr--;
            DisplayTable();
            ButtonEdit.Enabled = true;

            ClearTextBoxes();
        }

        //9.4 - Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs,
        private void ButtonDelete_Click(object sender, MouseEventArgs e)
        {
            DataTable[selectedRow, 0] = "~";
            DataTable[selectedRow, 1] = "~";
            DataTable[selectedRow, 2] = "~";
            DataTable[selectedRow, 3] = "~";

            ptr--;
            DisplayTable();
            ButtonEdit.Enabled = true;

            ClearTextBoxes();
        }

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

        //9.7 - Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found, add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void BinarySearch()
        {

        }

        private void ButtonSearch_Click(object sender, MouseEventArgs e)
        {
            BubbleSort();
            int startIndex = -1;
            int finalIndex = ptr;
            bool flag = false;
            int foundIndex = -1;
            /*while (!flag && !((finalIndex - startin)))
            {
                
            }*/
        }

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

        private void ButtonOpen_MouseClick(object sender, MouseEventArgs e)
        {
            BubbleSort();
            //Put binary search here
        }
        
        private void SaveBinaryFile()
        {

        }

        private void FormCITEWiki_Load(object sender, EventArgs e)
        {

        }

        private void ListViewProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewProperties_MouseClick(object sender, MouseEventArgs e)
        {
            selectedRow = ListViewProperties.SelectedIndices[0];

            TextBoxName.Text = DataTable[selectedRow, 0];
            TextBoxCategory.Text = DataTable[selectedRow, 1];
            TextBoxStructure.Text = DataTable[selectedRow, 2];
            TextBoxDefinition.Text = DataTable[selectedRow, 3];

            ButtonEdit.Enabled = true;
            ButtonDelete.Enabled = true;
        }
    }
}