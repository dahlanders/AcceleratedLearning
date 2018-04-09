using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Material
{
    public string Name { get; set; }
    public double UValue { get; set; }
}
class MaterialWithThickness
{
    public string Name { get; set; }
    public double UValue { get; set; }
    public double Thickness { get; set; }
}
class Program

{
    private static List<Material> MakeMaterialList(string filename)
    {
        CultureInfo info = CultureInfo.GetCultureInfo("us-US");

        List<Material> materiallist = new List<Material>();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {

            var xsplit = line.Split('|');

            var newmaterial = new Material();
            newmaterial.Name = xsplit[0];

            newmaterial.UValue = Double.Parse(xsplit[1], info);
            materiallist.Add(newmaterial);

        }
        return materiallist;
    }

    static void Main()
    {




        var list = new List<MaterialWithThickness>();


        List<Material> resultOfMakeingMaterialList = MakeMaterialList(@"material.csv");


        GetMaterialAndThicknessFromUser(resultOfMakeingMaterialList, list);

        ShowMaterialWithUvalue(list);

        var res =CalculateRtTotalOnWalls(list);
        Console.WriteLine(res);
    }
    private static List<MaterialWithThickness> GetMaterialAndThicknessFromUser(List<Material> resultOfMakeingMaterialList, List<MaterialWithThickness> list)
    {
        while (true)
        {
            Console.WriteLine("Ange Material");
            var userInputMaterial = Console.ReadLine();
            bool IsValid = ValidationOfMaterial(userInputMaterial, resultOfMakeingMaterialList);
            if (IsValid == false)
            {
                Console.WriteLine("Materialet finns inte i listan");
                continue;
            }
            double userInputThicknessMaterial = 0;
            while (true)
            {
                Console.WriteLine("Ange tjockleken på materialet");
                userInputThicknessMaterial = double.Parse(Console.ReadLine());
                if (userInputThicknessMaterial >= 1)
                {
                    Console.WriteLine("Materialets tjocklek är för tjockt");
                    continue;
                }
                break;
            }

            var newMataterial = new MaterialWithThickness();
            newMataterial.Name = userInputMaterial;
            newMataterial.Thickness = userInputThicknessMaterial;
            newMataterial.UValue = GetUValue(userInputMaterial, resultOfMakeingMaterialList);

            list.Add(newMataterial);



            Console.WriteLine(" Vill du ange ett material till? Yes or No");
            var UserGivesOneMoreMAterial = Console.ReadLine();
            if (UserGivesOneMoreMAterial == "No")
            {
                break;
            }
        }
        return list;
    }

    private static List<MaterialWithThickness> ShowMaterialWithUvalue(List<MaterialWithThickness> list)
    {
        foreach (var item in list)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{item.Name} {item.UValue} ");
            Console.ResetColor();
        }
        return list;
    }
    private static double PresentRtResultForUser(List<MaterialWithThickness> list)
    {

        var calculatedRtTotalResult = CalculateRtTotalOnWalls(list);
        return calculatedRtTotalResult;
    }

    private static double CalculateRtTotalOnWalls(List<MaterialWithThickness> myWall)
    {
        double rtTotal = 0;
        foreach (var materialwiththickness in myWall)
        {
            var uvresult = materialwiththickness.UValue;
            var thickness = materialwiththickness.Thickness;

            var resultPerWall = materialwiththickness.Thickness / materialwiththickness.UValue;
            rtTotal = resultPerWall + rtTotal;

        }
        return rtTotal;

    }

    private static double GetUValue(string printedmaterial, List<Material> materiallist)
    {
        foreach (var material in materiallist)
        {
            if (printedmaterial == material.Name)
                return material.UValue;

        }
        return 0;


    }
    public static bool ValidationOfMaterial(string materialname, List<Material> materiallist)
    {
        bool materialIsInList = false;

        foreach (var matrial in materiallist)
        {
            if (matrial.Name.ToLower() == materialname.ToLower())
            {

                materialIsInList = true;
                break;
            }
        }

        return materialIsInList;


    }
}
