﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionIncidenciasProyecto.ControlVariables
{
    enum TipoIncidencia
    {
        Equipos,
        Cuentas,
        Wifi,
        Internet,
        Software
    }
    
    enum EstadoIncidencia
    {
        Abierta,
        Asignada,
        EnProceso,
        EnviadaInfortec,
        Resuelta,
        Cerrada
    }

    enum TipoEquipo
    {
        Ordenador,
        Pantalla,
        Proyector
    }

    enum Perfil
    {
        Administrador,
        Profesor
    }

    enum Prioridad
    {
        baja,
        media,
        alta,
        critica
    }
}
