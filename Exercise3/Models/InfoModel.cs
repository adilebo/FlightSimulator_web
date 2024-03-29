﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise3.Models
{
    public class InfoModel
    {
        private static InfoModel s_instace = null;

        public static InfoModel Instance
        {
            get
            {
                if (s_instace == null)
                {
                    s_instace = new InfoModel();
                }
                return s_instace;
            }
        }

        private InfoModel()
        {
            Plane = new Plane();
        }

        public Plane Plane { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public int Time { get; set; }
        public int FileName { get; set; }
        private IUpdater updater;
        public IUpdater MyUpdater
        {
            get
            {
                return updater;
            }
            set
            {
                updater?.Close();
                updater = value;
            }
        }
    }

}