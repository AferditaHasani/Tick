﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Tick.DAL;
using Tick.BO;

namespace Tick.BLL
{
  public  class TaskBLL
    {
        private TaskDAL taskDAL_db;

        public TaskBLL()
        {
            taskDAL_db = new TaskDAL();
        }

        public bool Insert(Task task)
        {
            return taskDAL_db.Add(task);
        }

        public DataTable GetAll(int id)
        {
            return taskDAL_db.GetAll(id);
        }

        public bool Update(Task tsk)
        {
            return taskDAL_db.Update(tsk);
        }
        public bool Delete(Task tsk)
        {
            return taskDAL_db.Delete(tsk);
        }
    }
}
