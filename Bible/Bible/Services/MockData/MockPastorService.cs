using Bible.Models;
using Bible.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible.Services.MockData
{
    public class MockPastorService : IPastorService
    {
        ObservableCollection<Pastor> pastors;

        public MockPastorService()
        {
            pastors = new ObservableCollection<Pastor>() 
            {
                new Pastor()
                { 
                    Id = 1, 
                    Name = "Pastor Arjay Maligaya", 
                    Church = "Mabacan Church", 
                    Message = "The best thing in life comes to those people who wait patiently, Keep Coding", 
                    ProfilePicture ="pastor.jpg", 
                    VideoLink ="" 
                },
                new Pastor()
                {
                    Id = 2, 
                    Name = "Pastor Edhel Maligaya",
                    Church = "Central Church",
                    Message = "Your time is limited, so don’t waste it living someone else’s life. Don’t be trapped by dogma – which is living with the results of other people’s thinking",
                    ProfilePicture ="pastor.jpg",
                    VideoLink =""
                },
                new Pastor()
                {
                    Id = 3, 
                    Name = "Pastor Erick Maligaya",
                    Church = "Calauan Church",
                    Message = "Sing like no one’s listening, love like you’ve never been hurt, dance like nobody’s watching, and live like it’s heaven on earth.",
                    ProfilePicture ="pastor.jpg",
                    VideoLink =""
                },
                new Pastor()
                {
                    Id = 4, 
                    Name = "Pastor Kyle Maligaya",
                    Church = "Curba Church",
                    Message = "Your work is going to fill a large part of your life, and the only way to be truly satisfied is to do what you believe is great work. And the only way to do great work is to love what you do. If you haven’t found it yet, keep looking. Don’t settle. As with all matters of the heart, you’ll know when you find it.",
                    ProfilePicture ="pastor.jpg",
                    VideoLink =""
                },
                new Pastor()
                {
                    Id = 5, 
                    Name = "Pastor Junior Maligaya",
                    Church = "Pook Church",
                    Message = "Watch your thoughts; they become words. Watch your words; they become actions. Watch your actions; they become habits. Watch your habits; they become character. Watch your character; it becomes your destiny.",
                    ProfilePicture ="pastor.jpg",
                    VideoLink =""
                },

            };
        }

        public Pastor GetPastorById(string id)
        {
            return pastors.FirstOrDefault(p => p.Id == Convert.ToInt32(id));
        }

        public ObservableCollection<Pastor> GetPastors()
        {
            return pastors;
        }
    }
}
