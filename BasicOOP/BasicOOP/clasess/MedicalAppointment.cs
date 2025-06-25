using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.clasess
{
    class MedicalAppointment
    {
        private string _patientName;
        private DateTime _date;

        public MedicalAppointment(string patientName, DateTime date)
        {
            _patientName = patientName;
            _date = date;
        }

        //calling one constructor from another
        //commented now, as the below constructor with optional parameters
        //also allows to skip the second parameter
        //public MedicalAppointment(string patientName = "unknown") :this(patientName, 7) // si llama este constructor,
        //                                                                                // envia los valores del this(patientName, 7)
        //{

        //}

        public MedicalAppointment(string patientName = "unknown", int daysFromNow = 7)
        {
            _patientName = patientName;
            _date = DateTime.Now.AddDays(daysFromNow);
        }

        public DateTime GetDate() => _date;

        public void Reschedule(DateTime date)
        {
            _date = date;
            var printer = new MedicalAppointmentPrinter();
            printer.Print(this);
        }
           // sobre carga de metodos
    

        public void OverwriteMonthAndDay(int month, int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }

        public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
        {
            _date = new DateTime(
                _date.Year,
                _date.Month + monthsToAdd,
                _date.Day + daysToAdd);
        }
    }

    class MedicalAppointmentPrinter
    {
        public void Print(MedicalAppointment medicalAppointment)
        {
            Console.WriteLine(
                "Appointment will take place on " + medicalAppointment.GetDate());
        }
    }
}
