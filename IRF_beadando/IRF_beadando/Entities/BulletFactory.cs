﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    public class BulletFactory
    {
        public Bullet CreateNew()
        {
            return new Bullet();
        }
    }
}
