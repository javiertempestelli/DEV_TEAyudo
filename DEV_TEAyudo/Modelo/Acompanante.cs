using System;

namespace DEV_TEAyudo;
public class Acompanante : Usuario
{
	public int AcompananteId { get; set; }
	public int ObraSocialId { get; set; }
	public ICollection <ObraSocial> ObrasSociales { get; set; }
	public string Contacto { get; set; }
	public string Documentacion {get; set; }
	public int PostulacionId { get; set; }
	public ICollection<Postulacion> Postulaciones { get; set; }
	public int Especialidad { get; set; }
	public ICollection<Especialidad> Especialidades { get; set; }
	public string Experiencia { get; set; }

}
