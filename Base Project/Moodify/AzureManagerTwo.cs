using Microsoft.WindowsAzure.MobileServices;
using Moodify.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodify
{
     public class AzureManagerTwo
    {

        private static AzureManagerTwo instance;
        private MobileServiceClient client;
        private IMobileServiceTable<User> userTable;
        

        private AzureManagerTwo()
        {
            this.client = new MobileServiceClient("http://ajasmobileapp2.azurewebsites.net");
            this.userTable = this.client.GetTable<User>();
            
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManagerTwo AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManagerTwo();
                }

                return instance;
            }
        }

        public async Task AddUser(User user)
        {
            await this.userTable.InsertAsync(user);
        }

        public async Task<List<User>> GetUser()
        {
            return await this.userTable.ToListAsync();
        }

    }
}
