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
            tPolyline1.LPOI.Add(tPoi0); tPolyline1.LPOI.Add(tPoi3); tPolyline1.LPOI.Add(tPoi4);
            tPolyline2.LPOI.Add(tPoi4); tPolyline2.LPOI.Add(tPoi5); tPolyline2.LPOI.Add(tPoi2);
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

            lPolyline.Sort();

            char lec = '1';
            Console.Write("Veuillez entrez le numero de test voulu :");
            lec = (char) Console.Read();
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
                        Console.WriteLine("Affichage du test 2 et 3 :");
                        foreach (CartoObj tmpCartoObj in lCartoObj)
                        {
                            tmpCartoObj.Draw();
                        }
                        break;
                    case '4':
                        //test 4
                        Console.WriteLine("Affichage du test 4:");
                        foreach(CartoObj tmpCartoObj in lCartoObj)
                        {
                            if(tmpCartoObj is IPointy)
                            {
                                tmpCartoObj.Draw();
                                Console.WriteLine("Nombre de points : " + (tmpCartoObj as IPointy).NbPoints);
                            }
                        }
                        break;
                    case '5':
                        //test 5
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
                    default :
                        Console.WriteLine("Mauvais numero !!!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.Write("Veuillez entrez le numero de test voulu :");
                lec = (char)Console.Read();
            }
        }
    }
}


















