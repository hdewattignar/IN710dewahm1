﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    class SpeedObserver : BicycleObserver
    {
        public SpeedObserver(Label displayLabel, ISubject bicycleSubject)
            :base(displayLabel, bicycleSubject)
        {

        }

        public override void Update(int data)
        {
            RPM = data;
            currentValue = ((205 * RPM) * 60) / 100000;
            Display();
        }
    }
}
