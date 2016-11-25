using Microsoft.WindowsAzure.MobileServices;
using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<Timeline> timelineTable;
        private IMobileServiceTable<News> newsTable;
        private IMobileServiceTable<User> userTable;
        private IMobileServiceTable<Prefs> prefTable;
        private IMobileServiceTable<Order> orderTable;


        private AzureManager()
        {
            this.client = new MobileServiceClient("http://ajasmobileapp.azurewebsites.net");
            this.timelineTable = this.client.GetTable<Timeline>();
            this.newsTable = this.client.GetTable<News>();
            this.userTable = this.client.GetTable<User>();
            this.prefTable = this.client.GetTable<Prefs>();
            this.orderTable = this.client.GetTable<Order>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task AddTimeline(Timeline timeline)
        {
            await this.timelineTable.InsertAsync(timeline);
        }

        public async Task<List<Timeline>> GetTimelines()
        {
            return await this.timelineTable.ToListAsync();
        }


        public async Task addNews(News news)
        {
            await this.newsTable.InsertAsync(news);
        }

        public async Task<List<News>> GetNews()
        {
            return await this.newsTable.ToListAsync();
        }

        public async Task AddUser(User user)
        {
            await this.userTable.InsertAsync(user);
        }

        public async Task<List<User>> GetUser()
        {
            return await this.userTable.ToListAsync();
        }

        public async Task UpdateUser(User user)
        {
            await this.userTable.UpdateAsync(user);
        }

        public async Task DeleteUser(User user)
        {
            await this.userTable.DeleteAsync(user);

        }

        public async Task AddPrefs(Prefs pref)
        {
            await this.prefTable.InsertAsync(pref);
        }

        public async Task<List<Prefs>> GetPrefs()
        {
            return await this.prefTable.ToListAsync();
        }

        public async Task AddOrder (Order order)
        {
            await this.orderTable.InsertAsync(order);
        }
    }
}
