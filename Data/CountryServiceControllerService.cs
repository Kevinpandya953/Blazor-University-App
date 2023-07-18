using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorApp2.Models;
using BlazorApp2.Data;

namespace BlazorApp2.Data
{
   public class CountryServiceControllerService
   {
         UniversityNewContext db=new UniversityNewContext();
		 
        //To Get all Country details   
        public DbSet<Country> GetAllCountry()
        {
            try
            {
                return db.Country;
            }
            catch
            {
                throw;
            }
        }
       // To Add new Data record
        public void AddCountry(Country Data)
        {
            try
            {
                db.Country.Add(Data);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Data    
         public void UpdateCountry(Country Data)
        {
            try
            {
                var data = db.Country.Where(x => x.CountryId == Data.CountryId).SingleOrDefault();
                data!.CountryId=Data.CountryId;
                data!.CountryName=Data.CountryName;
                data!.Campus=Data.Campus;
                data!.Faculty=Data.Faculty;
                data!.State=Data.State;
                data!.Student=Data.Student;
                data!.University=Data.University;
		   
			  
               db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Data
         public void DeleteCountry(int value)
         {
           try
           {
             Country? data = db.Country.Find(value);
            db.Country.Remove(data!);
            db.SaveChanges();
           }
           catch
           {
             throw;
            }
          }

        //Get the details of a particular Data    
        public Country GetCountryData(int id)
        {
            try
            {
                Country? Data = db.Country.Find(id);
                return Data!;
            }
            catch
            {
                throw;
            }
        }
    }
   
}