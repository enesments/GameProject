﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Registration(Gamer gamer);
        void Update(Gamer gamer);
        void Deleted(Gamer gamer);  


    }
}
