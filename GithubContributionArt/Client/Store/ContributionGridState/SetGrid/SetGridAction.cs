﻿using GithubContributionArt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubContributionArt.Client.Store.ContributionGridState.SetGrid
{
    public class SetGridAction
    {
        public ContributionLevel[,] ContributionGrid { get; set; }
    }
}
