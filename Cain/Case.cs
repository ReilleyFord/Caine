﻿using System;
using System.Collections.Generic;

namespace Cain {
    public class Case {
        public string         RootPath  { get; set; }
        public List<CaseNotes>  CaseNotes { get; set; }
        public CaseItem       CaseItem  { get; set; }

        public Case() {
            CaseNotes = new List<CaseNotes>();
        }

        public Case(string path, List<CaseNotes> caseNotes) {
            this.RootPath  = path;
            this.CaseNotes = caseNotes;
        }
    }
}