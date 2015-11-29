using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MeaasgePanel
{
    class Expert
    {

        List<Point> clickTrace;
        public int[,] numTable;
        public Expert()
        {
            clickTrace = new List<Point>();
            initNumTable();
        }
        private void initNumTable()
        {
            numTable = new int[5, 5];
             Random ran = new Random();
             for (int i = 0; i < 5; i++)
                 for (int j = 0; j < 5; j++)
                 {
                     numTable[i, j] = ran.Next(1,8);
   
                 }         
        }

        public Point getLastPoint()
        {
            Point lastPoint = clickTrace[clickTrace.Count - 1];
            return lastPoint;
        }

        public bool isNull()
        {
            if (clickTrace.Count == 0)
                return true;
            else
            {
                return false;
            }
        }

        public void addPoint(Point newPoint)
        {
            clickTrace.Add(newPoint);
        }

        public String printTrace()
        {
            String result = "";

            foreach (Point i in clickTrace)
            {
                result += i.ToString();
            }
            return result;
        }
    }
}
