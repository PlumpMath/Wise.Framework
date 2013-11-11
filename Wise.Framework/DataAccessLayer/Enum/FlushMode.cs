﻿using System;

namespace Wise.Framework.DataAccessLayer.Enum
{
    [Serializable]
    public enum FlushMode
    {
        Unspecified = -1,
        Never = 0,
        Commit = 5,
        Auto = 10,
        Always = 20,
    }
}
