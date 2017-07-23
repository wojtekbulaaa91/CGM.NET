﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGM.Communication.Data.Repository
{
    public class SettingRepository : BaseRepository<Setting>
    {
        public SettingRepository(CgmUnitOfWork uow):base(uow)
        {

        }

        public Setting GetSettings()
        {
            var query = _uow.Connection.Table<Setting>().Where(v => v.SettingId == 1);
            Setting setting = query.FirstOrDefault();
            if (setting==null)
            {
                setting = new Setting();
            };
            return setting;
        }
    }
}