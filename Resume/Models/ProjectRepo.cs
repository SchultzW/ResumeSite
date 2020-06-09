using Microsoft.EntityFrameworkCore;
using Resume.Infastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class ProjectRepo
    {
        private AppDbContext context;
        public IQueryable<MyProject> Projects
        {
            get
            {
                return context.Projects.Include("Tags");
            }
        }
        public ProjectRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public async Task<List<MyProject>>GetByTag(string tagName)
        {
            List<MyProject> projects = (from p in context.Projects
                                        where p.Tag.TagName == tagName
                                        select p).ToList();
            return projects;
        }

    }
}
