﻿/*
  -----------------------------------------------------------------------
  Dusty Hoppe (@HopDizzle)
  http://github.com/hopdizzle/gearhost-client-net
  ------------------------------------------------------------------------
  This file is part of gearhost-client-net.

  gearhost-client-net is free software: you can redistribute it and/or 
  modify it under the terms of the GNU General Public License as published 
  by the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  Foobar is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
  -----------------------------------------------------------------------
 */

namespace GearHost.Core
{

  using GearHost.Core.Configuration;

  /// <summary>
  /// 
  /// </summary>
  public class Config
  {
    /// <summary>
    /// 
    /// </summary>
    public static string PrimaryApiKey
    {
      get
      {
        return GearHostSection.Current.PrimaryApiKey;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static string ApiBaseUrl
    {
      get
      {
        return GearHostSection.Current.ApiBaseUrl;
      }
    }
  }
}