﻿using System;
using System.Xml.Serialization;

namespace Kfstorm.BingWallpaper
{
    public class State
    {
        public string PictureUrl { get; set; }
        // ReSharper disable once InconsistentNaming
        public string _startDate;
        [XmlIgnore]
        public DateTimeOffset StartDate
        {
            get
            {
                DateTimeOffset startDate;
                DateTimeOffset.TryParse(_startDate, out startDate);
                return startDate;
            }
            set
            {
                _startDate = value.ToString();
            }
        }
        // ReSharper disable once InconsistentNaming
        public string _endDate;
        [XmlIgnore]
        public DateTimeOffset EndDate
        {
            get
            {
                DateTimeOffset endDate;
                DateTimeOffset.TryParse(_endDate, out endDate);
                return endDate;
            }
            set
            {
                _endDate = value.ToString();
            }
        }
        public string PictureFilePath { get; set; }
        public string Copyright { get; set; }
    }
}
