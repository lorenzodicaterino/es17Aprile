using System;
using System.Collections.Generic;

namespace Esercitazione17Aprile.Models;

public partial class Impiegato
{
    public int ImpiegatoId { get; set; }

    public string Matricola { get; set; } = null!;

    public string NomeImpiegato { get; set; } = null!;

    public string CognomeImpiegato { get; set; } = null!;

    public DateOnly? DataNascitaImpiegato { get; set; }

    public string RuoloImpiegato { get; set; } = null!;

    public string IndirizzoImpiegato { get; set; } = null!;

    public int RepartoRif { get; set; }

    public string CittaRif { get; set; } = null!;

    public virtual Reparto RepartoRifNavigation { get; set; } = null!;
}
