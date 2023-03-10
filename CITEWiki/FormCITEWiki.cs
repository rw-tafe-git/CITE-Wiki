using System.Data.Common;
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
        string[,] DataTable = new string[rows, columns];


        private void DisplayTable()
        {
            MyListViewItem.Items.Clear();
            for (int x = 0; x < rows; x++)
            {
                ListViewItem lvi = new ListViewItem(DataTable[x, 0]);
                lvi.SubItems.Add(DataTable[x, 1]);
                lvi.SubItems.Add(DataTable[x, 2]);
                lvi.SubItems.Add(DataTable[x, 3]);
                lvi.SubItems.Add(DataTable[x, 4]);
                MyListViewItem.Items.Add(lvi);
            }
        }

        private void ButtonFill_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    DataTable[x, y] = random.Next(10, 99).ToString();
                }
            }
            DisplayTable();
            ButtonEdit.Enabled = true;
        }

        private void SortTable()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    if (string.Compare(DataTable[i, 0], DataTable[i + 1, 0]) == 1)
                    {
                        Swap(i);
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

        private void ListViewDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataTableForm_Load(object sender, EventArgs e)
        {

        }

        //9.2 - Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void ButtonAdd_Click(object sender, MouseEventArgs e)
        {
            ClearTextBox();
        }

        //9.3 - Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array,
        private void ButtonEdit_Click(object sender, MouseEventArgs e)
        {

        }

        //9.4 - Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs,
        private void ButtonDelete_Click(object sender, MouseEventArgs e)
        {

        }

        //9.5 - Create a CLEAR method to clear the four text boxes so a new definition can be added,
        private void ClearTextBox()
        {
            TextBoxName.Clear();
            TextBoxCategory.Clear();
            TextBoxStructure.Clear();
            TextBoxDefinition.Clear();
        }

        //9.6 - Write the code for a Bubble Sort method to sort the 2D array by Name ascending, ensure you use a separate swap method that passes the array element to be swapped (do not use any built-in array methods),
        private void BubbleSort()
        {
            /*for (int x = 0; x < rows; x++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    if (string.Compare(DataTable[i, 0], DataTable[i + 1, 0]) == )
                    {
                        Swap(i);
                    }
                }
            }*/
        }

        private void Swap(int indx)
        {
            string temp;
            for (int z = 0; z < columns; z++)
            {
                temp = DataTable[indx, z];
                DataTable[indx, z] = DataTable[indx + 1, z];
                DataTable[indx + 1, z] = temp;
            }
        }

        //9.7 - Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found, add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void BinarySearch()
        {

        }

        //9.8 - Create a display method that will show the following information in a ListView: Name and Category,
        private void DisplayData()
        {
            MyListViewItem.Items.Clear();
            for (int x = 0; x < rows; x++)
            {
                ListViewItem lvi = new ListViewItem(DataTable[x, 0]);
                //lvi.SubItems.Add
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
    }
}