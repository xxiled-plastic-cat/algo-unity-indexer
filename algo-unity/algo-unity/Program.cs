using System.Net.Http;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient httpClient = new HttpClient();
        var response = httpClient.GetAsync("https://mainnet-idx.algonode.cloud/v2/accounts/RS7TLLQRXKBAQDAVTSZC2ZLMVMLNSCL3FOUOESJJZ5XSKFFL56UI6X33CI/assets").Result;
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }

}