﻿using CIPLATFORM_SKILL_PM.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace CIPLATFORM_SKILL_PM.Models.Data
{
    public class Skill:IEntityModel<Skill>
    {
        public int SkillId { get; set; }
        public string? SkillName { get; set; }
        public DateTime? CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool? Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
