using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_4_RenatoCabrera_JoseHerrera.Models
{
    public class Listados <T>
    {
        List<T> faltantes = new List<T>();
        List<T> coleccionadas = new List<T>();
        List<T> cambios = new List<T>();    

    }
}