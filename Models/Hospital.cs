using System.ComponentModel.DataAnnotations;

namespace HospitalAPI.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }

    }
}


