using System;
using System.Collections.Generic;
using System.Text;

namespace projet.Model
{
    public class groupe
    {
        public string name { get; set; }
        public string pays1 { get; set; }
        public string pays2 { get; set; }
        public string pays3 { get; set; }
        public string pays4 { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int score3 { get; set; }
        public int score4 { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string image4 { get; set; }

        public groupe()
        {

        }
        public groupe(string name, string pays1, string pays2, string pays3, string pays4, int score1, int score2, int score3, int score4, string image1, string image2, string image3, string image4)
        {
            this.name = name;
            this.pays1 = pays1;
            this.pays2 = pays2;
            this.pays3 = pays3;
            this.pays4 = pays4;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
            this.score4 = score4;
            this.image1 = image1;
            this.image2 = image2;
            this.image3 = image3;
            this.image4 = image4;
        }
    }
}
