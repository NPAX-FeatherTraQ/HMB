#region Disclaimer / License
// Copyright (C) 2011, Kenneth Skovhede
// http://www.hexad.dk, opensource@hexad.dk
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace Duplicati.Library.Snapshots
{
    /// <summary>
    /// Simple helper to initialize and load a snapshot implementation for the current OS
    /// </summary>
    public static class SnapshotUtility
    {
        /// <summary>
        /// Loads a snapshot implementation for the current OS
        /// </summary>
        /// <param name="folders">The list of folders to create snapshots of</param>
        /// <param name="options">A set of commandline options</param>
        /// <returns>The ISnapshotService implementation</returns>
        public static ISnapshotService CreateSnapshot(string[] folders, Dictionary<string, string> options)
        {
            if (Utility.Utility.IsClientLinux)
                return new LinuxSnapshot(folders, options);
            else
                return new WindowsSnapshot(folders, options);
        }
    }
}
