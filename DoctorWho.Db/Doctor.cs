﻿using System;
using System.Collections.Generic;

namespace DoctorWho.Db
{
    public class Doctor
    {
        public Doctor()
        {
            EpDoctor = new List<Episode>();
        }
        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public List<Episode> EpDoctor { get; set; }

    }
}
