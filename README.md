# WPFDevLinkUpdater

**WPFDevLinkUpdater** is a WPF-based application designed to simplify the process of providing direct download and update links for applications. This tool is aimed at developers who want to streamline the update process for their users by embedding download and update functionality directly into their applications.

## Features

- **Direct Download**: Easily download the latest version of your application with a single click.
- **Automatic Updates**: Update the application directly from within the tool, ensuring users always have the latest version.
- **Customizable**: Easily integrate and customize the tool to fit your application's needs.

## How It Works

This WPF application uses a direct URL to download a ZIP file containing the latest version of your software. The tool extracts the contents, replaces old files, and installs the new version, all with minimal user interaction.

### Code Snippet

```csharp
public partial class MainWindow : Window
{
    string url = "urloftheodownloadlink";
    string zipname = "nameofthezip.zip";
    string filename = "anythingcangohere";

    private void UpdateButton(object sender, RoutedEventArgs e)
    {
        WebClient webClient = new WebClient();
        Directory.Delete(filename, true);
        webClient.DownloadFile(url, zipname);
        ZipFile.ExtractToDirectory(zipname, filename);
        File.Delete(zipname);
        MessageBox.Show("UPDATED");
    }

    private void DownloadButton(object sender, RoutedEventArgs e)
    {
        WebClient webClient = new WebClient();
        webClient.DownloadFile(url, zipname);
        ZipFile.ExtractToDirectory(zipname, filename);
        File.Delete(zipname);
        MessageBox.Show("DOWNLOADED");
    }
}
```

## Setup Instructions

1. Clone the repository:

    ```bash
    git clone https://github.com/YourUsername/WPFDevLinkUpdater.git
    ```

2. Open the solution in Visual Studio or your preferred IDE.

3. Update the `url`, `zipname`, and `filename` variables in the `MainWindow.xaml.cs` file with your specific values.

4. Build the project and run it.
