using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace blazorserver01.Data
{
    public class BallEnvironment
    {
        private int rows = 1;
        private int cols = 1;
        private Ball[,] cell;
        public BallEnvironment(int rows_, int columns_)
        {
            this.rows = rows_;
            this.cols = columns_;
            this.cell = new Ball[this.rows, this.cols];
            for (var i = 0; i < this.rows; i++)
                for (var j = 0; j < this.cols; j++)
                    this.cell[i, j] = null;
        }
        public int total_of_rows()
        {
            return this.rows;
        }
        public int total_of_cols()
        {
            return this.cols;
        }
        private bool rightPos(int i, int j)
        {
            return ((i >= 0) && (i < this.rows) && (j >= 0) && (j < this.cols));
        }

        public void insert(int i, int j, Ball ball)
        {
            if (this.rightPos(i, j))
            {
                this.cell[i, j] = ball;
            }
        }
        public Ball ballunit(int i, int j)
        {
            if (this.rightPos(i, j))
            {
                return this.cell[i, j];
            }
            return null;
        }
        public List<Ball> neighbors(int i, int j)
        {
            List<Ball> ans = new List<Ball>();
            if (this.rightPos(i, j))
            {
                if (this.rightPos(i - 1, j - 1) && this.cell[i - 1, j - 1] != null) ans.Add(this.cell[i - 1, j - 1]);
                if (this.rightPos(i - 1, j) && this.cell[i - 1, j] != null) ans.Add(this.cell[i - 1, j]);
                if (this.rightPos(i - 1, j + 1) && this.cell[i - 1, j + 1] != null) ans.Add(this.cell[i - 1, j + 1]);
                if (this.rightPos(i, j - 1) && this.cell[i, j - 1] != null) ans.Add(this.cell[i, j - 1]);
                if (this.rightPos(i, j + 1) && this.cell[i, j + 1] != null) ans.Add(this.cell[i, j + 1]);
                if (this.rightPos(i + 1, j - 1) && this.cell[i + 1, j - 1] != null) ans.Add(this.cell[i + 1, j - 1]);
                if (this.rightPos(i + 1, j) && this.cell[i + 1, j] != null) ans.Add(this.cell[i + 1, j]);
                if (this.rightPos(i + 1, j + 1) && this.cell[i + 1, j + 1] != null) ans.Add(this.cell[i + 1, j + 1]);
            }
            return ans;
        }
        public int surroundingNeighbors(int i, int j, String specie)
        {
            int ans = 0;
            List<Ball> surr = this.neighbors(i, j);
            //Console.WriteLine(" i j " + i.ToString() + " , " + j.ToString());
            foreach (object unit in surr)
            {
                if (this.specie(unit) == specie) ans++;
            }
            return ans;
        }

        public String specie(Object obj)
        {
            String[] w;
            if (obj == null) return "";
            w = TypeDescriptor.GetClassName(obj).Split(".");
            return w[w.Length - 1];
        }

        // public void onOff(int row, int col){
        //     if(this.rightPos(row,col)){
        //         if(this.cell[row,col]!=null)
        //             this.cell[row,col]=null;
        //         else
        //             this.cell[row,col] = new Ball(row,col,this);
        //     }
        // }


    }
}