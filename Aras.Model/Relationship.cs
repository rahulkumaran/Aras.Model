﻿/*  
  Aras.Model provides a .NET cient library for Aras Innovator

  Copyright (C) 2015 Processwall Limited.

  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU Affero General Public License as published
  by the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU Affero General Public License for more details.

  You should have received a copy of the GNU Affero General Public License
  along with this program.  If not, see http://opensource.org/licenses/AGPL-3.0.
 
  Company: Processwall Limited
  Address: The Winnowing House, Mill Lane, Askham Richard, York, YO23 3NW, United Kingdom
  Tel:     +44 113 815 3440
  Email:   support@processwall.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aras.Model
{
    public class Relationship : Item
    {
        public Item Source
        {
            get
            {
                return (Item)this.Property("source_id").Value;
            }
            internal set
            {
                this.Property("source_id").Value = value;
            }
        }

        public Item Related
        {
            get
            {
                return (Item)this.Property("related_id").Value;
            }
            set
            {
                this.Property("related_id").Value = value;
            }
        }

        public Relationship(Store Store, Transaction Transaction)
            : base(Store, Transaction)
        {

        }

        public Relationship(Store Store, IO.Item DBItem)
            : base(Store, DBItem)
        {

        }
    }
}
