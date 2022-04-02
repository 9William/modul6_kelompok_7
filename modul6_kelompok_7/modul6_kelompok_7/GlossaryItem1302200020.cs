using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace modul6_kelompok_7
{
    internal class GlossaryItem1302200020
    {
        string jsonFilePath = @"D:\00_File Kampus\S4\KPL\PRAKTIKUM\TP KPL\modul6_kelompok_7\modul6_kelompok_7\jurnal6_3_1302200020.json";
        public void ReadJSON()
        {
            string jsonFile = File.ReadAllText(jsonFilePath);
            dynamic data = JsonConvert.DeserializeObject(jsonFile);

            Console.WriteLine("Glossary Title : " + data.glossary.title);
            Console.WriteLine("GlosDiv Title  : " + data.glossary.GlossDiv.title);
            Console.WriteLine("Glossary List : ");
            Console.WriteLine("GlossEntry ID : " + data.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("GlossEntry SortAs : " + data.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("GlossEntry GlossTerm : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("GlossEntry Acronym : " + data.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("GlossEntry Abbrev : " + data.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("GlossDef Para : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            Console.WriteLine("GlossDef Para : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso);
            Console.WriteLine("GlossDef Para : " + data.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
            Console.WriteLine();
        }
    }
}