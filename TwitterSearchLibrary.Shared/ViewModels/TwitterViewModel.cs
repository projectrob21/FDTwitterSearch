﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LinqToTwitter;
using XamarinForms.Models;

namespace XamarinForms.ViewModels
{
    public class TwitterViewModel : INotifyPropertyChanged
    {

        private List<Tweet> _tweets;
        public List<Tweet> Tweets
        {
            get { return _tweets; }
            set
            {
                if (_tweets == value)
                    return;

                _tweets = value;
                OnPropertyChanged();
            }
        }

        public TwitterViewModel()
        {
            InitTweetsAsync();
        }

        public async Task InitTweetsAsync()
        {

            var auth = new ApplicationOnlyAuthorizer()
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = "mhMSvHsLgdmVe7UxVY3abssFw",
                    ConsumerSecret = "o0cAYqy9JHyuwrOcrnUqlzUfwpF3NvN3PxvzrwHDE0vj39Ynxd",
                },
            };

            await auth.AuthorizeAsync();

            var ctx = new TwitterContext(auth);

            var tweets = await
                (from tweet 
                 in ctx.Status
                 where tweet.Type == StatusType.User 
                       && tweet.ScreenName == "POTUS"
                       && tweet.Count == 30
                 select tweet)
                .ToListAsync();

            Tweets = (from tweet 
                      in tweets
                      select new Tweet
                      {
                          StatusID = tweet.StatusID,
                          ScreenName = tweet.User.ScreenNameResponse,
                          Text = tweet.Text,
                          ImageUrl = tweet.User.ProfileImageUrl,
                          MediaUrl = tweet?.Entities?.MediaEntities?.FirstOrDefault()?.MediaUrl
                      })
                .ToList();

            //Search searchResponse = await
            //    (from search in ctx.Search
            //     where search.Type == SearchType.Search &&
            //           search.Query == "VisualStudio"
            //     select search)
            //    .SingleAsync();

            //Tweets =
            //    (from tweet in searchResponse.Statuses
            //     select new Tweet
            //     {
            //         StatusID = tweet.StatusID,
            //         ScreenName = tweet.User.ScreenNameResponse,
            //         Text = tweet.Text,
            //         ImageUrl = tweet.User.ProfileImageUrl
            //     })
            //    .ToList();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
