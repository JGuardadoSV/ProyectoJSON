using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProyectoJSON
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aplicacion de consola .net FRAMEWORK
            //instalar nuget Install-Package Newtonsoft.Json -Version 13.0.1

            //URL
            string url = "https://jsonplaceholder.typicode.com/todos/1";

            //visitando la url y guardando el resultado
            HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create(url);
            //Extrayendo el resultado de la peticion 
            HttpWebResponse respuesta = (HttpWebResponse)peticion.GetResponse();

            Stream stream = respuesta.GetResponseStream();
            StreamReader streamlector = new StreamReader(stream, System.Text.Encoding.GetEncoding(8));

        }
    }
}
