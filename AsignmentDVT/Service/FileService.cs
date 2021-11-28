using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentDVT.Service
{
    public class FileService
    {
        private static string CloudName = "vantien";
        private static string CloudKey = "144382198282873";
        private static string CloudApiSecret = "nUtJLG3u2zsZ2erFRv_-L3AAZjE";
        // tạo đối tượng up load
        static CloudinaryDotNet.Account account;
        static CloudinaryDotNet.Cloudinary cloud;


        public FileService()
        {
            if (account == null)
            {
                account = new CloudinaryDotNet.Account
                {
                    Cloud = CloudName,
                    ApiKey = CloudKey,
                    ApiSecret = CloudApiSecret
                };
            }
            if (cloud == null)
            {
                cloud = new CloudinaryDotNet.Cloudinary(account);
                cloud.Api.Secure = true;
            }
        }
        public async Task<string> UploadFile(Windows.Storage.StorageFile file)
        {
            if (file != null)
            {
                CloudinaryDotNet.Actions.RawUploadParams imageUploadParams = new CloudinaryDotNet.Actions.RawUploadParams
                {
                    File = new CloudinaryDotNet.FileDescription(file.Name, await file.OpenStreamForReadAsync())
                };
                //Thực hiện upload lấy thông tin về.
                CloudinaryDotNet.Actions.RawUploadResult result = await cloud.UploadAsync(imageUploadParams);
                return result.SecureUrl.OriginalString;
            }
            return null;
        }
    }
}

