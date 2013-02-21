using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace SnowSlideWarning
{
    public class ListStation
    {
        public static Dictionary<String, String> GetStation()
        {
            Dictionary<String, String> init = new Dictionary<String, String>();
            init.Add("Deux Alpes", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-les-deux-alpes-228-0.php");
            init.Add("Alpe d'Huez", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-alpe-d-huez-183-0.php");
            init.Add("Les Arcs", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-les-arcs-155-0.php");
            init.Add("Avoriaz", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-avoriaz-111-0.php");
            init.Add("Courchevel", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-courchevel-1850-1456-0.php");
            init.Add("Les Menuires", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-les-menuires-138-0.php");
            init.Add("Méribel", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-meribel-mottaret-1469-0.php");
            init.Add("La Plagne", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-la-plagne--domaine--143-0.php");
            init.Add("Tignes", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-tignes-133-0.php");
            init.Add("Val d'Isère", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-val-d-isere-132-0.php");
            init.Add("Val Thorens", "http://montagne.lachainemeteo.com/meteo-alpes-du-nord/station-montagne/previsions-meteo-val-thorens-140-0.php");    
            return init;
        }
    }
}
