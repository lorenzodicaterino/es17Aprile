using System;
using System.Collections.Generic;

namespace Esercitazione17Aprile.Models;

public partial class Reparto
{
    public int RepartoId { get; set; }

    public string NomeReparto { get; set; } = null!;

    public virtual ICollection<Impiegato> Impiegatos { get; set; } = new List<Impiegato>();
}
