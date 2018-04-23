using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DXWebApplication3.Models {
    public class Person {
        [Key]
        public int ID { get; set; }
        public bool CanSpeakReceived { get; set; }
        public bool CanWriteReceived { get; set; }
        public bool CanUnderstandReceived { get; set; }
        public bool CanSpeakExpressed { get; set; }
        public bool CanWriteExpressed { get; set; }
        public bool CanUnderstandExpressed { get; set; }
        public Person() { }
    }
    public static class PersonLanguages {
        public static List<Person> GetPersonLanguages() {
            if (HttpContext.Current.Session["ModelList"] == null) {
                List<Person> result = new List<Person>();
                result.Add(new Person() {
                    ID = 0,
                    CanSpeakExpressed = true,
                    CanSpeakReceived = true,
                    CanUnderstandExpressed = true,
                    CanUnderstandReceived = false,
                    CanWriteExpressed = false,
                    CanWriteReceived = false
                });
                result.Add(new Person() {
                    ID = 1,
                    CanSpeakExpressed = false,
                    CanSpeakReceived = true,
                    CanUnderstandExpressed = false,
                    CanUnderstandReceived = true,
                    CanWriteExpressed = false,
                    CanWriteReceived = true
                });
                result.Add(new Person() {
                    ID = 2,
                    CanSpeakExpressed = true,
                    CanSpeakReceived = true,
                    CanUnderstandExpressed = false,
                    CanUnderstandReceived = true,
                    CanWriteExpressed = false,
                    CanWriteReceived = false
                });
                HttpContext.Current.Session["ModelList"] = result;
            }
            return (List<Person>)HttpContext.Current.Session["ModelList"];
        }

        public static List<Person> UpdatePerson(Person modelInfo) {
            Person editedModel = GetPersonLanguages().Where(m => m.ID == modelInfo.ID).First();
            editedModel.CanSpeakExpressed = modelInfo.CanSpeakExpressed;
            editedModel.CanSpeakReceived = modelInfo.CanSpeakReceived;
            editedModel.CanUnderstandExpressed = modelInfo.CanUnderstandExpressed;
            editedModel.CanWriteExpressed = modelInfo.CanWriteExpressed;
            editedModel.CanWriteReceived = modelInfo.CanWriteReceived;
            editedModel.CanUnderstandReceived = modelInfo.CanUnderstandReceived;
            return GetPersonLanguages();
        }
    }
}