﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IJobSeekerRepository
    {
        JobSeeker GetJobSeekerByUserId(int UserId);
        bool AddJobSeeker(JobSeeker employer);
    }
}
