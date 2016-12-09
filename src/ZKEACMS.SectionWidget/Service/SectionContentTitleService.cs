/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using ZKEACMS.SectionWidget.Models;
using Easy.RepositoryPattern;
using Easy;
using Microsoft.EntityFrameworkCore;
using System;

namespace ZKEACMS.SectionWidget.Service
{
    public class SectionContentTitleService : ServiceBase<SectionContentTitle, SectionDbContext>, ISectionContentService
    {
        public SectionContentTitleService(IApplicationContext applicationContext) : base(applicationContext)
        {
        }
        public override DbSet<SectionContentTitle> CurrentDbSet
        {
            get
            {
                return DbContext.SectionContentTitle;
            }
        }
        public SectionContentBase.Types ContentType
        {
            get { return SectionContentBase.Types.Title; }
        }



        public void AddContent(SectionContent content)
        {
            Add(content as SectionContentTitle);
        }

        public void DeleteContent(string contentId)
        {
            Remove(contentId);
        }

        public SectionContent GetContent(string contentId)
        {
            return Get(contentId);
        }


        public void UpdateContent(SectionContent content)
        {
            Update(content as SectionContentTitle);
        }
    }
}