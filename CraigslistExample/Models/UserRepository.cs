﻿using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CraigslistExample.Models {
    public class UserRepository : GenericRepository<User> {

        public UserRepository(DbContext db) : base(db) { }

        //public IList<User> List() {
        //    var users = (from u in _db.Users
        //                 where u.Active
        //                 select u).ToList();
        //    return users;
        //}

        //public User Find(int id) {
        //    var user = (from u in _db.Users
        //                where u.Active && u.Id == id
        //                select u).FirstOrDefault();
        //    return user;
        //}

        //public bool Add(User newUser) {
        //    try {
        //        _db.Users.Add(newUser);
        //        _db.SaveChanges();

        //        return true;
        //    }
        //    catch {
        //        return false;
        //    }
        //}

        public bool Update(User updates) {

            var dbUser = Get(updates.Id);
            if (dbUser != null) {
                dbUser.Email = updates.Email;
                dbUser.Listings = updates.Listings;

                try {
                    _db.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        //public bool Delete(int id) {
        //    var dbUser = Find(id);
        //    if(dbUser != null) {
        //        dbUser.Active = false;

        //        try {
        //            _db.SaveChanges();
        //            return true;
        //        }
        //        catch { }
        //    }
        //    return false;
        //}
    }
}