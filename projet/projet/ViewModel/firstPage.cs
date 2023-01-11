using projet.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace projet.ViewModel
{
    public class firstPage 
    {
        public string titre;
        public List<groupe> groupe1;
        public List<competition> competition1;
        
        public firstPage()
        {
            titre = "Coupe du monde 2022";

            competition1 = new List<competition>(

                competition1 = new List<competition> { new competition{ Pa = "Tunisie", Pb = "Dannemark", nbPointPa = 0, nbPointPb = 0, date = "15/10/1998" } }
                ) ;

            groupe1 = new List<groupe> { new groupe { image1 = "tunisie.png", image2 = "dannemark.gpg", score1 = 3, score2 = 3, pays1 = "Tunisie", pays2 = "Dannemark" } }; 

                
            
        }
    }

}
