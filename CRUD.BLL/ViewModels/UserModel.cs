﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL.ViewModels {

    public class UserModel {

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public System.DateTime Birthdate { get; set; }
        public bool Gender { get; set; }

    }

}