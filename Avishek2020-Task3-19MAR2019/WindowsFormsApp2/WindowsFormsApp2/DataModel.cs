using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class DataModel
    {
        //[BsonId]
       // public ObjectId Id { get; set; }
        [BsonElement("fname")]
        public String First_Name { get; set; }
        [BsonElement("mname")]
        public String Middle_Name { get; set; }
        [BsonElement("lname")]
        public String Last_Name { get; set; }
        [BsonElement("Add1")]
        public String Address1 { get; set; }
        [BsonElement("Add2")]
        public String Address2 { get; set; }
        [BsonElement("DOB")]
        public DateTime Date_Of_Birth { get; set; }
        [BsonElement("City")]
        public String City { get; set; }
        [BsonElement("State")]
        public String State { get; set; }
        [BsonElement("Country")]
        public String Country { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }

        public DataModel(string fname, 
                           string mname, 
                           string lname, 
                           string add1, 
                           string add2,
                           DateTime dob,
                           string city,
                           string state, 
                           string country)
        {
            
            First_Name = fname;
            Middle_Name = mname;
            Last_Name = lname;
            Address1  = add1;
            Address2  = add2;            
            Date_Of_Birth = dob;
            City  = city;
            State = state;
            Country = country;
        }
        
    }
}
