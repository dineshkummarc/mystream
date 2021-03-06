﻿// Copyright (c) Tanzim Saqib. All rights reserved.
// For continued development and updates, visit http://TanzimSaqib.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStream.Data
{
    public interface ISiteInfoRepository
    {
        SiteInfo Get();
        SiteInfo Insert(string title, string slogan, string password, int cacheDuration, string currentTheme);
        SiteInfo Update(SiteInfo info, Action<SiteInfo> populate);
    }
}
