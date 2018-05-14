/* Daniel Garson
 *  CIS 237
 *  Due 2/7/18
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>

    class MazeSolver
    {

        bool solve;

        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;


        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>

        public MazeSolver()
        { }

                                    //changed case to avoid confusion
        public void SolveMaze(char[,] Maze, int xstart, int ystart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class.

            this.maze = Maze;
            this.xStart = xstart;
            this.yStart = ystart;


            //Do work needed to use mazeTraversal recursive call and solve the maze.
            mazeTraversal(yStart, xStart);
           
            PrintandFormat();
        }

        //prints maze and formats it 
        void PrintandFormat()
        {
            for (int m = 0; m < 12; m++)
            {
                
               
               //prints each step of the maze 
               Console.ReadLine();



                for (int t = 0; t < 12; t++)
                {
                    Console.Write(maze[m, t] + " ");
                }
            }
            Console.WriteLine();
        }

        
        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private bool mazeTraversal(int Y, int X)
        {
            //Implement maze traversal recursive call
            maze[Y, X] = 'x';


            try
            {
                if (maze[Y, X + 1] != '#' && maze[Y, X + 1] != 'x')
                {

                    solve = mazeTraversal(Y, X + 1);

                    if (solve)
                     return true;
                }
                if (maze[Y - 1, X] != '#' && maze[Y - 1, X] != 'x')
                {
                    solve = mazeTraversal(Y - 1, X);
                    if (solve)
                    return true;
                }
                if (maze[Y + 1, X] != '#' && maze[Y + 1, X] != 'x')
                {
                    solve = mazeTraversal(Y + 1, X);
                    if (solve)
                    return true;
                }
                if (maze[Y, X - 1] != '#' && maze[Y, X - 1] != 'x')
                {
                    solve = mazeTraversal(Y, X - 1);
                    if (solve)
                    return true;
                }
                maze[Y, X] = 'o';
                return false;
            }
            catch (Exception e)
            {
                return true;
            }

          
        }

        
    }
}