using System;
using System.Collections.Generic;
using System.Linq;

using BetterCms.Core.DataContracts;
using BetterCms.Core.Models;

namespace BetterCms.Module.Root.Models
{
    [Serializable]
    public class Layout : EquatableEntity<Layout>, ILayout
    {
        public virtual string Name { get; set; }

        public virtual string LayoutPath { get; set; }

        public virtual string PreviewUrl { get; set; }

        public virtual Module Module { get; set; }

        public virtual IList<Page> Pages { get; set; }

        public virtual IList<LayoutRegion> LayoutRegions { get; set; }

        IEnumerable<IRegion> ILayout.Regions
        {
            get { return LayoutRegions.Select(x => x.Region); }
        }
    }
}