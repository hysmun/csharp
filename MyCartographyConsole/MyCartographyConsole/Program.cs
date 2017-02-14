using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCartographyObjects;

namespace MyCartographyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1
            POI tPoi1 = new POI(), tPoi2 = new POI(25.36, 14.2558);
            Polyline tPolyline1 = new Polyline(), tPolyline2 = new Polyline();
            Polygon tPolygon1 = new Polygon(), tPolygon2 = new Polygon();

            //construction des polyline et polygon
            tPolyline1.LPOI.Add(tPoi1);     tPolyline1.LPOI.Add(tPoi2);
            tPolyline2.LPOI.Add(tPoi2);     tPolyline2.LPOI.Add(tPoi1); tPolyline2.LPOI.Add(tPoi2);
            tPolygon1.LPolyline.Add(tPolyline2);
            tPolygon2.LPolyline.Add(tPolyline2); tPolygon2.LPolyline.Add(tPolyline1);


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

            Console.ReadKey();
            Console.Clear();

            //test 2
            List<CartoObj> lCartoObj = new List<CartoObj>();
            lCartoObj.Add(tPoi2);
            lCartoObj.Add(tPolyline2);
            lCartoObj.Add(tPolygon2);
            lCartoObj.Add(tPolyline1);

            //affichage test2
            Console.WriteLine("Affichage du test 2 :");
            foreach(CartoObj tmpCartoObj in lCartoObj)
            {
                tmpCartoObj.Draw();
            }
            Console.ReadKey();
            Console.Clear();

            //test3
        }
    }
}
