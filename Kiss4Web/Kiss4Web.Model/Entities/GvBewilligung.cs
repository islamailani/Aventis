﻿using System;
using System.Collections.Generic;

namespace Kiss4Web.Model
{
    public partial class GvBewilligung
    {
        public int GvBewilligungId { get; set; }
        public int GvGesuchId { get; set; }
        public int UserId { get; set; }
        public int GvBewilligungCode { get; set; }
        public string Creator { get; set; }
        public DateTime Created { get; set; }
        public string Modifier { get; set; }
        public DateTime Modified { get; set; }
        public byte[] GvBewilligungTs { get; set; }

        public GvGesuch GvGesuch { get; set; }
        public XUser User { get; set; }
    }
}
