using System;
using System.Collections.Generic;

namespace DoctorWho.Db
{
    public class Episode
    {
        public Episode()
        {
            EpEnemy = new List<EpisodeEnemy>();
            EpComp = new List<EpisodeCompanion>();
        }
        public int EnemyId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int AuthorId { get; set; }
        public int DoctorId { get; set; }
        public string Notes { get; set; }
        public List<EpisodeEnemy> EpEnemy { get; set; }
        public List<EpisodeCompanion> EpComp { get; set; }

    }
}
