﻿/*
* Proland: a procedural landscape rendering library.
* Copyright (c) 2008-2011 INRIA
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*
* Proland is distributed under a dual-license scheme.
* You can obtain a specific license from Inria: proland-licensing@inria.fr.
*
* Authors: Eric Bruneton, Antoine Begault, Guillaume Piolat.
* 
*/

using UnityEngine;
using System;

namespace Proland
{
	public class OrthoCPUProducer : TileProducer 
	{

        public override int Border { get { return 2; } }

        public int Channels { get; private set; }

        protected override void Start()
        {
            throw new NotImplementedException();
        }
    }
}
































