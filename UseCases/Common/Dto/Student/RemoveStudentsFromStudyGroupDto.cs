﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.StudyGroup.Dto
{
    public record RemoveStudentsFromStudyGroupDto(int studyGroupId, IEnumerable<int> studentsId);
}
