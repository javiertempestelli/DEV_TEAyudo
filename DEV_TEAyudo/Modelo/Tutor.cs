using System;
namespace DEV_TEAyudo;
public class Tutor : Usuario
{
    public int TutorId { get; set; }
    public int PacienteId { get; set; }
    public ICollection<Paciente> Pacientes { get; set; }
    public string CertUniDisc { get; set; }

}
