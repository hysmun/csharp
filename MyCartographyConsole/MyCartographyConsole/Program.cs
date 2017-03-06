using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCartographyObjects;
using MathUtilsLib;

namespace MyCartographyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //objet pour les tests!
                POI tPoi = new POI(), tPoi0 = new POI(0, 0);
                POI tPoi1 = new POI(1, 0), tPoi2 = new POI(2, 0);
                POI tPoi3 = new POI(0, 1), tPoi4 = new POI(1, 2);
                POI tPoi5 = new POI(2, 1), tPoi6 = new POI(0, 2);
                POI tPoi7 = new POI(1, 2), tPoi8 = new POI(2, 2);

                Polyline tPolyline = new Polyline();
                Polyline tPolyline1 = new Polyline(), tPolyline2 = new Polyline();
                Polyline tPolyline3 = new Polyline(), tPolyline4 = new Polyline();

                Polygon tPolygon1 = new Polygon(), tPolygon2 = new Polygon();
                Polygon tPolygon3 = new Polygon(), tPolygon4 = new Polygon();

                //construction des polyline et polygon
                tPolyline1.LPOI.Add(tPoi0); tPolyline1.LPOI.Add(tPoi1); tPolyline1.LPOI.Add(tPoi3);
                tPolyline2.LPOI.Add(tPoi0); tPolyline2.LPOI.Add(tPoi2); tPolyline2.LPOI.Add(tPoi6);
                tPolyline3.LPOI.Add(tPoi6); tPolyline3.LPOI.Add(tPoi7); tPolyline3.LPOI.Add(tPoi8); tPolyline3.LPOI.Add(tPoi4);
                tPolygon1.LPolyline.Add(tPolyline2);
                tPolygon2.LPolyline.Add(tPolyline2); tPolygon2.LPolyline.Add(tPolyline1);
                tPolygon3.LPolyline.Add(tPolyline2);
                tPolygon3.LPolyline.Add(tPolyline3);
                tPolygon3.LPolyline.Add(tPolyline1);

                //list de base pour test normaux
                List<CartoObj> lCartoObj = new List<CartoObj>();
                lCartoObj.Add(tPoi2);
                lCartoObj.Add(tPolyline2);
                lCartoObj.Add(tPolygon2);
                lCartoObj.Add(tPolyline1);

                //list de polyline trié
                List<Polyline> lPolyline = new List<Polyline>();
                lPolyline.Add(tPolyline1);
                lPolyline.Add(tPolyline3);
                lPolyline.Add(tPolyline2);
                lPolyline.Add(tPolyline3);
                lPolyline.Add(tPolyline);

                char lec = '1';
                Console.Write("Veuillez entrez le numero de test voulu :");
                lec = (char)Console.Read();
                while (lec != 'q')
                {
                    switch (lec)
                    {
                        case '1':
                            // Test 1
                            //affichage test1
                            Console.WriteLine("Affichage du test 1 :");
                            Console.WriteLine("Zone POI :");
                            tPoi1.Draw();
                            tPoi2.Draw();
                            Console.WriteLine("\nZone Polyline :");
                            tPolyline1.Draw();
                            tPolyline2.Draw();
                            Console.WriteLine("\nZone Polygon :");
                            tPolygon1.Draw();
                            tPolygon2.Draw();

                            break;
                        case '2':
                        case '3':
                            //test 2 et 3
                            // Afficher cette liste en utilisant le mot clé foreach,
                            Console.WriteLine("Affichage du test 2 et 3 :");
                            foreach (CartoObj tmpCartoObj in lCartoObj)
                            {
                                tmpCartoObj.Draw();
                            }
                            break;
                        case '4':
                            //test 4
                            //Afficher la liste des objets cartographiques implémentant l’interface IPointy,
                            Console.WriteLine("Affichage du test 4:");
                            foreach (CartoObj tmpCartoObj in lCartoObj)
                            {
                                if (tmpCartoObj is IPointy)
                                {
                                    tmpCartoObj.Draw();
                                    Console.WriteLine("Nombre de points : " + (tmpCartoObj as IPointy).NbPoints);
                                }
                            }
                            break;
                        case '5':
                            //test 5
                            // Afficher la liste des objets cartographiques n’implémentant pas l’interface IPointy,
                            int i = 0;
                            Console.WriteLine("Affichage du test 5:");
                            foreach (CartoObj tmpCartoObj in lCartoObj)
                            {
                                if (!(tmpCartoObj is IPointy))
                                {
                                    tmpCartoObj.Draw();

                                    i++;
                                }
                            }
                            break;
                        case '6':
                            //test 6
                            // Créer une liste générique de 5 Polyline, l’afficher, 
                            // la trier par ordre de longueur croissante1, l’afficher à nouveau. 
                            // Pour trier, la méthode Sort() de la classe List<T> utilise la méthode CompareTo() 
                            // définie grâce à l’implémentation dans la classe Polyline 
                            // de l’interface Icomparable<Polyline>,
                            Console.WriteLine("Affichage du test 6: liste polyline non trié:\n");
                            foreach (Polyline tmpPolyline in lPolyline)
                            {
                                tmpPolyline.Draw();
                            }
                            lPolyline.Sort();
                            Console.WriteLine("\n\n\nAffichage liste polyline trié:\n");
                            foreach (Polyline tmpPolyline in lPolyline)
                            {
                                tmpPolyline.Draw();
                            }
                            break;
                        case '7':
                            // test 7
                            // Sans modifier la méthode CompareTo(), trier la précédente liste par ordre croissant 
                            // de taille de la surface de la bounding box englobant la polyline. 
                            // Pour ce faire, il s’agit de créer une classe MyPolylineBoundingBoxComparer 
                            // implémentant l’interface IComparer<Polyline>,
                            MyPolylineBoundingBoxComparer polylineCmp = new MyPolylineBoundingBoxComparer();
                            CartoObj.Precision = 1;
                            Console.WriteLine("Affichage du test 7: liste polyline non trié:\n");
                            foreach (Polyline tmpPolyline in lPolyline)
                            {
                                tmpPolyline.Draw();
                            }
                            lPolyline.Sort(polylineCmp);
                            Console.WriteLine("\n\n\nAffichage liste polyline trié par taille bouding box:\n");
                            foreach (Polyline tmpPolyline in lPolyline)
                            {
                                tmpPolyline.Draw();
                                Console.WriteLine(" bouding : "+tmpPolyline.BoudingBox);
                            }
                            break;
                        case '8':
                            // test 8 
                            // Rechercher, parmi les polyline de la liste, 
                            // celles qui présentent la même taille qu’une polyline de référence. 
                            // Pour ce faire, il s’agit d’implémenter l’interface IEquatable<Polyline>,
                            Console.WriteLine("Test 8 :");
                            Console.WriteLine("Polyline de ref : ");
                            tPolyline1.Draw();
                            Console.WriteLine("\n");
                            foreach (Polyline tmpPolyline in lPolyline)
                            {
                                tmpPolyline.Draw();
                                if (tmpPolyline.Equals(tPolyline1) )
                                {
                                    // les deux polyline on la même longueur
                                    Console.WriteLine("Equals !!");
                                }
                                else
                                {
                                    Console.WriteLine("Not Equals!!!");
                                }
                            }
                            break;
                        case '9':
                            // test 9
                            // Rechercher, parmi les polyline de la liste, 
                            // celles qui sont proches d’un point passé en paramètre. 
                            // Pour ce faire, il s’agit d’utiliser la méthode IsPointClose() 
                            // contenue dans l’interface IIsPointClose.
                            double x=0.5, y=0.5, preci=0.9;
                            Console.Write(" Point (" + x + "," + y + ") \n\n");
                            foreach (Polyline tmpPolyline in lPolyline)
                            {
                                tmpPolyline.Draw();
                                
                                if(tmpPolyline.IsPointClose(x, y, preci) == true)
                                {
                                    Console.WriteLine("Proche !");
                                }
                                else
                                {
                                    Console.WriteLine(" Eloignee !!");
                                }
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Mauvais numero !!!");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Veuillez entrez le numero de test voulu :");
                    lec = (char)Console.Read();
                }
            }
            catch(Exception r)
            {
                Console.WriteLine("ERREUR !!! ");
                Console.ReadKey();
            }
        }
    }
}


















