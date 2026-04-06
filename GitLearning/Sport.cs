using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearning
{
    internal class Sport
    {
        private string _ballShape;
        public string BallShape { get { return _ballShape; }  set { _ballShape = value; } }
        public int Players { get; set; }
        public Sport() 
        {
            BallShape = "round";
            Players = 11;
            Console.WriteLine(BallShape);
            Console.WriteLine(Players);
        }
    }

}
