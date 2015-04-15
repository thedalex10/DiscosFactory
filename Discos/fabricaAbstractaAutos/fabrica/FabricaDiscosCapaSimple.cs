﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using discos.Clases;
using discos.Fabrica;
using disco;

namespace discos.Fabrica
{
    class FabricaDiscosCapaDoble : IFabricaDeDiscos
    {

        IDVD IFabricaDeDiscos.crearDVD()
        {
            return new DvdCapaSimple();
        }

        IBluray IFabricaDeDiscos.crearBlueRay()
        {
            return new BlueRayCapaSimple();
        }


    }
}
