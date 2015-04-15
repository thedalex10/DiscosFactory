using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using discos.Clases;
using discos;

namespace disco
{
    interface IFabricaDeDiscos
    {
        IDVD crearDVD();
        IBluray crearBlueRay();
          
       
    }
}
