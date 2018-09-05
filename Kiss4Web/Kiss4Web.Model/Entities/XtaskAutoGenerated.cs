﻿using System;
using System.Collections.Generic;

namespace Kiss4Web.Model
{
    public partial class XtaskAutoGenerated
    {
        public int XtaskAutoGeneratedId { get; set; }
        public int XtaskId { get; set; }
        public string ReferenceTable { get; set; }
        public int? ReferenceId { get; set; }
        public int XtaskAutoGeneratedTypeCode { get; set; }
        public string Creator { get; set; }
        public DateTime Created { get; set; }
        public string Modifier { get; set; }
        public DateTime Modified { get; set; }
        public byte[] XtaskAutoGeneratedTs { get; set; }

        public XTask Xtask { get; set; }
    }
}
