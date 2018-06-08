using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U5TowerOfHanoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Variables.
            int size = 7;
            int[] rod1 = new int[size];
            int[] rod2 = new int[size];
            int[] rod3 = new int [size];
            bool Solved = false;
            int leftOnOne = size;

            //Create the array of disks.
            for (int i = 0; i < size; i++)
            {
                rod1[i] = i + 1;
            }

            //Sets rod2 to empty.
            for (int i = 0; i < size; i++)
            {
                rod2[i] = 0;
            }

            //Sets rod3 to empty.
            for (int i = 0; i < size; i++)
            {
                rod3[i] = 0;
            }

            //Simulation of the game.
            while (!Solved)
            {

                //If all the disks are on the rod3, the game is over.
                if(rod3[0] != 0)
                {
                    Solved = true;
                }

                //Moves a disk from rod1 to rod2.
                else if (leftOnOne % 2 == 0)
                {
                    rod2[size - 1] = rod1[size - leftOnOne];
                    rod1[size - leftOnOne] = 0;
                    leftOnOne--;

                    //Moves disks from rod3 to rod2.
                    for (int i = 0; i < size - 1; i++)
                    {
                        rod2[size - (i + 2)] = rod3[size - (i + 1)];
                        rod3[size - (i + 1)] = 0;
                    }
                }

                //Moves a disk from rod1 to rod3.
                else
                {
                    rod3[size - 1] = rod1[size - leftOnOne];
                    rod1[size - leftOnOne] = 0;
                    leftOnOne--;

                    //Moves disks from rod2 to rod3.
                    for (int i = 0; i < size - 1; i++)
                    {
                        rod3[size - (i + 2)] = rod2[size - (i + 1)];
                        rod2[size - (i + 1)] = 0;
                    }
                }
            }
            MessageBox.Show("Solved!");
        }
    }
}
