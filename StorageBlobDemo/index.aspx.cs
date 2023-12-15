using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
namespace StorageDemo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnInsert_Click(object sender, EventArgs e)
        {
            // Retrieve the storage account from the connection string.
            CloudStorageAccount storageAccount = new CloudStorageAccount(new StorageCredentials("demosatcs1", "b8iN/AP3lmTYi8dhpMr2lnXKyWKO/8ePVrw6qhisX/2qbf/2WMWeStjmQ2Jt7w6J0UMTVO6BVf21+AStowksvw=="), true);

            // Create the blob client
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container
            CloudBlobContainer container = blobClient.GetContainerReference("images");
            await container.CreateIfNotExistsAsync();

            CloudBlockBlob blockBlob = container.GetBlockBlobReference(photoUpload.PostedFile.FileName);

            // Create or overwrite the "myblob" blob with contents from a local file.
            using (var fileStream = photoUpload.PostedFile.InputStream)
            {
                blockBlob.UploadFromStream(fileStream);
            }

            lblInsert.Text = "Data Inserted Successfully!!!";
        }
    }
}
