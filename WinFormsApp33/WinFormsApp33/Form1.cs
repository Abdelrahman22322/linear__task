using System.Drawing.Drawing2D;

namespace WinFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static void DisplayArray(double[,] Aray, int rows, int cols)
        {

        }

        //  swap two row of  Aray гЪ ИЪЦ еее
        public static void SwapRows(double[,] Array, int rowA, int rowB)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                double temp = Array[rowA, j];
                Array[rowA, j] = Array[rowB, j];
                Array[rowB, j] = temp;
            }
        }

        // A main method that perform GaussJordan in a Aray
        public static double[,] Gauss(double[,] Array, int rows, int cols)
        {
            // Loop over the rows
            for (int i = 0; i < rows; i++)
            {
                // Find the pivot element 
                int pivot = i;
                for (int k = i + 1; k < rows; k++)
                {
                    if (Math.Abs(Array[k, i]) > Math.Abs(Array[pivot, i]))
                    {
                        pivot = k;
                    }
                }


                // Swap the pivot 
                if (pivot != i)
                {
                    SwapRows(Array, i, pivot);
                }

                // Divide row 
                double divisor = Array[i, i];
                if (divisor != 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Array[i, j] /= divisor;
                    }
                }


                // Eliminate the other rows 
                for (int k = 0; k < rows; k++)
                {
                    if (k != i)
                    {
                        double factor = Array[k, i];
                        for (int j = i; j < cols; j++)
                        {
                            Array[k, j] -= factor * Array[i, j];
                        }


                    }
                }
            }

            return Array;
        }


        //  solve a system




        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(txtRows.Text);
            int cols = int.Parse(txtCols.Text);

            double[,] array = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string input = txtInput.Text; // Get input from TextBox or other UI element

                double[] row = input.Split(' ').Select(double.Parse).ToArray();

                //if (row.Length != cols)
                //{
                //    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = row[j];
                }
            }

            txtResult.Clear(); // Clear previous results
            txtResult.AppendText("The augmented matrix is:" + Environment.NewLine);
            DisplayArray(array, rows, cols);

            double[,] solution = Gauss(array, rows, cols);

            //txtResult.AppendText("The solution is:" + Environment.NewLine);
            //foreach (double x in solution)
            //{
            //    txtResult.AppendText(x + Environment.NewLine);

            //}
            for (int j = 0; j < rows; j++)
            {
                txtResult.AppendText("| ");
                for (int i = 0; i < cols; i++)
                {
                    txtResult.AppendText(solution[j, i].ToString() + " ");
                }

                txtResult.AppendText(" |\n");
            }
        }
    }
}
