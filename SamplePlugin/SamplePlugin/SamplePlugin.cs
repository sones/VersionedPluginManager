﻿/*
* VersionedPluginManager
* http://github.com/xalax/VersionedPluginManager
*
* Copyright (c) 2010 Stefan Licht
*
* Licensed under the MIT License. You may not use this file except
* in compliance with the License. You may obtain a copy of the License at
*
* http://www.opensource.org/licenses/mit-license.php
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xalax.SamplePlugin
{
    public class SamplePlugin : ISamplePlugin.ISamplePlugin
    {
        #region ISamplePlugin Members

        public string SampleMethod(int param1, string param2)
        {
            return System.Reflection.Assembly.GetAssembly(typeof(SamplePlugin)).GetName().Name;
        }

        #endregion
    }
}
