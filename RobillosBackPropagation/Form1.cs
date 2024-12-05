using Backprop;

namespace RobillosBackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int[][] truthTable =
        [
            [0, 0, 0, 0, 0],
            [0, 0, 0, 1, 0],
            [0, 0, 1, 0, 0],
            [0, 0, 1, 1, 0],
            [0, 1, 0, 0, 0],
            [0, 1, 0, 1, 0],
            [0, 1, 1, 0, 0],
            [0, 1, 1, 1, 0],
            [1, 0, 0, 0, 0],
            [1, 0, 0, 1, 0],
            [1, 0, 1, 0, 0],
            [1, 0, 1, 1, 0],
            [1, 1, 0, 0, 0],
            [1, 1, 0, 1, 0],
            [1, 1, 1, 0, 0],
            [1, 1, 1, 1, 1],
        ];

        public Form1()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 600, 1);
            MessageBox.Show(nn.getNumbers());
        }

        private void trainBtn_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                MessageBox.Show("You have not created the Neural Network yet...");
                return;
            }
            int maxEpoch = 50;
            for (int epoch = 0; epoch < maxEpoch; epoch++)
            {
                foreach (var row in truthTable)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        nn.setInputs(i, (double)row[i]);
                    }
                    nn.setDesiredOutput(0, (double)row[4]);
                    nn.learn();
                }
            }
            MessageBox.Show("Training " + maxEpoch + " Epochs Completed!");
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                MessageBox.Show("You have not created the Neural Network yet...");
                return;
            }
            System.Diagnostics.Debug.WriteLine(input1.Text + " " + input2.Text + " " + input3.Text + " " + input4.Text + " ");
            nn.setInputs(0, Convert.ToDouble(input1.Text));
            nn.setInputs(1, Convert.ToDouble(input2.Text));
            nn.setInputs(2, Convert.ToDouble(input3.Text));
            nn.setInputs(3, Convert.ToDouble(input4.Text));

            nn.run();
            output.Text = "" + nn.getOuputData(0);
            outputRounded.Text = "" + Math.Round(nn.getOuputData(0));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}