using AsignmentDVT.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AsignmentDVT.Service
{
    public class AccountService
    {
        //Thực đăng kí người dùng với api, nhận tham số là một đối tượng của lớp Account.
        //Chuyển đối tượng về định dạng json sau đó gửi lên api với method POST
        public async Task<bool> RegisterAsync(Account account)
        {
            try
            {
                var accountJson = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                HttpClient httpClient = new HttpClient();

                //Tạo dữ liệu thô để gửi đi.
                Debug.WriteLine(accountJson);

                //Đóng gói dữ liệu, dán nhãn UTF8, dán định dạng json.
                var httpContent = new StringContent(accountJson, Encoding.UTF8, "application/json");

                //Thực hiện gửi dữ liệu sử dụng async, await
                var requestConnection =
                    await httpClient.PostAsync("https://music-i-like.herokuapp.com/api/v1/accounts", httpContent);
                if (requestConnection.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public async Task<Credential> LoginAsync(LoginInfomation loginInfomation)
        {
            try
            {
                var accountJson = Newtonsoft.Json.JsonConvert.SerializeObject(loginInfomation);
                HttpClient httpClient = new HttpClient();
                //Tạo dữ liệu thô để gửi đi.
                Console.WriteLine(accountJson);

                //Đóng gói gửi dữ liệu, dán nhãn UTF8, dán định dạng Json.
                var httpContent = new StringContent(accountJson, Encoding.UTF8, "application/json");

                //Thực hiện gửi dữ liệu sử dụng await, async.
                var requestConnection = await httpClient.PostAsync("https://music-i-like.herokuapp.com/api/v1/accounts/authentication", httpContent);
                Console.WriteLine(requestConnection.StatusCode);
                if (requestConnection.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //Lấy content dang string.
                    var content = await requestConnection.Content.ReadAsStringAsync();

                    //parse content sang lop Credential.
                    var credential = Newtonsoft.Json.JsonConvert.DeserializeObject<Credential>(content);
                    await WriteTokenToFile(content);
                    return credential;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public async Task<Account> GetInformationAsync()
        {
            //load token tu file
            var credential = await LoadAccessTokenFromFile();
            //Neu khong co token thi tra ve null
            if (credential == null)
            {
                return null;
            }

            try
            {
                HttpClient httpClient = new HttpClient();
                //Day la buoc deo the vao xe bus vao co
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {credential.access_token}");
                //Thuc hien gui du lieu su dung await, async
                var requestConnection =
                    await httpClient.GetAsync("https://music-i-like.herokuapp.com/api/v1/accounts");
                Console.WriteLine(requestConnection.StatusCode);
                if (requestConnection.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //lay content dang string
                    var content = await requestConnection.Content.ReadAsStringAsync();
                    //parse content sang lop account
                    var account = Newtonsoft.Json.JsonConvert.DeserializeObject<Account>(content);
                    Console.WriteLine(account);
                    return account;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public async Task<Credential> LoadAccessTokenFromFile()
        {
            try
            {
                //read token file
                StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                StorageFile storageFile = await storageFolder.GetFileAsync("milt.txt");
                var fileContent = await FileIO.ReadTextAsync(storageFile);
                var credential = Newtonsoft.Json.JsonConvert.DeserializeObject<Credential>(fileContent);
                return credential;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        //Luu token ra file
        private async Task WriteTokenToFile(string content)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            //Lay ra file can lam viec voi thu muc do
            StorageFile storageFile = await storageFolder.CreateFileAsync("milt.txt", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(storageFile, content);
        }
    }
}
