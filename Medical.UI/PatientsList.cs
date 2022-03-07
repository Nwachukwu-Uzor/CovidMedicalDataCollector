using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Medical.Core.Models;
using Medical.Core.Contracts;
using Medical.Core.Persistence;

namespace Medical.UI
{
    public partial class PatientsList : Form
    {
        public IMedicalRepository MedicalRepository { get; set; }

        public PatientsList(IMedicalRepository medicalRepository)
        {
            InitializeComponent();
            MedicalRepository = medicalRepository;
        }

        public void RenderPatients()
        {

        }
    }
}
