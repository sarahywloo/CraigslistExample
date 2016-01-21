using CoderCamps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CraigslistExample.Models {
    public class ListingRepository : GenericRepository<Listing> {

        public ListingRepository(DbContext db): base(db) { }

        //This is already in our generic repository
        //public IList<Listing> FindAllActive() {
        //    var listings = (from l in Table
        //                    where l.Active
        //                    select l).ToList();
        //    return listings;
        //}
        
        //This is already in our generic repository
        //returns the listing or a null
        //public Listing FindById(int id) {
        //    var listing = (from l in Table
        //                   where l.Active && l.Id == id
        //                   select l).FirstOrDefault();

        //    return listing;
        //}

        //This is Add() is now in the generic repository
        //public bool Add(Listing newListing) {
        //    try {
        //        Table.Add(newListing);
        //        _db.SaveChanges();

        //        return true;
        //    }
        //    catch {
        //        return false;
        //    }

        //}

        public bool Update(Listing updates) {

            //Get() returns the active item with that id
            var dbItem = Get(updates.Id);
            if (dbItem != null) {
                dbItem.Description = updates.Description;
                dbItem.Category = updates.Category;
                dbItem.Owner = updates.Owner;
                dbItem.Picture = updates.Picture;

                try {
                    _db.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }
        //This Delete() is now in the generic repository
        //public bool Delete(int id) {
        //    var dbItem = Find(id);
        //    if (dbItem != null) {
        //        dbItem.Active = false;
        //        try {
        //            _db.SaveChanges();
        //            return true;
        //        }
        //        catch { }
        //    }
        //    return false;
        //}

        public IList<Listing> FindByCategory(string cat) {
            return (from l in Table
                    where l.Active && l.Category.Name == cat
                    select l).ToList();
        }
    }
}